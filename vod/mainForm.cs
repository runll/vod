using AxWMPLib;
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
        public Boolean flag = false;//当ax的playingcurrentItems改变时，在不在mainForm了
        public Boolean hasFlag = false;//检查mainForm的播放列表
        

        public mainForm()
        {
            InitializeComponent();

        }

        //init mainForm的播放列表
        public void checkPlay()
        {
            //新建播放列表，名字为pl   
            //axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.newPlaylist("pl", "");

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

        }


        private void searchBySinger_Click(object sender, EventArgs e)
        {
            searchBySingerForm sb = new searchBySingerForm();
            this.Hide();
            sb.Show();
            sb.previous = this;
            listBox1.Items.Clear();
            flag = false;
            if (hasFlag == false)
                axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.newPlaylist("pl", "");
            hasFlag = true;

        }
        private void searchByRank_Click(object sender, EventArgs e)
        {
            searchByRankForm sb = new searchByRankForm();
            this.Hide();
            sb.Show();
            sb.previous = this;
            listBox1.Items.Clear();
            flag = false;
            if (hasFlag == false)
                axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.newPlaylist("pl", "");
            hasFlag = true;
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
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = label4.Text.Substring(1) + label4.Text.Substring(0, 1);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //切歌
        private void label2_Click(object sender, EventArgs e)
        {
            flag = false;//在这里已经对res操作了，不需要再跳转到axWindowsMediaPlayer1_CurrentItemChange

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
                axWindowsMediaPlayer1.URL = res[0].songPath;//add
                axWindowsMediaPlayer1.Ctlcontrols.play();//add
            }
            else
            {
                res.RemoveAt(0);
                label3.Text = res[0].songName + "-" + res[0].singerName + "  ";
                label4.Text = res[1].songName + "-" + res[1].singerName + "  ";
                timer1.Start();
                timer2.Start();
                axWindowsMediaPlayer1.URL = res[0].songPath;//add
                axWindowsMediaPlayer1.Ctlcontrols.play();//add

                for (int i = 2; i < res.Count; i++)
                {
                    listBox1.Items.Add(res[i].songName + "-" + res[i].singerName + "  ");
                }
            }
            axWindowsMediaPlayer1.currentPlaylist.clear();
            foreach (mySong ms in res)
                axWindowsMediaPlayer1.currentPlaylist.appendItem(axWindowsMediaPlayer1.newMedia(ms.songPath));
            axWindowsMediaPlayer1.Ctlcontrols.play();

            flag = true;//若删掉此处，axWindowsMediaPlayer1_CurrentItemChange发生时res不会改变
        }

        private void searchByLanguage_Click(object sender, EventArgs e)
        {
            searchByLanguageForm sb = new searchByLanguageForm();
            this.Hide();
            sb.Show();
            sb.previous = this;
            flag = false;
            if (hasFlag == false)
                axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.newPlaylist("pl", "");
            hasFlag = true;

        }

        private void searchByPinyin_Click(object sender, EventArgs e)
        {
            searchByPinyinForm sb = new searchByPinyinForm();
            this.Hide();
            sb.Show();
            sb.previous = this;
            flag = false;
            if (hasFlag == false)
                axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.newPlaylist("pl", "");
            hasFlag = true;
        }

        private void axWindowsMediaPlayer1_CurrentItemChange(object sender, _WMPOCXEvents_CurrentItemChangeEvent e)
        {
            //if (flag == true)
            //{

            //    //axWindowsMediaPlayer1.Ctlcontrols.stop();//add
            //    listBox1.Items.Clear();
            //    if (res.Count == 0)
            //    {
            //        label3.Text = "null";
            //        label4.Text = "null";
            //        timer1.Stop();
            //        timer2.Stop();
            //        //axWindowsMediaPlayer1.currentPlaylist.clear();
            //    }
            //    else if (res.Count == 1)
            //    {
            //        res.RemoveAt(0);
            //        label3.Text = "null";
            //        label4.Text = "null";
            //        timer1.Stop();
            //        timer2.Stop();
            //    }
            //    else if (res.Count == 2)
            //    {
            //        res.RemoveAt(0);
            //        label3.Text = res[0].songName + "-" + res[0].singerName + "  ";
            //        label4.Text = "null";
            //        timer2.Stop();
            //        //axWindowsMediaPlayer1.URL = res[0].songPath;//add
            //       // axWindowsMediaPlayer1.Ctlcontrols.play();//add


            //    }
            //    else
            //    {
            //        res.RemoveAt(0);
            //        label3.Text = res[0].songName + "-" + res[0].singerName + "  ";
            //        label4.Text = res[1].songName + "-" + res[1].singerName + "  ";
            //        timer1.Start();
            //        timer2.Start();
            //        //axWindowsMediaPlayer1.URL = res[0].songPath;//add
            //        //axWindowsMediaPlayer1.Ctlcontrols.play();//add


            //        for (int i = 2; i < res.Count; i++)
            //        {
            //            listBox1.Items.Add(res[i].songName + "-" + res[i].singerName + "  ");
            //        }
            //    }

            //}
            if (flag == true)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                MessageBox.Show("请点击下一首！");
            }

        }
        //replay current song
        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("播放出错？点击下一首即可");
        }
    }
}
