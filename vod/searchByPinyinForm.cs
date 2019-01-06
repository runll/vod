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
    public partial class searchByPinyinForm : Form
    {
        public searchByPinyinForm()
        {
            InitializeComponent();
            myAddButton.Hide();
        }

        public mainForm previous { get; internal set; }
        public List<mySong> clickRes = new List<mySong>();
        public List<mySong> res = new List<mySong>();
        public int lbIndex = 0;

        private void searchByPinyinForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "A";
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            textBox1.Text += "B";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "C";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "D";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "E";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "F";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "G";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "H";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "I";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "J";
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "K";
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            textBox1.Text += "L";
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            textBox1.Text += "M";
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            textBox1.Text += "N";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "O";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "P";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Q";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "R";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "S";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "T";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "U";
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "V";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "W";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "X";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Y";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Z";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Equals(""))
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1,1);
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            myAddButton.Show();
            listBox1.Items.Clear();
            if (textBox1.Text.Length == 0)
                MessageBox.Show("请输入歌手名称首字母！");
            else
            {
                //不能智能纠错
                List<string> midRes = 
               new mySql("select Siname,Sino from singers where to_pinyin(Siname) like '%" + textBox1.Text+"%'").res;
                if (midRes.Count == 0)
                    MessageBox.Show("结果为空！");
                List<string> singerName = new List<string>();
                List<string> sino = new List<string>();
                for (int i = 0; i < midRes.Count; i++)
                {
                    if (i % 2 == 0)
                        singerName.Add(midRes[i].ToString());
                    else
                        sino.Add(midRes[i].ToString());
                }
                for (int i = 0; i < sino.Count; i++)
                {
                    List<string> songName = new mySql("select Soname from songs where Sino = '" + sino[i] + "'").res;
                    foreach(string sn in songName)
                    {
                        mySong ms = new mySong(sn, singerName[i]);
                        ms.songPath = new mySql("select Sopath from songs where Soname = '" + sn + "'").res[0];
                        clickRes.Add(ms);
                        listBox1.Items.Add(ms.songName.ToString() + " - " + ms.singerName.ToString());
                    }
                        

                }
                if (listBox1.Items.Count != 0)
                    label1.Hide();
            }
        }
        //歌曲名搜索
        private void button2_Click(object sender, EventArgs e)
        {
            myAddButton.Show();
            listBox1.Items.Clear();
            if (textBox1.Text.Length == 0)
                MessageBox.Show("请输入歌曲名称关键字母！");
            else
            {
                //不能智能纠错

                List<string> midRes = new mySql("select Soname,Siname,Sopath " +
                    "from songs,singers " +
                    "where to_pinyin(Soname) like '%"+textBox1.Text+"%' " +
                    "and songs.Sino = singers.Sino").res;
                if (midRes.Count == 0)
                    MessageBox.Show("结果为空！");
                List<string> songName = new List<string>();
                List<string> singerName = new List<string>();
                List<string> songPath = new List<string>();
                int turn = 0;
                for (int i = 0; i < midRes.Count; i++)
                {
                    if (turn == 0)//是歌曲名
                    {
                        songName.Add(midRes[i]);
                        turn = 1;
                    }
                    else if (turn == 1)//歌手名
                    {
                        singerName.Add(midRes[i]);
                        turn = 2;
                    }
                    else//歌曲路径
                    {
                        songPath.Add(midRes[i]);
                        turn = 0;
                    }
                }
                for (int i = 0; i < songName.Count; i++)
                {
                    mySong ms = new mySong(songName[i],singerName[i]);
                    ms.songPath = songPath[i];
                    clickRes.Add(ms);
                    listBox1.Items.Add(ms.songName.ToString() + " - " + ms.singerName.ToString());
                }
                
                if (listBox1.Items.Count != 0)
                    label1.Hide();
            }
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
            if (this.previous.res.Contains(clickRes[lbIndex]) || res.Contains(clickRes[lbIndex]))
                MessageBox.Show("添加失败！\n\"" + clickRes[lbIndex].songName + "\"已存在");
            else
            {
                res.Add(clickRes[lbIndex]);
                new mySql("update songs set Socount = Socount + 1 where Soname = '" + clickRes[lbIndex].songName + "'");
                MessageBox.Show("\"" + clickRes[lbIndex].songName + "\"已添加");
            }
            this.previous.Refresh();
        }

        private void returnToMain_Click(object sender, EventArgs e)
        {

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
