using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.Xml;
using System.Security.Policy;
using static System.Windows.Forms.AxHost;

// todo
// as the car gets damage it should get less controlabel and speed or delay
// countdown before start
// crash icon on crash x


namespace carRacer
{
    public partial class Form1 : Form
    {
        // int coins = 100;
        int score = 0;
        int highScore = 0;
        int time = 0;

        class Car
        {
            // config
            static int maxSteering = 16;
            static int maxSpeed = 20;
            static int damageValue = 10;
            static int repairMultiplier = 3;


            public string name = "";
            public Bitmap skin;
            public int speed = 0;
            public int steering = 0;
            public int health = 0;
            private int repairTime = 0;
            public Car(string name, Bitmap skin, int speed, int steering, int health = 100)
            {
                // speed and steering are given as persentages
                this.name = name;
                this.skin = skin;
                this.speed = speed;
                this.steering = steering;
                this.health = health;
            }
            public int getSpeed()
            {
                return Convert.ToInt32((double)speed / 100 * maxSpeed);
            }
            public int getSteering()
            {
                return Convert.ToInt32((double)steering / 100 * maxSteering);
            }
            public void repair()
            {
                if (health == 100)
                    return;

                if (getRepairRemainingTime() == 0)
                    health = 100;
                else
                    repairTime++;
            }
            public int getRepairRemainingTime()
            {
                return (100 - health) * repairMultiplier - repairTime;
            }
            public void damage()
            {
                health -= damageValue;
                repairTime = 0;
            }
        }
        Car[] cars;
        int activeCarIndex = 0;
        int carsCount = 0;

        int roadMargin = 10;// 84

        int progressBarContainerWidth = 200;
        string state = "landpage";
        bool isRightDown = false;
        bool isLeftDown = false;
        string keyState = "";

        Point myCarInitialLocation = new Point(208, 494);

        Point landpageInitialLocation = new Point(46, 46);

        abstract class RoadMark
        {
            protected Point p1, p2;
            protected bool dashed;
            abstract public void paint(Graphics graphics, Pen pen, bool clearFirst = false);
            abstract public void move(int movePortion = 0);
            abstract protected void retract();
        }

        class SolidRoadMark : RoadMark
        {
            static float[] dashValues = { 1 };
            public SolidRoadMark(Point p1, Point p2)
            {
                this.p1 = p1;
                this.p2 = p2;
                dashed = false;
            }

            public override void paint(Graphics graphics, Pen pen, bool clearFirst)
            {
                pen.DashPattern = dashValues;
                graphics.DrawLine(pen, p1, p2);
            }

            public override void move(int movePortion = 0)
            {
                return;// not needed
            }

            protected override void retract()
            {
                return;// not needed
            }
        }

        class DashedRoadMark : RoadMark
        {
            static float[] dashValues = { 10, 10 };
            static int defaultMovePortion = 6;
            public DashedRoadMark(Point p1, Point p2)
            {
                this.p1 = p1;
                this.p2 = p2;
                dashed = true;
            }

            public override void paint(Graphics graphics, Pen pen, bool clearFirst)
            {
                if (clearFirst)
                {

                    Pen majicPen = new Pen(Color.FromArgb(255, 34, 34, 34), 5);
                    graphics.DrawLine(majicPen, p1, p2);
                }
                pen.DashPattern = dashValues;
                graphics.DrawLine(pen, p1, p2);
            }

            public override void move(int movePortion = 0)
            {
                if (movePortion == 0)
                    movePortion = defaultMovePortion;

                Point p1_tmp = new Point(p1.X, p1.Y + movePortion);
                Point p2_tmp = new Point(p2.X, p2.Y + movePortion);
                p1 = p1_tmp;
                p2 = p2_tmp;

                if (p1.Y >= -5)
                    retract();
            }

            protected override void retract()
            {
                Point p1_tmp = new Point(p1.X, -80);
                Point p2_tmp = new Point(p2.X, 668);
                p1 = p1_tmp;
                p2 = p2_tmp;
            }
        }

        RoadMark[] roadMarks;
        int roadMarksCount = 0;

        Graphics road;
        Pen pen;

        class Obstacle
        {
            public PictureBox picBox = null;
            bool active = false;
            static int defaultMovePortion = 6;
            private Bitmap[] skins;
            int skinsCount = 8;
            static int blockActivationFor = 0;
            double multiplier = 0;

            public Obstacle(PictureBox pb, Bitmap[] sk, double mult = 1)
            {
                picBox = pb;
                skins = sk;
                multiplier = mult;
                retract();
            }

            public void move(int movePortion = 0)
            {
                if (!active)
                    return;

                if (movePortion == 0)
                    movePortion = defaultMovePortion;

                Point tmp = new Point(picBox.Location.X, picBox.Location.Y + Convert.ToInt32(movePortion * multiplier));
                picBox.Location = tmp;

                if (picBox.Location.Y >= 668)
                    retract();
            }

            public void retract()
            {
                Point tmp = new Point(picBox.Location.X, -120);
                picBox.Location = tmp;
                active = false;
            }

            public void randomize()
            {
                if (active)
                    return;

                if (blockActivationFor-- > 0)
                    return;

                // 1 percent chance to show up if not active
                Random rnd = new Random();
                /*if (rnd.Next(1, 100) != 1)
                    return;*/

                picBox.BackgroundImage = skins[rnd.Next(0, skinsCount - 1)];
                active = true;
                blockActivationFor = 120;
            }

            public bool hit(PictureBox myCar)
            {
                int R1_left = picBox.Location.X,
                    R1_right = R1_left + picBox.Width,
                    R1_top = picBox.Location.Y,
                    R1_bottom = R1_top + picBox.Height;

                int R2_left = myCar.Location.X,
                    R2_right = R2_left + myCar.Width,
                    R2_top = myCar.Location.Y,
                    R2_bottom = R2_top + myCar.Height;

                return !(R1_left > R2_right) &&
                    !(R1_right < R2_left) &&
                    !(R1_top > R2_bottom) &&
                    !(R1_bottom < R2_top);
            }
        }
        Obstacle[] obstacles;
        int obstaclesCount = 0;

        static Bitmap[] carSkins = [
            Properties.Resources.car1,
            Properties.Resources.car2,
            Properties.Resources.car3,
            Properties.Resources.car4,
            Properties.Resources.car5,
            Properties.Resources.car6,
            Properties.Resources.car7,
            Properties.Resources.car8,
            ];
        static Bitmap[] treeSkins = [
            Properties.Resources.tree1,
            Properties.Resources.tree2,
            Properties.Resources.tree3,
            Properties.Resources.tree4,
            Properties.Resources.tree5,
            Properties.Resources.tree6,
            Properties.Resources.tree7,
            Properties.Resources.tree8,
            Properties.Resources.tree9,
            Properties.Resources.tree10,
            Properties.Resources.tree11,
            Properties.Resources.tree12,
            Properties.Resources.tree13,
            Properties.Resources.tree14,
            Properties.Resources.tree15,
            Properties.Resources.tree16,
            ];

        string ensure2digits(int t)
        {
            return t < 10 ? "0" + Convert.ToString(t) : Convert.ToString(t);
        }
        string ensureNdigits(int t, int n)
        {
            int count = Convert.ToString(t).Count();
            string rtn = "";
            for (int i = 0; i < n - count; i++)
                rtn += "0";
            rtn += Convert.ToString(t);
            return rtn;
        }

        public Form1()
        {
            InitializeComponent();

            initiate();
        }
        void initiate()
        {
            initiateCars();

            initiateCanvas();

            initiateRoadMarks();

            initiateObstacles();
        }
        void initiateCars()
        {
            cars = new Car[8];
            cars[carsCount++] = new Car("Car 1", Properties.Resources.car1, 60, 50);
            cars[carsCount++] = new Car("Car 2", Properties.Resources.car2, 70, 60);
            cars[carsCount++] = new Car("Car 3", Properties.Resources.car3, 90, 40);
            cars[carsCount++] = new Car("Car 4", Properties.Resources.car4, 60, 70);
            cars[carsCount++] = new Car("Car 5", Properties.Resources.car5, 30, 40);
            cars[carsCount++] = new Car("Car 6", Properties.Resources.car6, 40, 60);
            cars[carsCount++] = new Car("Car 7", Properties.Resources.car7, 30, 30);
            cars[carsCount++] = new Car("Car 8", Properties.Resources.car8, 70, 90);
            updateCarData();
        }
        void initiateCanvas()
        {
            road = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Gray, 4);
        }
        void initiateRoadMarks()
        {
            int upperBound = -80, lowerBound = pictureBox1.Height;
            int leftBound = 70, rightBound = pictureBox1.Width - leftBound;
            int viewportWidth = rightBound - leftBound;
            int linesCount = 4;
            int portion = viewportWidth / linesCount;

            roadMarks = new RoadMark[linesCount + 1];
            Point p1, p2;

            p1 = new Point(leftBound, upperBound);
            p2 = new Point(leftBound, lowerBound);
            roadMarks[roadMarksCount++] = new SolidRoadMark(p1, p2);

            for (int i = 1; i <= linesCount - 1; i++)
            {
                p1 = new Point(leftBound + portion * i, upperBound);
                p2 = new Point(leftBound + portion * i, lowerBound);
                roadMarks[roadMarksCount++] = new DashedRoadMark(p1, p2);
            }

            p1 = new Point(rightBound, upperBound);
            p2 = new Point(rightBound, lowerBound);
            roadMarks[roadMarksCount++] = new SolidRoadMark(p1, p2);
        }
        void initiateObstacles()
        {
            obstacles = new Obstacle[10];
            // cars
            obstacles[obstaclesCount++] = new Obstacle(car1, carSkins);
            obstacles[obstaclesCount++] = new Obstacle(car2, carSkins);
            obstacles[obstaclesCount++] = new Obstacle(car3, carSkins);
            obstacles[obstaclesCount++] = new Obstacle(car4, carSkins);
            // trees
            obstacles[obstaclesCount++] = new Obstacle(tree1, treeSkins, 2);
            obstacles[obstaclesCount++] = new Obstacle(tree2, treeSkins, 2);
            obstacles[obstaclesCount++] = new Obstacle(tree3, treeSkins, 2);
            obstacles[obstaclesCount++] = new Obstacle(tree4, treeSkins, 2);
            obstacles[obstaclesCount++] = new Obstacle(tree5, treeSkins, 2);
            obstacles[obstaclesCount++] = new Obstacle(tree6, treeSkins, 2);
        }
        void landpage()
        {
            highScore = score > highScore ? score : highScore;

            landpageScoreValue.Text = Convert.ToString(score);
            landpageHighScoreValue.Text = Convert.ToString(highScore);

            myCar.Location = myCarInitialLocation;

            for (int i = 0; i < obstaclesCount; i++)
            {
                obstacles[i].retract();
            }

            updateRepairMsg();
        }
        void inGame()
        {
            score = 0;
            time = 0;
        }
        void changeState(string state)
        {
            this.state = state;
        }
        void updateProgressBar(Panel pnl, int value)
        {
            int multiplier = progressBarContainerWidth / 100;
            pnl.Width = value * multiplier;
            if (value >= 70)
                pnl.BackColor = Color.GreenYellow;
            else if (value >= 30)
                pnl.BackColor = Color.Yellow;
            else
                pnl.BackColor = Color.IndianRed;
        }
        void updateCarData()
        {
            Car activeCar = cars[activeCarIndex];

            updateProgressBar(speedValue, activeCar.speed);
            updateProgressBar(steeringValue, activeCar.steering);
            updateProgressBar(healthValue, activeCar.health);
            carName.Text = activeCar.name;

            updateRepairMsg();


            if (activeCar.health == 0)
                DamageMsg.Visible = true;
            else
                DamageMsg.Visible = false;
        }
        void updateInGameData()
        {
            if (state != "playing")
                return;

            int mins = time / 60;
            int seconds = time % 60;
            inGameTime.Text = ensure2digits(mins) + ":" + ensure2digits(seconds);
            inGameScore.Text = ensureNdigits(score, 5);
        }
        void changeMyCar(string key)
        {
            if (key == "right")
            {
                activeCarIndex = ++activeCarIndex % carsCount;
            }
            if (key == "left")
            {
                activeCarIndex = activeCarIndex <= 0 ? carsCount - 1 : --activeCarIndex;
            }
            myCar.BackgroundImage = cars[activeCarIndex].skin;
            updateCarData();
        }
        void startGame()
        {
            if (cars[activeCarIndex].health <= 0)
                return;

            state = "playing";
            landpagePanel.Visible = false;
            inGamePanel.Visible = true;
            timer.Enabled = true;
            inGame();
        }
        void endGame()
        {
            keyState = "";
            state = "landpage";
            timer.Enabled = false;
            myCar.Image = null;
            crashPanel.Visible = false;
            landpagePanel.Visible = true;
            inGamePanel.Visible = false;
            cars[activeCarIndex].damage();
            road.Clear(Color.FromArgb(255, 34, 34, 34));
            landpage();
        }
        void crashScreen()
        {
            keyState = "";
            state = "crash";
            timer.Enabled = false;
            crashPanel.Visible = true;
            //addExplosion();
            myCar.Image = Properties.Resources.explosion;
            playCrashSound();
        }
        /*void addExplosion()
        {
            Point tmp = new Point(myCar .Location.X - 10, myCar.Location.Y - 20);
            explosion.Location = tmp;
            explosion.Visible = true;
        }*/
        void playCrashSound()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();
        }
        void manageKeyState()
        {
            if (keyState == "")
            {
                if (isRightDown)
                    keyState = "right";
                if (isLeftDown)
                    keyState = "left";
            }
            else if (keyState == "right")
            {
                if (isRightDown && isLeftDown)
                    keyState = "left";
                if (!isRightDown && !isLeftDown)
                    keyState = "";
            }
            else if (keyState == "left")
            {
                if (isRightDown && isLeftDown)
                    keyState = "right";
                if (!isRightDown && !isLeftDown)
                    keyState = "";
            }
        }
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && state == "playing")
                endGame();
            
            if (e.KeyCode == Keys.Space && state == "landpage")
                startGame();
            
            if (e.KeyCode == Keys.Space && state == "crash")
                endGame();
            
            if (e.KeyCode == Keys.Right)
                isRightDown = true;
            
            if (e.KeyCode == Keys.Left)
                isLeftDown = true;
            
            manageKeyState();

            if (state == "landpage")
                changeMyCar(keyState);
            
        }
        void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                isRightDown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                isLeftDown = false;
            }

            manageKeyState();
        }
        void repairInterval()
        {
            for (int i = 0; i < carsCount; i++)
            {
                if (i == activeCarIndex)
                    continue;

                cars[i].repair();
            }

            if (state != "playing")
                cars[activeCarIndex].repair();

            if (state == "landpage")
                updateRepairMsg();
            
        }
        void updateRepairMsg()
        {
            if (cars[activeCarIndex].health < 100)
                repairMsg.Visible = true;
            else
                repairMsg.Visible = false;

            int remainingTime = cars[activeCarIndex].getRepairRemainingTime();
            int sec = remainingTime % 60;
            int min = remainingTime / 60;
            repairMsg.Text = "Reapiring in " + ensure2digits(min) + ":" + ensure2digits(sec);
        }
        void updateRoadMap()
        {
            // road.Clear(Color.FromArgb(255, 34, 34, 34));
            for (int i = 0; i < roadMarksCount; i++)
            {
                roadMarks[i].move(cars[activeCarIndex].getSpeed());
                roadMarks[i].paint(road, pen, true);
            }
        }
        void updateObstacles()
        {
            for (int i = 0; i < obstaclesCount; i++)
            {
                obstacles[i].randomize();
                obstacles[i].move(cars[activeCarIndex].getSpeed() / 2);
                if (obstacles[i].hit(myCar))
                {
                    crashScreen();
                    break;
                }
            }
        }
        void landpageRightArrow_Click(object sender, EventArgs e)
        {
            changeMyCar("right");
        }
        void landpageLeftArrow_Click(object sender, EventArgs e)
        {
            changeMyCar("left");
        }
        void inGameEscape_Click(object sender, EventArgs e)
        {
            endGame();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (state == "playing")
            {
                updateRoadMap();
                updateObstacles();

                Point tmp = myCar.Location;

                if (keyState == "left")
                {
                    int x = myCar.Location.X - cars[activeCarIndex].getSteering() < roadMargin ? roadMargin : myCar.Location.X - cars[activeCarIndex].getSteering();
                    tmp = new Point(x, myCar.Location.Y);
                }
                else if (keyState == "right")
                {
                    int x = myCar.Location.X + cars[activeCarIndex].getSteering() > pictureBox1.Width - myCar.Width - roadMargin ? pictureBox1.Width - myCar.Width - roadMargin : myCar.Location.X + cars[activeCarIndex].getSteering();
                    tmp = new Point(x, myCar.Location.Y);
                }

                myCar.Location = tmp;
                score += (cars[activeCarIndex].getSpeed() + cars[activeCarIndex].getSteering()) / 10;
                updateInGameData();
            }
        }
        void clockTimer_Tick(object sender, EventArgs e)
        {
            if (state == "playing")
            {
                time++;
                updateInGameData();
            }

            updateCarData();
            repairInterval();
        }
    }
}
