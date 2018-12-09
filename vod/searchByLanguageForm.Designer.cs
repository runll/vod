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
            this.returnToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 127);
            this.button1.TabIndex = 0;
            this.button1.Text = "国语";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 127);
            this.button2.TabIndex = 1;
            this.button2.Text = "粤语";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(110, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 127);
            this.button3.TabIndex = 2;
            this.button3.Text = "英语";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(304, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 127);
            this.button4.TabIndex = 3;
            this.button4.Text = "日语";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            " "});
            this.listBox1.Location = new System.Drawing.Point(735, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 424);
            this.listBox1.TabIndex = 5;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(811, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "（null）";
            // 
            // myAddButton
            // 
            this.myAddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myAddButton.Location = new System.Drawing.Point(735, 456);
            this.myAddButton.Name = "myAddButton";
            this.myAddButton.Size = new System.Drawing.Size(208, 29);
            this.myAddButton.TabIndex = 7;
            this.myAddButton.Text = "添加到播放列表";
            this.myAddButton.UseVisualStyleBackColor = true;
            this.myAddButton.Click += new System.EventHandler(this.myAddButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(500, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 127);
            this.button5.TabIndex = 8;
            this.button5.Text = "其他";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // returnToMain
            // 
            this.returnToMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.returnToMain.Location = new System.Drawing.Point(627, 40);
            this.returnToMain.Name = "returnToMain";
            this.returnToMain.Size = new System.Drawing.Size(86, 28);
            this.returnToMain.TabIndex = 9;
            this.returnToMain.Text = "return";
            this.returnToMain.UseVisualStyleBackColor = true;
            this.returnToMain.Click += new System.EventHandler(this.returnToMain_Click);
            // 
            // searchByLanguageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.ControlBox = false;
            this.Controls.Add(this.returnToMain);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.myAddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchByLanguageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchByLanguageForm";
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
        private System.Windows.Forms.Button returnToMain;
    }
}