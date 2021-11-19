
namespace CreateAccountMiddleAges
{
    partial class MainRegisterWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRegisterWindow));
            this.pictureVK = new System.Windows.Forms.PictureBox();
            this.pictureDiscord = new System.Windows.Forms.PictureBox();
            this.CreateAccountBtn = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxYouTube = new System.Windows.Forms.PictureBox();
            this.pictureBoxOffPage = new System.Windows.Forms.PictureBox();
            this.CreateSuccessGif = new System.Windows.Forms.PictureBox();
            this.CreateSuccess = new System.Windows.Forms.Label();
            this.backgroundDownloadData = new System.ComponentModel.BackgroundWorker();
            this.backgroundDataRecording = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYouTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOffPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateSuccessGif)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureVK
            // 
            this.pictureVK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pictureVK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureVK.Image = ((System.Drawing.Image)(resources.GetObject("pictureVK.Image")));
            this.pictureVK.Location = new System.Drawing.Point(29, 313);
            this.pictureVK.MinimumSize = new System.Drawing.Size(55, 55);
            this.pictureVK.Name = "pictureVK";
            this.pictureVK.Size = new System.Drawing.Size(55, 55);
            this.pictureVK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVK.TabIndex = 0;
            this.pictureVK.TabStop = false;
            this.pictureVK.Click += new System.EventHandler(this.pictureVK_Click);
            // 
            // pictureDiscord
            // 
            this.pictureDiscord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureDiscord.Image = ((System.Drawing.Image)(resources.GetObject("pictureDiscord.Image")));
            this.pictureDiscord.Location = new System.Drawing.Point(109, 316);
            this.pictureDiscord.MinimumSize = new System.Drawing.Size(48, 48);
            this.pictureDiscord.Name = "pictureDiscord";
            this.pictureDiscord.Size = new System.Drawing.Size(48, 48);
            this.pictureDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDiscord.TabIndex = 1;
            this.pictureDiscord.TabStop = false;
            this.pictureDiscord.Click += new System.EventHandler(this.pictureDiscord_Click);
            // 
            // CreateAccountBtn
            // 
            this.CreateAccountBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.CreateAccountBtn.FlatAppearance.BorderSize = 2;
            this.CreateAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateAccountBtn.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateAccountBtn.Location = new System.Drawing.Point(358, 262);
            this.CreateAccountBtn.Name = "CreateAccountBtn";
            this.CreateAccountBtn.Size = new System.Drawing.Size(209, 87);
            this.CreateAccountBtn.TabIndex = 2;
            this.CreateAccountBtn.Text = "Создать аккаунт";
            this.CreateAccountBtn.UseVisualStyleBackColor = true;
            this.CreateAccountBtn.Click += new System.EventHandler(this.CreateAccount_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelLogin.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLogin.Location = new System.Drawing.Point(250, 74);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(162, 25);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Введите логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelPassword.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPassword.Location = new System.Drawing.Point(250, 155);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(175, 25);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Введите пароль";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(255, 102);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(419, 30);
            this.login.TabIndex = 5;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(255, 183);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(419, 30);
            this.password.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(15, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Связаться с нами:";
            // 
            // pictureBoxYouTube
            // 
            this.pictureBoxYouTube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pictureBoxYouTube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxYouTube.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxYouTube.Image")));
            this.pictureBoxYouTube.Location = new System.Drawing.Point(100, 143);
            this.pictureBoxYouTube.Name = "pictureBoxYouTube";
            this.pictureBoxYouTube.Size = new System.Drawing.Size(96, 98);
            this.pictureBoxYouTube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxYouTube.TabIndex = 8;
            this.pictureBoxYouTube.TabStop = false;
            this.pictureBoxYouTube.Click += new System.EventHandler(this.pictureBoxYouTube_Click);
            // 
            // pictureBoxOffPage
            // 
            this.pictureBoxOffPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pictureBoxOffPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOffPage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOffPage.Image")));
            this.pictureBoxOffPage.Location = new System.Drawing.Point(-1, 143);
            this.pictureBoxOffPage.Name = "pictureBoxOffPage";
            this.pictureBoxOffPage.Size = new System.Drawing.Size(95, 98);
            this.pictureBoxOffPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOffPage.TabIndex = 9;
            this.pictureBoxOffPage.TabStop = false;
            this.pictureBoxOffPage.Click += new System.EventHandler(this.pictureBoxOffPage_Click);
            // 
            // CreateSuccessGif
            // 
            this.CreateSuccessGif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CreateSuccessGif.Image = ((System.Drawing.Image)(resources.GetObject("CreateSuccessGif.Image")));
            this.CreateSuccessGif.Location = new System.Drawing.Point(626, 163);
            this.CreateSuccessGif.Name = "CreateSuccessGif";
            this.CreateSuccessGif.Size = new System.Drawing.Size(65, 50);
            this.CreateSuccessGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CreateSuccessGif.TabIndex = 10;
            this.CreateSuccessGif.TabStop = false;
            this.CreateSuccessGif.Visible = false;
            // 
            // CreateSuccess
            // 
            this.CreateSuccess.AutoSize = true;
            this.CreateSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CreateSuccess.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateSuccess.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateSuccess.Location = new System.Drawing.Point(245, 178);
            this.CreateSuccess.Name = "CreateSuccess";
            this.CreateSuccess.Size = new System.Drawing.Size(0, 32);
            this.CreateSuccess.TabIndex = 11;
            this.CreateSuccess.Visible = false;
            // 
            // MainRegisterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.CreateSuccess);
            this.Controls.Add(this.CreateSuccessGif);
            this.Controls.Add(this.pictureBoxOffPage);
            this.Controls.Add(this.pictureBoxYouTube);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.CreateAccountBtn);
            this.Controls.Add(this.pictureDiscord);
            this.Controls.Add(this.pictureVK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 450);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "MainRegisterWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать аккаунт";
            ((System.ComponentModel.ISupportInitialize)(this.pictureVK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDiscord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYouTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOffPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateSuccessGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureVK;
        private System.Windows.Forms.PictureBox pictureDiscord;
        private System.Windows.Forms.Button CreateAccountBtn;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxYouTube;
        private System.Windows.Forms.PictureBox pictureBoxOffPage;
        private System.Windows.Forms.PictureBox CreateSuccessGif;
        private System.Windows.Forms.Label CreateSuccess;
        private System.ComponentModel.BackgroundWorker backgroundDownloadData;
        private System.ComponentModel.BackgroundWorker backgroundDataRecording;
    }
}

