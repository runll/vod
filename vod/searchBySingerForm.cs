﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace vod
{
    public partial class searchBySingerForm : Form
    {
        
        public mainForm previous { get; internal set; }
        //List<string> res = new imagePathList().res;
        public List<mySong> clickRes = new List<mySong>();
        public List<mySong> res = new List<mySong>();
        public int lbIndex = 0;

        public searchBySingerForm()
        {
            InitializeComponent();


            List<string> picPath = new imagePathList().res;
            myTabPage mtp = new myTabPage();
            mtp.Show();
            //new myTabPage().Show();

        }



        private TabControl addPage(TabControl tc) {
            return new TabControl();
        }
        
        private void searchBySingerForm_Load(object sender, EventArgs e)
        {
           
        }

        private void returnToMain_Click(object sender, EventArgs e)
        {
 

        }

  

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void myTabPage1_Load(object sender, EventArgs e)
        {
            //this.myTabPage1.tabControl1.TabPages.
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.X, e.Y);
            listBox1.SelectedIndex = index;
            if (listBox1.SelectedIndex != -1)
            {
                //MessageBox.Show(listBox1.SelectedItem.ToString());
                lbIndex = listBox1.SelectedIndex;
            }
        }
        
        private void myAddButton_Click(object sender, EventArgs e)
        {
            //contain有误，待修正
            if (this.previous.res.Contains(clickRes[lbIndex])||res.Contains(clickRes[lbIndex]))
                MessageBox.Show("添加失败！\n\"" + clickRes[lbIndex].songName + "\"已存在");
            else
            {
                res.Add(clickRes[lbIndex]);
                new mySql("update songs set Socount = Socount + 1 where Soname = '" + clickRes[lbIndex].songName + "'");
                MessageBox.Show("\"" + clickRes[lbIndex].songName + "\"已添加");
            }
            this.previous.Refresh();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (this.previous.res.Count == 0)
            {
                this.previous.res.AddRange(res);
                foreach (mySong ms in this.previous.res)
                    this.previous.axWindowsMediaPlayer1.currentPlaylist.appendItem
                        (this.previous.axWindowsMediaPlayer1.newMedia(ms.songPath));
                this.previous.axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                this.previous.res.AddRange(res);
                foreach (mySong ms in this.previous.res)
                    this.previous.axWindowsMediaPlayer1.currentPlaylist.appendItem
                        (this.previous.axWindowsMediaPlayer1.newMedia(ms.songPath));
            }
            this.previous.checkPlay();
            this.Close();
            this.previous.Refresh();
            this.previous.Show();//显示前驱界面
            this.previous.flag = true;
        }
    }
}
