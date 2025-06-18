namespace DIPLOM
{
    partial class FormSimon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimon));
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.timerWait = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelBack = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxX = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeader = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerStart
            // 
            this.timerStart.Interval = 700;
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // timerWait
            // 
            this.timerWait.Interval = 700;
            this.timerWait.Tick += new System.EventHandler(this.timerWait_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(131, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.BackColor = System.Drawing.Color.Transparent;
            this.labelWin.Font = new System.Drawing.Font("Comic Sans MS", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWin.Location = new System.Drawing.Point(181, 24);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(0, 51);
            this.labelWin.TabIndex = 11;
            this.labelWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.BackgroundImage = global::DIPLOM.Properties.Resources.button;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Comic Sans MS", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(170, 837);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(600, 111);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Почати";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            this.buttonStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseDown);
            this.buttonStart.MouseEnter += new System.EventHandler(this.buttonStart_MouseEnter);
            this.buttonStart.MouseLeave += new System.EventHandler(this.buttonStart_MouseLeave);
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.Transparent;
            this.panelBack.BackgroundImage = global::DIPLOM.Properties.Resources.woodframe;
            this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBack.Controls.Add(this.pictureBox1);
            this.panelBack.Controls.Add(this.pictureBox4);
            this.panelBack.Controls.Add(this.pictureBox2);
            this.panelBack.Controls.Add(this.pictureBox3);
            this.panelBack.Location = new System.Drawing.Point(139, 159);
            this.panelBack.Margin = new System.Windows.Forms.Padding(0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(666, 666);
            this.panelBack.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::DIPLOM.Properties.Resources.circlegreen;
            this.pictureBox1.Location = new System.Drawing.Point(31, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "0";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = global::DIPLOM.Properties.Resources.circleblue;
            this.pictureBox4.Location = new System.Drawing.Point(336, 335);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(295, 295);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "3";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::DIPLOM.Properties.Resources.circlered;
            this.pictureBox2.Location = new System.Drawing.Point(336, 29);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(295, 295);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "1";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::DIPLOM.Properties.Resources.circleyellow;
            this.pictureBox3.Location = new System.Drawing.Point(31, 335);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(295, 295);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "2";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBoxX);
            this.panel1.Controls.Add(this.pictureBoxHome);
            this.panel1.Controls.Add(this.pictureBoxLeader);
            this.panel1.Controls.Add(this.pictureBoxUser);
            this.panel1.Location = new System.Drawing.Point(587, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 72);
            this.panel1.TabIndex = 33;
            // 
            // pictureBoxX
            // 
            this.pictureBoxX.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxX.BackgroundImage = global::DIPLOM.Properties.Resources.wood2;
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
            this.pictureBoxHome.BackgroundImage = global::DIPLOM.Properties.Resources.wood2;
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
            // pictureBoxLeader
            // 
            this.pictureBoxLeader.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLeader.BackgroundImage = global::DIPLOM.Properties.Resources.wood2;
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
            this.pictureBoxUser.BackgroundImage = global::DIPLOM.Properties.Resources.wood2;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SandyBrown;
            this.label5.Location = new System.Drawing.Point(13, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 39);
            this.label5.TabIndex = 44;
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
            this.labelPoints.TabIndex = 43;
            this.labelPoints.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 39);
            this.label2.TabIndex = 45;
            this.label2.Text = "Рівень:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::DIPLOM.Properties.Resources.woodframe;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.labelPoints);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(170, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 178);
            this.panel5.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::DIPLOM.Properties.Resources.woodframe;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(525, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 178);
            this.panel2.TabIndex = 50;
            // 
            // FormSimon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DIPLOM.Properties.Resources.woodback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 960);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSimon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormSimon";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormSimon_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormSimon_MouseMove);
            this.panelBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerWait;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxX;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.PictureBox pictureBoxLeader;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
    }
}