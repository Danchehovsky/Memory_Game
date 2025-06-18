namespace DIPLOM
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.labelRules1 = new System.Windows.Forms.Label();
            this.labelRules3 = new System.Windows.Forms.Label();
            this.labelRules2 = new System.Windows.Forms.Label();
            this.ControlMenu = new System.Windows.Forms.Panel();
            this.pictureBoxX = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeader = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxFrame = new System.Windows.Forms.PictureBox();
            this.ControlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.BackgroundImage = global::DIPLOM.Properties.Resources.button;
            this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Comic Sans MS", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(194, 559);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(614, 117);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "ЗАРЕЄСТРУВАТИСЬ";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            this.buttonRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRegister_MouseDown);
            this.buttonRegister.MouseEnter += new System.EventHandler(this.buttonRegister_MouseEnter);
            this.buttonRegister.MouseLeave += new System.EventHandler(this.buttonRegister_MouseLeave);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Comic Sans MS", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(194, 415);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(624, 79);
            this.textBoxPass.TabIndex = 6;
            this.textBoxPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPass_MouseClick);
            this.textBoxPass.Enter += new System.EventHandler(this.textBoxPass_Enter);
            this.textBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPass_KeyPress);
            this.textBoxPass.Leave += new System.EventHandler(this.textBoxPass_Leave);
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Font = new System.Drawing.Font("Comic Sans MS", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNickname.Location = new System.Drawing.Point(194, 144);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(624, 79);
            this.textBoxNickname.TabIndex = 8;
            this.textBoxNickname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxNickname_MouseClick);
            this.textBoxNickname.Enter += new System.EventHandler(this.textBoxNickname_Enter);
            this.textBoxNickname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNickname_KeyPress);
            this.textBoxNickname.Leave += new System.EventHandler(this.textBoxNickname_Leave);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Comic Sans MS", 21.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(194, 278);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(624, 79);
            this.textBoxLogin.TabIndex = 5;
            this.textBoxLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxLogin_MouseClick);
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLogin_KeyPress);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(189, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введіть нікнейм";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(189, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введіть логін";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(189, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введіть пароль";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(140, 679);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(680, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Такий користувач вже зареєстрований, введіть інші дані";
            this.label4.Visible = false;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.BackColor = System.Drawing.Color.Transparent;
            this.labelRegister.Font = new System.Drawing.Font("Comic Sans MS", 26.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRegister.ForeColor = System.Drawing.Color.SandyBrown;
            this.labelRegister.Location = new System.Drawing.Point(50, 10);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(426, 86);
            this.labelRegister.TabIndex = 16;
            this.labelRegister.Text = "РЕЄСТРАЦІЯ";
            this.labelRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelRegister_MouseDown);
            this.labelRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelRegister_MouseMove);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Comic Sans MS", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(286, 679);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(407, 35);
            this.labelError.TabIndex = 17;
            this.labelError.Text = "Помилка при створенні аккаунту";
            this.labelError.Visible = false;
            // 
            // labelRules1
            // 
            this.labelRules1.BackColor = System.Drawing.Color.PapayaWhip;
            this.labelRules1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRules1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelRules1.Font = new System.Drawing.Font("Comic Sans MS", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRules1.ForeColor = System.Drawing.Color.Black;
            this.labelRules1.Location = new System.Drawing.Point(194, 217);
            this.labelRules1.Margin = new System.Windows.Forms.Padding(0);
            this.labelRules1.Name = "labelRules1";
            this.labelRules1.Size = new System.Drawing.Size(624, 122);
            this.labelRules1.TabIndex = 18;
            this.labelRules1.Text = "Нікнейм має бути:\r\n-Довжиною від 5 до 15 символів\r\n-Написаний літерами латинниці " +
    "та/або цифрами\r\n-Не мати спец-символів\r\n";
            this.labelRules1.Visible = false;
            // 
            // labelRules3
            // 
            this.labelRules3.BackColor = System.Drawing.Color.PapayaWhip;
            this.labelRules3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRules3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelRules3.Font = new System.Drawing.Font("Comic Sans MS", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRules3.ForeColor = System.Drawing.Color.Black;
            this.labelRules3.Location = new System.Drawing.Point(194, 491);
            this.labelRules3.Margin = new System.Windows.Forms.Padding(0);
            this.labelRules3.Name = "labelRules3";
            this.labelRules3.Size = new System.Drawing.Size(624, 65);
            this.labelRules3.TabIndex = 19;
            this.labelRules3.Text = "Пароль має бути:\r\n-Довжиною від 5 символів\r\n";
            this.labelRules3.Visible = false;
            // 
            // labelRules2
            // 
            this.labelRules2.BackColor = System.Drawing.Color.PapayaWhip;
            this.labelRules2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRules2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelRules2.Font = new System.Drawing.Font("Comic Sans MS", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRules2.ForeColor = System.Drawing.Color.Black;
            this.labelRules2.Location = new System.Drawing.Point(194, 350);
            this.labelRules2.Margin = new System.Windows.Forms.Padding(0);
            this.labelRules2.Name = "labelRules2";
            this.labelRules2.Size = new System.Drawing.Size(624, 91);
            this.labelRules2.TabIndex = 20;
            this.labelRules2.Text = "Логін має бути:\r\n-Написаний літерами латинницею та/або цифрами\r\n-Не мати спец-сим" +
    "волів окрім нижнього підкреслення \"_\"\r\n";
            this.labelRules2.Visible = false;
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
            this.ControlMenu.Size = new System.Drawing.Size(331, 72);
            this.ControlMenu.TabIndex = 30;
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::DIPLOM.Properties.Resources.pass;
            this.pictureBox2.Location = new System.Drawing.Point(65, 404);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::DIPLOM.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(65, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogin.Image = global::DIPLOM.Properties.Resources.nickname;
            this.pictureBoxLogin.Location = new System.Drawing.Point(65, 131);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogin.TabIndex = 21;
            this.pictureBoxLogin.TabStop = false;
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
            this.pictureBoxFrame.TabIndex = 15;
            this.pictureBoxFrame.TabStop = false;
            this.pictureBoxFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFrame_MouseDown);
            this.pictureBoxFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxFrame_MouseMove);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DIPLOM.Properties.Resources.woodback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 770);
            this.Controls.Add(this.ControlMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.labelRules2);
            this.Controls.Add(this.labelRules3);
            this.Controls.Add(this.labelRules1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNickname);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.pictureBoxFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormRegister";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormRegister_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRegister_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormRegister_MouseMove);
            this.ControlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxX;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxLeader;
        private System.Windows.Forms.PictureBox pictureBoxFrame;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelRules1;
        private System.Windows.Forms.Label labelRules3;
        private System.Windows.Forms.Label labelRules2;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Panel ControlMenu;
    }
}