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
    public partial class searchByRankForm : Form
    {
        public mainForm previous { get; internal set; }
        public List<mySong> clickRes = new List<mySong>();
        public List<mySong> res = new List<mySong>();
        public int lbIndex = 0;
        public searchByRankForm()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            //等值连接，可以上台面
            List<string> sRes = new mySql("select Soname,Siname " +
                "from songs,singers " +
                "where songs.Sino = singers.Sino " + 
                "order by Socount desc " +
                "limit 0,10").res;
            //Soname + Siname
            listBox1.Items.Clear();
            List<string> songNames = new List<string>();
            List<string> singerNames = new List<string>();
            for (int i = 0; i < sRes.Count; i++)
            {
                if (i % 2 == 0)
                    songNames.Add(sRes[i].ToString());
                else
                    singerNames.Add(sRes[i].ToString());
            }
            for (int i = 0; i < songNames.Count; i++)
            {
                mySong ms = new mySong(songNames[i], singerNames[i]);
                ms.songPath = new mySql("select Sopath from songs where Soname = '" + songNames[i] + "'").res[0];
                clickRes.Add(ms);
                listBox1.Items.Add(ms.songName.ToString() + " - " + ms.singerName.ToString());
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
