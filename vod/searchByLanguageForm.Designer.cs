namespace vod
{
    partial class searchByLanguageForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myAddButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("华文琥珀", 15F);
            this.button1.Location = new System.Drawing.Point(144, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 138);
            this.button1.TabIndex = 0;
            this.button1.Text = "国语";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Azure;
            this.button2.Font = new System.Drawing.Font("华文琥珀", 15F);
            this.button2.Location = new System.Drawing.Point(355, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 138);
            this.button2.TabIndex = 1;
            this.button2.Text = "粤语";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.Font = new System.Drawing.Font("华文琥珀", 15F);
            this.button3.Location = new System.Drawing.Point(35, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 138);
            this.button3.TabIndex = 2;
            this.button3.Text = "英语";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Font = new System.Drawing.Font("华文琥珀", 15F);
            this.button4.Location = new System.Drawing.Point(265, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 138);
            this.button4.TabIndex = 3;
            this.button4.Text = "日语";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            " "});
            this.listBox1.Location = new System.Drawing.Point(681, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 459);
            this.listBox1.TabIndex = 5;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(774, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "（null）";
            // 
            // myAddButton
            // 
            this.myAddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myAddButton.Location = new System.Drawing.Point(681, 465);
            this.myAddButton.Name = "myAddButton";
            this.myAddButton.Size = new System.Drawing.Size(243, 31);
            this.myAddButton.TabIndex = 7;
            this.myAddButton.Text = "添加到播放列表";
            this.myAddButton.UseVisualStyleBackColor = true;
            this.myAddButton.Click += new System.EventHandler(this.myAddButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button5.Font = new System.Drawing.Font("华文琥珀", 15F);
            this.button5.Location = new System.Drawing.Point(487, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 138);
            this.button5.TabIndex = 8;
            this.button5.Text = "其他";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::vod.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(956, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 34);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // searchByLanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.myAddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("华文琥珀", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchByLanguageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchByLanguageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button myAddButton;
        public System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}