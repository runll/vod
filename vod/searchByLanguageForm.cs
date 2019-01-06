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

namespace vod
{
    public partial class searchByLanguageForm : Form
    {
        public mainForm previous { get; internal set; }
        public List<mySong> clickRes= new List<mySong>();
        public List<mySong> res = new List<mySong>();
        public int lbIndex = 0;
        public searchByLanguageForm()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            clickRes.Clear();
            listBox1.Items.Clear();
            //得到Soname、Sino交替的List
            List<string> res =  new mySql("select Soname,Sino from songs where Lno = '1'").res;
            List<string> songName = new List<string>();
            List<string> sino = new List<string>();
            for (int i = 0; i < res.Count; i++)
            {
                if (i % 2 == 0)
                    songName.Add(res[i]);
                else
                    sino.Add(res[i]);
            }
            //songName.count == sino.count
            for (int i = 0; i < sino.Count; i++)
            {
                string singerName = new mySql("select Siname from singers where Sino = '"+sino[i]+"'").res[0];
                mySong ms = new mySong(songName[i], singerName);
                ms.songPath = new mySql("select Sopath from songs where Soname = '"+songName[i]+"'").res[0];
                clickRes.Add(ms);
                listBox1.Items.Add(ms.songName+" - "+ms.singerName);
            }
            if (listBox1.Items.Count != 0)
                label1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            this.previous.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickRes.Clear();
            listBox1.Items.Clear();
            List<string> res = new mySql("select Soname,Sino from songs where Lno = '2'").res;
            List<string> songName = new List<string>();
            List<string> sino = new List<string>();
            for (int i = 0; i < res.Count; i++)
            {
                if (i % 2 == 0)
                    songName.Add(res[i]);
                else
                    sino.Add(res[i]);
            }
            //songName.count == sino.count
            for (int i = 0; i < sino.Count; i++)
            {
                string singerName = new mySql("select Siname from singers where Sino = '" + sino[i] + "'").res[0];
                mySong ms = new mySong(songName[i], singerName);
                ms.songPath = new mySql("select Sopath from songs where Soname = '" + songName[i] + "'").res[0];
                clickRes.Add(ms);
                listBox1.Items.Add(ms.songName + " - " + ms.singerName);
            }
            if (listBox1.Items.Count != 0)
                label1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickRes.Clear();
            listBox1.Items.Clear();
            List<string> res = new mySql("select Soname,Sino from songs where Lno = '3'").res;
            List<string> songName = new List<string>();
            List<string> sino = new List<string>();
            for (int i = 0; i < res.Count; i++)
            {
                if (i % 2 == 0)
                    songName.Add(res[i].ToString());
                else
                    sino.Add(res[i].ToString());
            }

            for (int i = 0; i < sino.Count; i++)
            {
                string singerName = new mySql("select Siname from singers where Sino = '" + sino[i] + "'").res[0].ToString();
                
                mySong ms = new mySong(songName[i], singerName);
                ms.songPath = new mySql("select Sopath from songs where Soname = '" + songName[i] + "'").res[0];
                clickRes.Add(ms);
                listBox1.Items.Add(ms.songName.ToString() + " - " + ms.singerName.ToString());
            }
            if (listBox1.Items.Count != 0)
                label1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickRes.Clear();
            listBox1.Items.Clear();
            List<string> res = new mySql("select Soname,Sino from songs where Lno = '4'").res;
            List<string> songName = new List<string>();
            List<string> sino = new List<string>();
            for (int i = 0; i < res.Count; i++)
            {
                if (i % 2 == 0)
                    songName.Add(res[i]);
                else
                    sino.Add(res[i]);
            }
            //songName.count == sino.count
            for (int i = 0; i < sino.Count; i++)
            {
                string singerName = new mySql("select Siname from singers where Sino = '" + sino[i] + "'").res[0];
                mySong ms = new mySong(songName[i], singerName);
                ms.songPath = new mySql("select Sopath from songs where Soname = '" + songName[i] + "'").res[0];
                clickRes.Add(ms);
                listBox1.Items.Add(ms.songName + " - " + ms.singerName);
            }
            if (listBox1.Items.Count != 0)
                label1.Hide();
        }
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.IndexFromPoint(e.X, e.Y);
            listBox1.SelectedIndex = index;
            if (listBox1.SelectedIndex != -1)
            {
               // MessageBox.Show(listBox1.SelectedItem.ToString());
                lbIndex = listBox1.SelectedIndex;
            }
        }
        private void myAddButton_Click(object sender, EventArgs e)
        {

            //lbIndex = listBox1.SelectedIndex;
            if (this.previous.res.Contains(clickRes[lbIndex])|| res.Contains(clickRes[lbIndex]))
                MessageBox.Show("添加失败！\n\"" + clickRes[lbIndex].songName + "\"已存在");
            else
            {
                //this.previous.axWindowsMediaPlayer1.currentPlaylist.appendItem
                //    (this.previous.axWindowsMediaPlayer1.newMedia(clickRes[lbIndex].songPath));
               res.Add(clickRes[lbIndex]);
                //this.previous.listBox1.Items.Add(clickRes[lbIndex].songName + "-" + clickRes[lbIndex].singerName + "  ");
                new mySql("update songs set Socount = Socount + 1 where Soname = '"+ clickRes[lbIndex].songName+"'");
                MessageBox.Show("\""+ clickRes[lbIndex].songName + "\"已添加");
            }
            this.previous.Refresh();
           
        }

        private void returnToMain_Click(object sender, EventArgs e)
        {           

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.previous.res.Count == 0)
            {
                this.previous.res.AddRange(res);
                foreach (mySong ms in this.previous.res)
                    this.previous.axWindowsMediaPlayer1.currentPlaylist.appendItem
                        (this.previous.axWindowsMediaPlayer1.newMedia(ms.songPath));
                // this.previous.axWindowsMediaPlayer1.URL = res[0].songPath;
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
            //this.previous.listBox1.Items.Add("-------------");
            //foreach (mySong ms in this.previous.res)
            //{
            //    this.previous.listBox1.Items.Add(ms.songName);
            //}
            //测试结果：res能正确更新，有问题的地方应该是ax的currentPlaylist
            this.Close();
            this.previous.Refresh();
            this.previous.Show();//显示前驱界面
            this.previous.flag = true;
        }
    }
}
