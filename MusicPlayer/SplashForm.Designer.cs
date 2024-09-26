namespace MusicPlayer
{
    partial class SplashForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxLoadingImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLoadingImage
            // 
            this.pictureBoxLoadingImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLoadingImage.Image = global::MusicPlayer.Properties.Resources.cargando;
            this.pictureBoxLoadingImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLoadingImage.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLoadingImage.Name = "pictureBoxLoadingImage";
            this.pictureBoxLoadingImage.Size = new System.Drawing.Size(533, 411);
            this.pictureBoxLoadingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoadingImage.TabIndex = 0;
            this.pictureBoxLoadingImage.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 411);
            this.Controls.Add(this.pictureBoxLoadingImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLoadingImage;
        private System.Windows.Forms.Timer timer1;
    }
}

