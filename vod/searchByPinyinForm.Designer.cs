namespace vod
{
    partial class searchByPinyinForm
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
            this.singerInput = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enterTip = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // singerInput
            // 
            this.singerInput.Location = new System.Drawing.Point(16, 34);
            this.singerInput.Name = "singerInput";
            this.singerInput.Size = new System.Drawing.Size(100, 21);
            this.singerInput.TabIndex = 3;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(125, 32);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(44, 23);
            this.search.TabIndex = 2;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.enterTip);
            this.panel1.Controls.Add(this.singerInput);
            this.panel1.Controls.Add(this.search);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 4;
            // 
            // enterTip
            // 
            this.enterTip.AutoSize = true;
            this.enterTip.Location = new System.Drawing.Point(14, 10);
            this.enterTip.Name = "enterTip";
            this.enterTip.Size = new System.Drawing.Size(89, 12);
            this.enterTip.TabIndex = 4;
            this.enterTip.Text = "please enter :";
            // 
            // searchByPinyinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 618);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchByPinyinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "searchByPinyinForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox singerInput;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label enterTip;
    }
}