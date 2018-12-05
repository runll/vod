﻿using AxWMPLib;
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

    public partial class mainForm : Form
    {
        public int lbIndex = 0;
        public List<mySong> res = new List<mySong>();
        public Boolean flag = false;


        public mainForm()
        {
            InitializeComponent();

        }

        public void checkPlay()
        {
            //新建播放列表，名字为pl
            axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.newPlaylist("pl", "");
            foreach (mySong ms in res)
                axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(ms.songPath));
            axWindowsMediaPlayer1.Ctlcontrols.play();
            if (res.Count == 0)
            {
                label3.Text = "null";
                label4.Text = "null";
            }
            else if (res.Count == 1)
            {
                label3.Text = res[0].songName + "-" + res[0].singerName + "  ";
                timer1.Start();
                label4.Text = "null";
            }
            else
            {
                label3.Text = res[0].songName + "-" + res[0].singerName + "  ";
                label4.Text = res[1].songName + "-" + res[1].singerName + "  ";
                timer1.Start();
                timer2.Start();


                for (int i = 2; i < res.Count; i++)
                {
                    listBox1.Items.Add(res[i].songName + "-" + res[i].singerName + "  ");
                }
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //if ((int)e.newState == 1)
            //    MessageBox.Show("当前歌曲播放完毕，GKD");



        }


        private void searchBySinger_Click(object sender, EventArgs e)
        {
            searchBySingerForm sb = new searchBySingerForm();
            this.Hide();
            sb.Show();
            sb.previous = this;
            listBox1.Items.Clear();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label3.Text = label3.Text.Substring(1) + label3.Text.Substring(0, 1);

            // label4.Text = label4.Text.Substring(1) + label4.Text.Substring(0, 1);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = label4.Text.Substring(1) + label4.Text.Substring(0, 1);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            flag = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            listBox1.Items.Clear();
            if (res.Count == 0)
            {
                label3.Text = "null";
                label4.Text = "null";
                timer1.Stop();
                timer2.Stop();
            }
            else if (res.Count == 1)
            {
                res.RemoveAt(0);
                label3.Text = "null";
                label4.Text = "null";
                timer1.Stop();
                timer2.Stop();
            }
            else if (res.Count == 2)
            {
                res.RemoveAt(0);
                label3.Text = res[0].songName + "-" + res[0].singerName + "  ";
                label4.Text = "null";
                timer2.Stop();
            }
            else
            {
                res.RemoveAt(0);
                label3.Text = res[0].songName + "-" + res[0].singerName + "  ";
                label4.Text = res[1].songName + "-" + res[1].singerName + "  ";
                timer1.Start();
                timer2.Start();


                for (int i = 2; i < res.Count; i++)
                {
                    listBox1.Items.Add(res[i].songName + "-" + res[i].singerName + "  ");
                }
            }
            axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.newPlaylist("pl", "");
            foreach (mySong ms in res)
                axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(ms.songPath));
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void searchByLanguage_Click(object sender, EventArgs e)
        {
            searchByLanguageForm sb = new searchByLanguageForm();
            this.Hide();
            sb.Show();
            sb.previous = this;
            flag = false;
        }

        private void searchByPinyin_Click(object sender, EventArgs e)
        {
            searchByPinyinForm sb = new searchByPinyinForm();
            this.Hide();
            sb.Show();
            sb.previous = this;
        }

        private void axWindowsMediaPlayer1_CurrentItemChange(object sender, _WMPOCXEvents_CurrentItemChangeEvent e)
        {
            if (flag == true)
            {
                listBox1.Items.Clear();
                if (res.Count == 0)
                {
                    label3.Text = "null";
                    label4.Text = "null";
                    timer1.Stop();
                    timer2.Stop();
                }
                else if (res.Count == 1)
                {
                    res.RemoveAt(0);
                    label3.Text = "null";
                    label4.Text = "null";
                    timer1.Stop();
                    timer2.Stop();
                }
                else if (res.Count == 2)
                {
                    res.RemoveAt(0);
                    label3.Text = res[0].songName + "-" + res[0].singerName + "  ";
                    label4.Text = "null";
                    timer2.Stop();
                }
                else
                {
                    res.RemoveAt(0);
                    label3.Text = res[0].songName + "-" + res[0].singerName + "  ";
                    label4.Text = res[1].songName + "-" + res[1].singerName + "  ";
                    timer1.Start();
                    timer2.Start();


                    for (int i = 2; i < res.Count; i++)
                    {
                        listBox1.Items.Add(res[i].songName + "-" + res[i].singerName + "  ");
                    }
                }
            }
        }
        //replay current song
        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
