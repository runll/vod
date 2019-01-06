namespace vod
{
    partial class searchByRankForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.myAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("华文琥珀", 9.5F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            " "});
            this.listBox1.Location = new System.Drawing.Point(714, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 459);
            this.listBox1.TabIndex = 6;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // myAddButton
            // 
            this.myAddButton.Font = new System.Drawing.Font("华文琥珀", 9.5F);
            this.myAddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myAddButton.Location = new System.Drawing.Point(714, 469);
            this.myAddButton.Name = "myAddButton";
            this.myAddButton.Size = new System.Drawing.Size(208, 31);
            this.myAddButton.TabIndex = 8;
            this.myAddButton.Text = "添加到播放列表";
            this.myAddButton.UseVisualStyleBackColor = true;
            this.myAddButton.Click += new System.EventHandler(this.myAddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文琥珀", 11.5F);
            this.label1.Location = new System.Drawing.Point(774, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "近期热榜";
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox27.Image = global::vod.Properties.Resources.close;
            this.pictureBox27.Location = new System.Drawing.Point(956, 7);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(32, 34);
            this.pictureBox27.TabIndex = 38;
            this.pictureBox27.TabStop = false;
            this.pictureBox27.Click += new System.EventHandler(this.pictureBox27_Click);
            // 
            // searchByRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vod.Properties.Resources.simple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myAddButton);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchByRankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchByRankForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Button myAddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox27;
    }
}