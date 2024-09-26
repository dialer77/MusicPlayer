namespace MusicPlayer
{
    partial class MainForm
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.metroButtonRecentList = new MetroFramework.Controls.MetroButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucMusicPlayer1 = new MusicPlayer.UCMusicPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.metroButton3, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.metroButton2, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.metroButton1, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.metroButtonRecentList, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanelMain, 2);
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(194, 310);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // metroButtonRecentList
            // 
            this.metroButtonRecentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButtonRecentList.Location = new System.Drawing.Point(3, 3);
            this.metroButtonRecentList.Name = "metroButtonRecentList";
            this.metroButtonRecentList.Size = new System.Drawing.Size(188, 71);
            this.metroButtonRecentList.TabIndex = 0;
            this.metroButtonRecentList.Text = "최신곡 리스트";
            this.metroButtonRecentList.Click += new System.EventHandler(this.metroButtonRecentList_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(203, 3);
            this.listBox1.Name = "listBox1";
            this.tableLayoutPanel1.SetRowSpan(this.listBox1, 2);
            this.listBox1.Size = new System.Drawing.Size(224, 310);
            this.listBox1.TabIndex = 1;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton1.Location = new System.Drawing.Point(3, 80);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(188, 71);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "내 플레이 리스트";
            this.metroButton1.Click += new System.EventHandler(this.metroButtonRecentList_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton2.Location = new System.Drawing.Point(3, 157);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(188, 71);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "이전 플레이 리스트";
            this.metroButton2.Click += new System.EventHandler(this.metroButtonRecentList_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroButton3.Location = new System.Drawing.Point(3, 234);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(188, 73);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "가장 인기 있는 노래 TOP 100";
            this.metroButton3.Click += new System.EventHandler(this.metroButtonRecentList_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucMusicPlayer1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 316);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ucMusicPlayer1
            // 
            this.ucMusicPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMusicPlayer1.Location = new System.Drawing.Point(433, 33);
            this.ucMusicPlayer1.Name = "ucMusicPlayer1";
            this.ucMusicPlayer1.Size = new System.Drawing.Size(225, 280);
            this.ucMusicPlayer1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(433, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 396);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private MetroFramework.Controls.MetroButton metroButtonRecentList;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UCMusicPlayer ucMusicPlayer1;
        private System.Windows.Forms.Button button1;
    }
}