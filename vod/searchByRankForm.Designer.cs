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
            this.returnToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            " "});
            this.listBox1.Location = new System.Drawing.Point(736, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 424);
            this.listBox1.TabIndex = 6;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // myAddButton
            // 
            this.myAddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myAddButton.Location = new System.Drawing.Point(736, 460);
            this.myAddButton.Name = "myAddButton";
            this.myAddButton.Size = new System.Drawing.Size(208, 29);
            this.myAddButton.TabIndex = 8;
            this.myAddButton.Text = "添加到播放列表";
            this.myAddButton.UseVisualStyleBackColor = true;
            this.myAddButton.Click += new System.EventHandler(this.myAddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(734, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "近期热榜";
            // 
            // returnToMain
            // 
            this.returnToMain.BackColor = System.Drawing.Color.Transparent;
            this.returnToMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.returnToMain.Location = new System.Drawing.Point(603, 52);
            this.returnToMain.Name = "returnToMain";
            this.returnToMain.Size = new System.Drawing.Size(86, 28);
            this.returnToMain.TabIndex = 10;
            this.returnToMain.Text = "return";
            this.returnToMain.UseVisualStyleBackColor = false;
            this.returnToMain.Click += new System.EventHandler(this.returnToMain_Click);
            // 
            // searchByRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vod.Properties.Resources.boom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.Controls.Add(this.returnToMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myAddButton);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchByRankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchByRankForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Button myAddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnToMain;
    }
}