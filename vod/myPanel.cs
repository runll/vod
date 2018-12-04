using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace vod
{
    public partial class myPanel : UserControl
    {
        public string[] songsName;
        public string singersName;
        public string songPath = "";
        public List<mySong> mySongByClickName = new List<mySong>();
        public myPanel()
        {
            InitializeComponent();
        }
        public myPanel(int top,int left)
        {
            InitializeComponent();
            this.Top = top;
            this.Left = left;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //TODO
            //由label1.Text歌手名字搜索对应的歌曲，并以列表（歌名+歌手）返回到一个容器中
            //点击该容器里的每一条数据结构可添加到播放列表中
            //播放列表还没实现
            
            string singerName = label1.Text;
            List<string> sino = new mySql("select Sino from singers where Siname = '"+singerName+"'").res;

            List<string> songs = new mySql("select Soname from songs where Sino = '"+sino[0]+"'").res;

            
            
            searchBySingerForm f = (searchBySingerForm)FindForm(label1);
                //MessageBox.Show(f.Name);
            ListBox listBox1 = (ListBox)f.Controls.Find("listBox1",true)[0];
            //f.selectedPanel = this;
            listBox1.Items.Clear();
            foreach(string s in songs) {
                listBox1.Items.Add(s + "-" + singerName);
                mySong res = new mySong(s,singerName);
                res.songPath = new mySql("select Sopath from songs where Soname = '"+s+"'").res[0];
                mySongByClickName.Add(res); 
            }
            Label nullLabel = (Label)f.Controls.Find("label1",true)[0];
            nullLabel.Hide();
            f.clickRes = mySongByClickName;
            //MessageBox.Show(mySongByClickName[0].songName + "\n" + mySongByClickName[0].singerName + "\n" + mySongByClickName[0].songPath);
        }
        //递归找父控件，直到找到Form
        public Form FindForm(Control c)
        {
            if (c is Form)
                return c as Form;
            else if (c.Parent != null)
                return FindForm(c.Parent);
            else
                return null;
        }
    }
}
