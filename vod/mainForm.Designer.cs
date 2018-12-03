namespace vod
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchByPinyin = new System.Windows.Forms.Button();
            this.searchByRank = new System.Windows.Forms.Button();
            this.searchByLanguage = new System.Windows.Forms.Button();
            this.searchBySinger = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 618);
            this.splitContainer1.SplitterDistance = 720;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchByPinyin);
            this.groupBox1.Controls.Add(this.searchByRank);
            this.groupBox1.Controls.Add(this.searchByLanguage);
            this.groupBox1.Controls.Add(this.searchBySinger);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(123, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索歌曲";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // searchByPinyin
            // 
            this.searchByPinyin.Location = new System.Drawing.Point(203, 188);
            this.searchByPinyin.Name = "searchByPinyin";
            this.searchByPinyin.Size = new System.Drawing.Size(127, 107);
            this.searchByPinyin.TabIndex = 11;
            this.searchByPinyin.Text = "中文/\r\n模糊拼音";
            this.searchByPinyin.UseVisualStyleBackColor = true;
            // 
            // searchByRank
            // 
            this.searchByRank.Location = new System.Drawing.Point(34, 188);
            this.searchByRank.Name = "searchByRank";
            this.searchByRank.Size = new System.Drawing.Size(127, 107);
            this.searchByRank.TabIndex = 10;
            this.searchByRank.Text = "排行";
            this.searchByRank.UseVisualStyleBackColor = true;
            // 
            // searchByLanguage
            // 
            this.searchByLanguage.Location = new System.Drawing.Point(203, 37);
            this.searchByLanguage.Name = "searchByLanguage";
            this.searchByLanguage.Size = new System.Drawing.Size(127, 107);
            this.searchByLanguage.TabIndex = 9;
            this.searchByLanguage.Text = "语言";
            this.searchByLanguage.UseVisualStyleBackColor = true;
            // 
            // searchBySinger
            // 
            this.searchBySinger.Location = new System.Drawing.Point(34, 37);
            this.searchBySinger.Name = "searchBySinger";
            this.searchBySinger.Size = new System.Drawing.Size(127, 107);
            this.searchBySinger.TabIndex = 8;
            this.searchBySinger.Text = "歌手";
            this.searchBySinger.UseVisualStyleBackColor = true;
            this.searchBySinger.Click += new System.EventHandler(this.searchBySinger_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(21, 62);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(161, 46);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchByPinyin;
        private System.Windows.Forms.Button searchByRank;
        private System.Windows.Forms.Button searchByLanguage;
        private System.Windows.Forms.Button searchBySinger;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}