namespace DIPLOM
{
    partial class FormPairsDif2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPairsDif2));
            this.buttonAgain = new System.Windows.Forms.Button();
            this.labelWin = new System.Windows.Forms.Label();
            this.pictureBoxLeader = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxX = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.timerFlip = new System.Windows.Forms.Timer(this.components);
            this.labelLose = new System.Windows.Forms.Label();
            this.ControlMenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCardsHolder = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.ControlMenu.SuspendLayout();
            this.panelCardsHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAgain
            // 
            this.buttonAgain.BackColor = System.Drawing.Color.Transparent;
            this.buttonAgain.BackgroundImage = global::DIPLOM.Properties.Resources.button;
            this.buttonAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAgain.FlatAppearance.BorderSize = 0;
            this.buttonAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgain.Font = new System.Drawing.Font("Comic Sans MS", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAgain.Location = new System.Drawing.Point(12, 838);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(463, 87);
            this.buttonAgain.TabIndex = 42;
            this.buttonAgain.Text = "Ще раз?";
            this.buttonAgain.UseVisualStyleBackColor = false;
            this.buttonAgain.Visible = false;
            this.buttonAgain.Click += new System.EventHandler(this.buttonAgain_Click);
            this.buttonAgain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonAgain_MouseDown);
            this.buttonAgain.MouseEnter += new System.EventHandler(this.buttonAgain_MouseEnter);
            this.buttonAgain.MouseLeave += new System.EventHandler(this.buttonAgain_MouseLeave);
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.BackColor = System.Drawing.Color.Transparent;
            this.labelWin.Font = new System.Drawing.Font("Comic Sans MS", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWin.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelWin.Location = new System.Drawing.Point(352, 772);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(234, 51);
            this.labelWin.TabIndex = 40;
            this.labelWin.Text = "Ви виграли";
            this.labelWin.Visible = false;
            // 
            // pictureBoxLeader
            // 
            this.pictureBoxLeader.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLeader.Image = global::DIPLOM.Properties.Resources.leaderboard;
            this.pictureBoxLeader.Location = new System.Drawing.Point(78, 0);
            this.pictureBoxLeader.Name = "pictureBoxLeader";
            this.pictureBoxLeader.Size = new System.Drawing.Size(72, 72);
            this.pictureBoxLeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeader.TabIndex = 14;
            this.pictureBoxLeader.TabStop = false;
            this.pictureBoxLeader.Click += new System.EventHandler(this.pictureBoxLeader_Click);
            this.pictureBoxLeader.MouseEnter += new System.EventHandler(this.pictureBoxLeader_MouseEnter);
            this.pictureBoxLeader.MouseLeave += new System.EventHandler(this.pictureBoxLeader_MouseLeave);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUser.Image = global::DIPLOM.Properties.Resources.user;
            this.pictureBoxUser.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(72, 72);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 2;
            this.pictureBoxUser.TabStop = false;
            this.pictureBoxUser.Click += new System.EventHandler(this.pictureBoxUser_Click);
            this.pictureBoxUser.MouseEnter += new System.EventHandler(this.pictureBoxUser_MouseEnter);
            this.pictureBoxUser.MouseLeave += new System.EventHandler(this.pictureBoxUser_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(551, 23);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(381, 23);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(211, 23);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(721, 23);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 150);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(211, 193);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(150, 150);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "";
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(41, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(41, 193);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(150, 150);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "";
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBoxX
            // 
            this.pictureBoxX.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxX.Image = global::DIPLOM.Properties.Resources.X;
            this.pictureBoxX.Location = new System.Drawing.Point(234, 0);
            this.pictureBoxX.Name = "pictureBoxX";
            this.pictureBoxX.Size = new System.Drawing.Size(72, 72);
            this.pictureBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxX.TabIndex = 3;
            this.pictureBoxX.TabStop = false;
            this.pictureBoxX.Click += new System.EventHandler(this.pictureBoxX_Click);
            this.pictureBoxX.MouseEnter += new System.EventHandler(this.pictureBoxX_MouseEnter);
            this.pictureBoxX.MouseLeave += new System.EventHandler(this.pictureBoxX_MouseLeave);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHome.Image = global::DIPLOM.Properties.Resources.home;
            this.pictureBoxHome.Location = new System.Drawing.Point(156, 0);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(72, 72);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 29;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            this.pictureBoxHome.MouseEnter += new System.EventHandler(this.pictureBoxHome_MouseEnter);
            this.pictureBoxHome.MouseLeave += new System.EventHandler(this.pictureBoxHome_MouseLeave);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Location = new System.Drawing.Point(381, 193);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(150, 150);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 4;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // timerFlip
            // 
            this.timerFlip.Interval = 750;
            this.timerFlip.Tick += new System.EventHandler(this.timerFlip_Tick);
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.Transparent;
            this.labelLose.Font = new System.Drawing.Font("Comic Sans MS", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLose.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLose.Location = new System.Drawing.Point(352, 772);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(257, 51);
            this.labelLose.TabIndex = 41;
            this.labelLose.Text = "Ви програли";
            this.labelLose.Visible = false;
            // 
            // ControlMenu
            // 
            this.ControlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlMenu.BackColor = System.Drawing.Color.Transparent;
            this.ControlMenu.Controls.Add(this.pictureBoxX);
            this.ControlMenu.Controls.Add(this.pictureBoxHome);
            this.ControlMenu.Controls.Add(this.pictureBoxLeader);
            this.ControlMenu.Controls.Add(this.pictureBoxUser);
            this.ControlMenu.Location = new System.Drawing.Point(587, 24);
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(338, 72);
            this.ControlMenu.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SandyBrown;
            this.label3.Location = new System.Drawing.Point(18, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 39);
            this.label3.TabIndex = 37;
            this.label3.Text = "Залишилося часу:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(294, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 39);
            this.label1.TabIndex = 35;
            this.label1.Text = "50";
            // 
            // panelCardsHolder
            // 
            this.panelCardsHolder.BackColor = System.Drawing.Color.Transparent;
            this.panelCardsHolder.BackgroundImage = global::DIPLOM.Properties.Resources.woodframe;
            this.panelCardsHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCardsHolder.Controls.Add(this.pictureBox10);
            this.panelCardsHolder.Controls.Add(this.pictureBox9);
            this.panelCardsHolder.Controls.Add(this.pictureBox4);
            this.panelCardsHolder.Controls.Add(this.pictureBox3);
            this.panelCardsHolder.Controls.Add(this.pictureBox2);
            this.panelCardsHolder.Controls.Add(this.pictureBox5);
            this.panelCardsHolder.Controls.Add(this.pictureBox7);
            this.panelCardsHolder.Controls.Add(this.pictureBox1);
            this.panelCardsHolder.Controls.Add(this.pictureBox6);
            this.panelCardsHolder.Controls.Add(this.pictureBox8);
            this.panelCardsHolder.Location = new System.Drawing.Point(12, 294);
            this.panelCardsHolder.Name = "panelCardsHolder";
            this.panelCardsHolder.Size = new System.Drawing.Size(916, 375);
            this.panelCardsHolder.TabIndex = 38;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Location = new System.Drawing.Point(721, 193);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(150, 150);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Location = new System.Drawing.Point(551, 193);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(150, 150);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.BackgroundImage = global::DIPLOM.Properties.Resources.button;
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Comic Sans MS", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(470, 838);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(463, 87);
            this.buttonNext.TabIndex = 43;
            this.buttonNext.Text = "Наступний рівень";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            this.buttonNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonNext_MouseDown);
            this.buttonNext.MouseEnter += new System.EventHandler(this.buttonNext_MouseEnter);
            this.buttonNext.MouseLeave += new System.EventHandler(this.buttonNext_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SandyBrown;
            this.label5.Location = new System.Drawing.Point(13, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 39);
            this.label5.TabIndex = 45;
            this.label5.Text = "Балів:";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.BackColor = System.Drawing.Color.Transparent;
            this.labelPoints.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoints.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelPoints.Location = new System.Drawing.Point(121, 10);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(34, 39);
            this.labelPoints.TabIndex = 44;
            this.labelPoints.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::DIPLOM.Properties.Resources.woodframe;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.labelPoints);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(53, 242);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 178);
            this.panel5.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::DIPLOM.Properties.Resources.woodframe;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(513, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 178);
            this.panel1.TabIndex = 49;
            // 
            // FormPairsDif2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DIPLOM.Properties.Resources.woodback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 960);
            this.ControlBox = false;
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonAgain);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.ControlMenu);
            this.Controls.Add(this.panelCardsHolder);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPairsDif2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormPairsDif2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPairsDif2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPairsDif2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ControlMenu.ResumeLayout(false);
            this.panelCardsHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgain;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.PictureBox pictureBoxLeader;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBoxX;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.Timer timerFlip;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Panel ControlMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCardsHolder;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
    }
}