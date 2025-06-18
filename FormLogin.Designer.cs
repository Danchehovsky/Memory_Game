namespace DIPLOM
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelAccMade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ControlMenu = new System.Windows.Forms.Panel();
            this.pictureBoxLeader = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.pictureBoxX = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFrame = new System.Windows.Forms.PictureBox();
            this.ControlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BackgroundImage = global::DIPLOM.Properties.Resources.button;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(223, 512);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(522, 99);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "УВІЙТИ";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLogin_MouseDown);
            this.buttonLogin.MouseEnter += new System.EventHandler(this.buttonLogin_MouseEnter);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.buttonLogin_MouseLeave);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Comic Sans MS", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(194, 356);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(624, 73);
            this.textBoxPass.TabIndex = 7;
            this.textBoxPass.Enter += new System.EventHandler(this.textBoxPass_Enter);
            this.textBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPass_KeyPress);
            this.textBoxPass.Leave += new System.EventHandler(this.textBoxPass_Leave);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Comic Sans MS", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(194, 198);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(624, 73);
            this.textBoxLogin.TabIndex = 6;
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(216, 709);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ще не маєте аккаунта? Створіть зараз";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Comic Sans MS", 26.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelLogin.Location = new System.Drawing.Point(45, 10);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(495, 86);
            this.labelLogin.TabIndex = 18;
            this.labelLogin.Text = "АВТОРИЗАЦІЯ";
            this.labelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLogin_MouseDown);
            this.labelLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelLogin_MouseMove);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Comic Sans MS", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelError.Location = new System.Drawing.Point(275, 121);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(455, 48);
            this.labelError.TabIndex = 19;
            this.labelError.Text = "Помилка при авторизації";
            this.labelError.Visible = false;
            // 
            // labelAccMade
            // 
            this.labelAccMade.AutoSize = true;
            this.labelAccMade.BackColor = System.Drawing.Color.Transparent;
            this.labelAccMade.Font = new System.Drawing.Font("Comic Sans MS", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAccMade.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelAccMade.Location = new System.Drawing.Point(293, 121);
            this.labelAccMade.Name = "labelAccMade";
            this.labelAccMade.Size = new System.Drawing.Size(461, 48);
            this.labelAccMade.TabIndex = 20;
            this.labelAccMade.Text = "Аккаунт створено успішно";
            this.labelAccMade.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(187, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 38);
            this.label2.TabIndex = 26;
            this.label2.Text = "Введіть логін";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(187, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 38);
            this.label3.TabIndex = 27;
            this.label3.Text = "Введіть пароль";
            this.label3.Visible = false;
            // 
            // ControlMenu
            // 
            this.ControlMenu.BackColor = System.Drawing.Color.Transparent;
            this.ControlMenu.Controls.Add(this.pictureBoxLeader);
            this.ControlMenu.Controls.Add(this.pictureBoxHome);
            this.ControlMenu.Controls.Add(this.pictureBoxX);
            this.ControlMenu.Location = new System.Drawing.Point(659, 24);
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(258, 72);
            this.ControlMenu.TabIndex = 29;
            // 
            // pictureBoxLeader
            // 
            this.pictureBoxLeader.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLeader.Image = global::DIPLOM.Properties.Resources.leaderboard;
            this.pictureBoxLeader.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLeader.Name = "pictureBoxLeader";
            this.pictureBoxLeader.Size = new System.Drawing.Size(72, 72);
            this.pictureBoxLeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeader.TabIndex = 11;
            this.pictureBoxLeader.TabStop = false;
            this.pictureBoxLeader.Click += new System.EventHandler(this.pictureBoxLeader_Click);
            this.pictureBoxLeader.MouseEnter += new System.EventHandler(this.pictureBoxLeader_MouseEnter);
            this.pictureBoxLeader.MouseLeave += new System.EventHandler(this.pictureBoxLeader_MouseLeave);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHome.Image = global::DIPLOM.Properties.Resources.home;
            this.pictureBoxHome.Location = new System.Drawing.Point(78, 0);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(72, 72);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 28;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            this.pictureBoxHome.MouseEnter += new System.EventHandler(this.pictureBoxHome_MouseEnter);
            this.pictureBoxHome.MouseLeave += new System.EventHandler(this.pictureBoxHome_MouseLeave);
            // 
            // pictureBoxX
            // 
            this.pictureBoxX.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxX.Image = global::DIPLOM.Properties.Resources.X;
            this.pictureBoxX.Location = new System.Drawing.Point(156, 0);
            this.pictureBoxX.Name = "pictureBoxX";
            this.pictureBoxX.Size = new System.Drawing.Size(72, 72);
            this.pictureBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxX.TabIndex = 5;
            this.pictureBoxX.TabStop = false;
            this.pictureBoxX.Click += new System.EventHandler(this.pictureBoxX_Click);
            this.pictureBoxX.MouseEnter += new System.EventHandler(this.pictureBoxX_MouseEnter);
            this.pictureBoxX.MouseLeave += new System.EventHandler(this.pictureBoxX_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::DIPLOM.Properties.Resources.pass;
            this.pictureBox2.Location = new System.Drawing.Point(51, 338);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::DIPLOM.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(51, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxFrame
            // 
            this.pictureBoxFrame.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFrame.BackgroundImage = global::DIPLOM.Properties.Resources.woodframe;
            this.pictureBoxFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxFrame.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFrame.Name = "pictureBoxFrame";
            this.pictureBoxFrame.Size = new System.Drawing.Size(940, 118);
            this.pictureBoxFrame.TabIndex = 17;
            this.pictureBoxFrame.TabStop = false;
            this.pictureBoxFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFrame_MouseDown);
            this.pictureBoxFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFrame_MouseMove);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DIPLOM.Properties.Resources.woodback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 770);
            this.Controls.Add(this.ControlMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.pictureBoxFrame);
            this.Controls.Add(this.labelAccMade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormLogin";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseMove);
            this.ControlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxX;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLeader;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureBoxFrame;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelAccMade;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Panel ControlMenu;
    }
}