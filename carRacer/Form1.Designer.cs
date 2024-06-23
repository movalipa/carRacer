namespace carRacer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            myCar = new PictureBox();
            crashPanel = new Panel();
            crashPanelLabel = new Label();
            crashPanelDesc = new Label();
            inGamePanel = new Panel();
            inGameEscape = new Label();
            inGameTime = new Label();
            inGameScore = new Label();
            tree6 = new PictureBox();
            tree5 = new PictureBox();
            tree4 = new PictureBox();
            tree3 = new PictureBox();
            tree2 = new PictureBox();
            tree1 = new PictureBox();
            car4 = new PictureBox();
            car3 = new PictureBox();
            car2 = new PictureBox();
            car1 = new PictureBox();
            landpagePanel = new Panel();
            healthContainer = new Panel();
            healthValue = new Panel();
            steeringContainer = new Panel();
            steeringValue = new Panel();
            speedContainer = new Panel();
            speedValue = new Panel();
            landpageLeftArrow = new PictureBox();
            landpageRightArrow = new PictureBox();
            landpageScoreTitle = new Label();
            landpageHighScoreTitle = new Label();
            landpageScoreValue = new Label();
            healthTitle = new Label();
            steeringTitle = new Label();
            carName = new Label();
            speedTitle = new Label();
            repairMsg = new Label();
            DamageMsg = new Label();
            landpageDesc = new Label();
            landpageTitle = new Label();
            landpageHighScoreValue = new Label();
            timer = new System.Windows.Forms.Timer(components);
            clockTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myCar).BeginInit();
            crashPanel.SuspendLayout();
            inGamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tree6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tree5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tree4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tree3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tree2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tree1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)car1).BeginInit();
            landpagePanel.SuspendLayout();
            healthContainer.SuspendLayout();
            steeringContainer.SuspendLayout();
            speedContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)landpageLeftArrow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)landpageRightArrow).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(34, 34, 34);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(468, 668);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 34, 34);
            panel1.Controls.Add(myCar);
            panel1.Controls.Add(crashPanel);
            panel1.Controls.Add(inGamePanel);
            panel1.Controls.Add(tree6);
            panel1.Controls.Add(tree5);
            panel1.Controls.Add(tree4);
            panel1.Controls.Add(tree3);
            panel1.Controls.Add(tree2);
            panel1.Controls.Add(tree1);
            panel1.Controls.Add(car4);
            panel1.Controls.Add(car3);
            panel1.Controls.Add(car2);
            panel1.Controls.Add(car1);
            panel1.Controls.Add(landpagePanel);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 668);
            panel1.TabIndex = 0;
            // 
            // myCar
            // 
            myCar.BackColor = Color.Transparent;
            myCar.BackgroundImage = Properties.Resources.car1;
            myCar.BackgroundImageLayout = ImageLayout.Center;
            myCar.Location = new Point(207, 494);
            myCar.Name = "myCar";
            myCar.Size = new Size(52, 110);
            myCar.TabIndex = 2;
            myCar.TabStop = false;
            // 
            // crashPanel
            // 
            crashPanel.BackColor = Color.Transparent;
            crashPanel.Controls.Add(crashPanelLabel);
            crashPanel.Controls.Add(crashPanelDesc);
            crashPanel.Location = new Point(82, 154);
            crashPanel.Name = "crashPanel";
            crashPanel.Size = new Size(302, 122);
            crashPanel.TabIndex = 8;
            crashPanel.Visible = false;
            // 
            // crashPanelLabel
            // 
            crashPanelLabel.AutoSize = true;
            crashPanelLabel.BackColor = Color.Transparent;
            crashPanelLabel.Font = new Font("Cooper Black", 32F);
            crashPanelLabel.ForeColor = Color.IndianRed;
            crashPanelLabel.Location = new Point(0, 0);
            crashPanelLabel.Name = "crashPanelLabel";
            crashPanelLabel.Size = new Size(302, 49);
            crashPanelLabel.TabIndex = 7;
            crashPanelLabel.Text = "GAME OVER";
            // 
            // crashPanelDesc
            // 
            crashPanelDesc.AutoSize = true;
            crashPanelDesc.BackColor = Color.Transparent;
            crashPanelDesc.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            crashPanelDesc.ForeColor = SystemColors.Control;
            crashPanelDesc.Location = new Point(18, 69);
            crashPanelDesc.Name = "crashPanelDesc";
            crashPanelDesc.Size = new Size(265, 32);
            crashPanelDesc.TabIndex = 1;
            crashPanelDesc.Text = "Press space to continue";
            // 
            // inGamePanel
            // 
            inGamePanel.BackColor = Color.Transparent;
            inGamePanel.Controls.Add(inGameEscape);
            inGamePanel.Controls.Add(inGameTime);
            inGamePanel.Controls.Add(inGameScore);
            inGamePanel.Location = new Point(0, 0);
            inGamePanel.Name = "inGamePanel";
            inGamePanel.Size = new Size(468, 40);
            inGamePanel.TabIndex = 6;
            inGamePanel.Visible = false;
            // 
            // inGameEscape
            // 
            inGameEscape.AutoSize = true;
            inGameEscape.BackColor = Color.Transparent;
            inGameEscape.Cursor = Cursors.Hand;
            inGameEscape.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            inGameEscape.ForeColor = Color.IndianRed;
            inGameEscape.Location = new Point(397, 6);
            inGameEscape.Name = "inGameEscape";
            inGameEscape.Size = new Size(65, 25);
            inGameEscape.TabIndex = 0;
            inGameEscape.Text = "Escape";
            inGameEscape.Click += inGameEscape_Click;
            // 
            // inGameTime
            // 
            inGameTime.AutoSize = true;
            inGameTime.BackColor = Color.Transparent;
            inGameTime.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inGameTime.ForeColor = SystemColors.Control;
            inGameTime.Location = new Point(204, 8);
            inGameTime.Name = "inGameTime";
            inGameTime.Size = new Size(62, 25);
            inGameTime.TabIndex = 0;
            inGameTime.Text = "00:00";
            // 
            // inGameScore
            // 
            inGameScore.AutoSize = true;
            inGameScore.BackColor = Color.Transparent;
            inGameScore.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inGameScore.ForeColor = SystemColors.ActiveCaption;
            inGameScore.Location = new Point(6, 7);
            inGameScore.Name = "inGameScore";
            inGameScore.Size = new Size(67, 25);
            inGameScore.TabIndex = 0;
            inGameScore.Text = "00000";
            // 
            // tree6
            // 
            tree6.BackgroundImage = Properties.Resources.tree1;
            tree6.Location = new Point(19, 118);
            tree6.Name = "tree6";
            tree6.Size = new Size(30, 30);
            tree6.TabIndex = 1;
            tree6.TabStop = false;
            // 
            // tree5
            // 
            tree5.BackgroundImage = Properties.Resources.tree1;
            tree5.Location = new Point(19, 82);
            tree5.Name = "tree5";
            tree5.Size = new Size(30, 30);
            tree5.TabIndex = 1;
            tree5.TabStop = false;
            // 
            // tree4
            // 
            tree4.BackgroundImage = Properties.Resources.tree1;
            tree4.Location = new Point(19, 46);
            tree4.Name = "tree4";
            tree4.Size = new Size(30, 30);
            tree4.TabIndex = 1;
            tree4.TabStop = false;
            // 
            // tree3
            // 
            tree3.BackgroundImage = Properties.Resources.tree1;
            tree3.Location = new Point(420, 118);
            tree3.Name = "tree3";
            tree3.Size = new Size(30, 30);
            tree3.TabIndex = 1;
            tree3.TabStop = false;
            // 
            // tree2
            // 
            tree2.BackgroundImage = Properties.Resources.tree1;
            tree2.Location = new Point(420, 82);
            tree2.Name = "tree2";
            tree2.Size = new Size(30, 30);
            tree2.TabIndex = 1;
            tree2.TabStop = false;
            // 
            // tree1
            // 
            tree1.BackgroundImage = Properties.Resources.tree1;
            tree1.Location = new Point(420, 46);
            tree1.Name = "tree1";
            tree1.Size = new Size(30, 30);
            tree1.TabIndex = 1;
            tree1.TabStop = false;
            // 
            // car4
            // 
            car4.BackColor = Color.Transparent;
            car4.BackgroundImage = Properties.Resources.car2;
            car4.BackgroundImageLayout = ImageLayout.Center;
            car4.Location = new Point(332, 230);
            car4.Name = "car4";
            car4.Size = new Size(52, 110);
            car4.TabIndex = 2;
            car4.TabStop = false;
            // 
            // car3
            // 
            car3.BackColor = Color.Transparent;
            car3.BackgroundImage = Properties.Resources.car2;
            car3.BackgroundImageLayout = ImageLayout.Center;
            car3.Location = new Point(251, 230);
            car3.Name = "car3";
            car3.Size = new Size(52, 110);
            car3.TabIndex = 2;
            car3.TabStop = false;
            // 
            // car2
            // 
            car2.BackColor = Color.Transparent;
            car2.BackgroundImage = Properties.Resources.car2;
            car2.BackgroundImageLayout = ImageLayout.Center;
            car2.Location = new Point(168, 230);
            car2.Name = "car2";
            car2.Size = new Size(52, 110);
            car2.TabIndex = 2;
            car2.TabStop = false;
            // 
            // car1
            // 
            car1.BackColor = Color.Transparent;
            car1.BackgroundImage = Properties.Resources.car2;
            car1.BackgroundImageLayout = ImageLayout.Center;
            car1.Location = new Point(84, 230);
            car1.Name = "car1";
            car1.Size = new Size(52, 110);
            car1.TabIndex = 2;
            car1.TabStop = false;
            // 
            // landpagePanel
            // 
            landpagePanel.BackColor = Color.Transparent;
            landpagePanel.Controls.Add(healthContainer);
            landpagePanel.Controls.Add(steeringContainer);
            landpagePanel.Controls.Add(speedContainer);
            landpagePanel.Controls.Add(landpageLeftArrow);
            landpagePanel.Controls.Add(landpageRightArrow);
            landpagePanel.Controls.Add(landpageScoreTitle);
            landpagePanel.Controls.Add(landpageHighScoreTitle);
            landpagePanel.Controls.Add(landpageScoreValue);
            landpagePanel.Controls.Add(healthTitle);
            landpagePanel.Controls.Add(steeringTitle);
            landpagePanel.Controls.Add(carName);
            landpagePanel.Controls.Add(speedTitle);
            landpagePanel.Controls.Add(repairMsg);
            landpagePanel.Controls.Add(DamageMsg);
            landpagePanel.Controls.Add(landpageDesc);
            landpagePanel.Controls.Add(landpageTitle);
            landpagePanel.Controls.Add(landpageHighScoreValue);
            landpagePanel.Location = new Point(45, 46);
            landpagePanel.Name = "landpagePanel";
            landpagePanel.Size = new Size(384, 592);
            landpagePanel.TabIndex = 1;
            // 
            // healthContainer
            // 
            healthContainer.BackColor = Color.DimGray;
            healthContainer.Controls.Add(healthValue);
            healthContainer.Location = new Point(133, 361);
            healthContainer.Name = "healthContainer";
            healthContainer.Size = new Size(200, 6);
            healthContainer.TabIndex = 5;
            // 
            // healthValue
            // 
            healthValue.BackColor = Color.GreenYellow;
            healthValue.Location = new Point(0, 0);
            healthValue.Name = "healthValue";
            healthValue.Size = new Size(80, 6);
            healthValue.TabIndex = 0;
            // 
            // steeringContainer
            // 
            steeringContainer.BackColor = Color.DimGray;
            steeringContainer.Controls.Add(steeringValue);
            steeringContainer.Location = new Point(133, 329);
            steeringContainer.Name = "steeringContainer";
            steeringContainer.Size = new Size(200, 6);
            steeringContainer.TabIndex = 5;
            // 
            // steeringValue
            // 
            steeringValue.BackColor = Color.GreenYellow;
            steeringValue.Location = new Point(0, 0);
            steeringValue.Name = "steeringValue";
            steeringValue.Size = new Size(160, 6);
            steeringValue.TabIndex = 0;
            // 
            // speedContainer
            // 
            speedContainer.BackColor = Color.DimGray;
            speedContainer.Controls.Add(speedValue);
            speedContainer.Location = new Point(133, 300);
            speedContainer.Name = "speedContainer";
            speedContainer.Size = new Size(200, 6);
            speedContainer.TabIndex = 5;
            // 
            // speedValue
            // 
            speedValue.BackColor = Color.GreenYellow;
            speedValue.Location = new Point(0, 0);
            speedValue.Name = "speedValue";
            speedValue.Size = new Size(120, 6);
            speedValue.TabIndex = 0;
            // 
            // landpageLeftArrow
            // 
            landpageLeftArrow.BackColor = Color.Transparent;
            landpageLeftArrow.BackgroundImage = Properties.Resources.leftArrow;
            landpageLeftArrow.BackgroundImageLayout = ImageLayout.Center;
            landpageLeftArrow.Cursor = Cursors.Hand;
            landpageLeftArrow.Location = new Point(44, 480);
            landpageLeftArrow.Name = "landpageLeftArrow";
            landpageLeftArrow.Size = new Size(48, 48);
            landpageLeftArrow.TabIndex = 4;
            landpageLeftArrow.TabStop = false;
            landpageLeftArrow.Click += landpageLeftArrow_Click;
            // 
            // landpageRightArrow
            // 
            landpageRightArrow.BackColor = Color.Transparent;
            landpageRightArrow.BackgroundImage = Properties.Resources.rightArrow;
            landpageRightArrow.BackgroundImageLayout = ImageLayout.Center;
            landpageRightArrow.Cursor = Cursors.Hand;
            landpageRightArrow.Location = new Point(283, 480);
            landpageRightArrow.Name = "landpageRightArrow";
            landpageRightArrow.Size = new Size(48, 48);
            landpageRightArrow.TabIndex = 3;
            landpageRightArrow.TabStop = false;
            landpageRightArrow.Click += landpageRightArrow_Click;
            // 
            // landpageScoreTitle
            // 
            landpageScoreTitle.AutoSize = true;
            landpageScoreTitle.BackColor = Color.Transparent;
            landpageScoreTitle.Font = new Font("Segoe UI Semilight", 16F, FontStyle.Italic);
            landpageScoreTitle.ForeColor = SystemColors.ActiveCaption;
            landpageScoreTitle.Location = new Point(9, 9);
            landpageScoreTitle.Name = "landpageScoreTitle";
            landpageScoreTitle.Size = new Size(113, 30);
            landpageScoreTitle.TabIndex = 1;
            landpageScoreTitle.Text = "Your Score";
            // 
            // landpageHighScoreTitle
            // 
            landpageHighScoreTitle.AutoSize = true;
            landpageHighScoreTitle.BackColor = Color.Transparent;
            landpageHighScoreTitle.Font = new Font("Segoe UI Semilight", 16F, FontStyle.Italic);
            landpageHighScoreTitle.ForeColor = SystemColors.ActiveCaption;
            landpageHighScoreTitle.Location = new Point(263, 9);
            landpageHighScoreTitle.Name = "landpageHighScoreTitle";
            landpageHighScoreTitle.Size = new Size(113, 30);
            landpageHighScoreTitle.TabIndex = 1;
            landpageHighScoreTitle.Text = "High Score";
            // 
            // landpageScoreValue
            // 
            landpageScoreValue.AutoSize = true;
            landpageScoreValue.BackColor = Color.Transparent;
            landpageScoreValue.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            landpageScoreValue.ForeColor = SystemColors.Control;
            landpageScoreValue.Location = new Point(9, 39);
            landpageScoreValue.Name = "landpageScoreValue";
            landpageScoreValue.Size = new Size(76, 47);
            landpageScoreValue.TabIndex = 1;
            landpageScoreValue.Text = "----";
            // 
            // healthTitle
            // 
            healthTitle.AutoSize = true;
            healthTitle.BackColor = Color.Transparent;
            healthTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            healthTitle.ForeColor = SystemColors.Control;
            healthTitle.Location = new Point(47, 353);
            healthTitle.Name = "healthTitle";
            healthTitle.Size = new Size(59, 21);
            healthTitle.TabIndex = 1;
            healthTitle.Text = "Health";
            // 
            // steeringTitle
            // 
            steeringTitle.AutoSize = true;
            steeringTitle.BackColor = Color.Transparent;
            steeringTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            steeringTitle.ForeColor = SystemColors.Control;
            steeringTitle.Location = new Point(37, 320);
            steeringTitle.Name = "steeringTitle";
            steeringTitle.Size = new Size(69, 21);
            steeringTitle.TabIndex = 1;
            steeringTitle.Text = "Steering";
            // 
            // carName
            // 
            carName.AutoSize = true;
            carName.BackColor = Color.Transparent;
            carName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            carName.ForeColor = SystemColors.Control;
            carName.Location = new Point(164, 571);
            carName.Name = "carName";
            carName.Size = new Size(48, 21);
            carName.TabIndex = 1;
            carName.Text = "Car 1";
            // 
            // speedTitle
            // 
            speedTitle.AutoSize = true;
            speedTitle.BackColor = Color.Transparent;
            speedTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            speedTitle.ForeColor = SystemColors.Control;
            speedTitle.Location = new Point(54, 290);
            speedTitle.Name = "speedTitle";
            speedTitle.Size = new Size(52, 21);
            speedTitle.TabIndex = 1;
            speedTitle.Text = "Speed";
            // 
            // repairMsg
            // 
            repairMsg.AutoSize = true;
            repairMsg.BackColor = Color.Transparent;
            repairMsg.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            repairMsg.ForeColor = Color.DarkKhaki;
            repairMsg.Location = new Point(215, 380);
            repairMsg.Name = "repairMsg";
            repairMsg.Size = new Size(122, 19);
            repairMsg.TabIndex = 1;
            repairMsg.Text = "Repairing in 00:12";
            repairMsg.Visible = false;
            // 
            // DamageMsg
            // 
            DamageMsg.AutoSize = true;
            DamageMsg.BackColor = Color.Transparent;
            DamageMsg.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DamageMsg.ForeColor = Color.IndianRed;
            DamageMsg.Location = new Point(68, 242);
            DamageMsg.Name = "DamageMsg";
            DamageMsg.Size = new Size(246, 25);
            DamageMsg.TabIndex = 1;
            DamageMsg.Text = "Too much damage, Repair!";
            DamageMsg.Visible = false;
            // 
            // landpageDesc
            // 
            landpageDesc.AutoSize = true;
            landpageDesc.BackColor = Color.Transparent;
            landpageDesc.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            landpageDesc.ForeColor = SystemColors.Control;
            landpageDesc.Location = new Point(106, 196);
            landpageDesc.Name = "landpageDesc";
            landpageDesc.Size = new Size(178, 25);
            landpageDesc.TabIndex = 1;
            landpageDesc.Text = "Press space to start";
            // 
            // landpageTitle
            // 
            landpageTitle.AutoSize = true;
            landpageTitle.BackColor = Color.Transparent;
            landpageTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            landpageTitle.ForeColor = Color.Orange;
            landpageTitle.Location = new Point(106, 140);
            landpageTitle.Name = "landpageTitle";
            landpageTitle.Size = new Size(178, 47);
            landpageTitle.TabIndex = 1;
            landpageTitle.Text = "Car Racer";
            // 
            // landpageHighScoreValue
            // 
            landpageHighScoreValue.AutoSize = true;
            landpageHighScoreValue.BackColor = Color.Transparent;
            landpageHighScoreValue.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            landpageHighScoreValue.ForeColor = SystemColors.Control;
            landpageHighScoreValue.Location = new Point(263, 39);
            landpageHighScoreValue.Name = "landpageHighScoreValue";
            landpageHighScoreValue.Size = new Size(76, 47);
            landpageHighScoreValue.TabIndex = 1;
            landpageHighScoreValue.Text = "----";
            // 
            // timer
            // 
            timer.Interval = 15;
            timer.Tick += timer_Tick;
            // 
            // clockTimer
            // 
            clockTimer.Enabled = true;
            clockTimer.Interval = 1000;
            clockTimer.Tick += clockTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 668);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Car Racer";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)myCar).EndInit();
            crashPanel.ResumeLayout(false);
            crashPanel.PerformLayout();
            inGamePanel.ResumeLayout(false);
            inGamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tree6).EndInit();
            ((System.ComponentModel.ISupportInitialize)tree5).EndInit();
            ((System.ComponentModel.ISupportInitialize)tree4).EndInit();
            ((System.ComponentModel.ISupportInitialize)tree3).EndInit();
            ((System.ComponentModel.ISupportInitialize)tree2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tree1).EndInit();
            ((System.ComponentModel.ISupportInitialize)car4).EndInit();
            ((System.ComponentModel.ISupportInitialize)car3).EndInit();
            ((System.ComponentModel.ISupportInitialize)car2).EndInit();
            ((System.ComponentModel.ISupportInitialize)car1).EndInit();
            landpagePanel.ResumeLayout(false);
            landpagePanel.PerformLayout();
            healthContainer.ResumeLayout(false);
            steeringContainer.ResumeLayout(false);
            speedContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)landpageLeftArrow).EndInit();
            ((System.ComponentModel.ISupportInitialize)landpageRightArrow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label landpageTitle;
        private Label landpageDesc;
        private Label landpageScoreValue;
        private Label landpageScoreTitle;
        private Label landpageHighScoreValue;
        private Label landpageHighScoreTitle;
        private PictureBox myCar;
        private System.Windows.Forms.Timer timer;
        private PictureBox landpageRightArrow;
        private PictureBox landpageLeftArrow;
        private Panel landpagePanel;
        private Label speedTitle;
        private Label steeringTitle;
        private Panel speedContainer;
        private Label healthTitle;
        private Panel speedValue;
        private Panel healthContainer;
        private Panel healthValue;
        private Panel steeringContainer;
        private Panel steeringValue;
        private Label carName;
        private Panel inGamePanel;
        private Label inGameScore;
        private Label inGameTime;
        private Label inGameEscape;
        private System.Windows.Forms.Timer clockTimer;
        private Label DamageMsg;
        private Label repairMsg;
        private PictureBox tree1;
        private PictureBox tree2;
        private PictureBox tree6;
        private PictureBox tree5;
        private PictureBox tree4;
        private PictureBox tree3;
        private PictureBox car4;
        private PictureBox car3;
        private PictureBox car2;
        private PictureBox car1;
        private Label crashPanelLabel;
        private Label crashPanelDesc;
        private Panel crashPanel;
    }
}
