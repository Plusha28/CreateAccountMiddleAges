
namespace CreateAccountMiddleAges
{
    partial class DownloadWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadWindow));
            this.labelAlert = new System.Windows.Forms.Label();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureDownloadGif = new System.Windows.Forms.PictureBox();
            this.pictureSuccess = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDownloadGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelAlert.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAlert.Location = new System.Drawing.Point(225, 73);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(431, 25);
            this.labelAlert.TabIndex = 0;
            this.labelAlert.Text = "У Вас отсутствуют файлы с настройками.";
            // 
            // downloadBtn
            // 
            this.downloadBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.downloadBtn.FlatAppearance.BorderSize = 2;
            this.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadBtn.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downloadBtn.Location = new System.Drawing.Point(375, 158);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(146, 75);
            this.downloadBtn.TabIndex = 1;
            this.downloadBtn.Text = "Скачать";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureDownloadGif
            // 
            this.pictureDownloadGif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureDownloadGif.Image = ((System.Drawing.Image)(resources.GetObject("pictureDownloadGif.Image")));
            this.pictureDownloadGif.Location = new System.Drawing.Point(416, 143);
            this.pictureDownloadGif.Name = "pictureDownloadGif";
            this.pictureDownloadGif.Size = new System.Drawing.Size(52, 55);
            this.pictureDownloadGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDownloadGif.TabIndex = 2;
            this.pictureDownloadGif.TabStop = false;
            this.pictureDownloadGif.Visible = false;
            // 
            // pictureSuccess
            // 
            this.pictureSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pictureSuccess.Image = ((System.Drawing.Image)(resources.GetObject("pictureSuccess.Image")));
            this.pictureSuccess.Location = new System.Drawing.Point(416, 204);
            this.pictureSuccess.Name = "pictureSuccess";
            this.pictureSuccess.Size = new System.Drawing.Size(50, 47);
            this.pictureSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSuccess.TabIndex = 3;
            this.pictureSuccess.TabStop = false;
            this.pictureSuccess.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(339, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Файлы загружены!";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(266, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Закройте это окно и попробуйте";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(312, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "создать аккаунт снова.";
            this.label3.Visible = false;
            // 
            // DownloadWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureSuccess);
            this.Controls.Add(this.pictureDownloadGif);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.labelAlert);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 350);
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Name = "DownloadWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загрузка файлов настроек";
            ((System.ComponentModel.ISupportInitialize)(this.pictureDownloadGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSuccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlert;
        private System.Windows.Forms.Button downloadBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureDownloadGif;
        private System.Windows.Forms.PictureBox pictureSuccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}