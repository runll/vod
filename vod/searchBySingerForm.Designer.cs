﻿namespace vod
{
    partial class searchBySingerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchBySingerForm));
            this.returnToMain = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnToMain
            // 
            resources.ApplyResources(this.returnToMain, "returnToMain");
            this.returnToMain.Name = "returnToMain";
            this.returnToMain.UseVisualStyleBackColor = true;
            this.returnToMain.Click += new System.EventHandler(this.returnToMain_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Items.AddRange(new object[] {
            resources.GetString("listBox1.Items")});
            this.listBox1.Name = "listBox1";
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // myAddButton
            // 
            resources.ApplyResources(this.myAddButton, "myAddButton");
            this.myAddButton.Name = "myAddButton";
            this.myAddButton.UseVisualStyleBackColor = true;
            // 
            // searchBySingerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.myAddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.returnToMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchBySingerForm";
            this.Load += new System.EventHandler(this.searchBySingerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button returnToMain;
        private myTabPage myTabPage1;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button myAddButton;
    }
}