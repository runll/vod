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
        public mainForm()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            wmp.URL = @"F:\CloudMusic\三个糙汉一个软妹组 LON - 我的一个道姑朋友（Cover タイナカ彩智）.mp3";
            wmp.controls.play();
        }

        private void searchBySinger_Click(object sender, EventArgs e)
        {
            searchBySingerForm sb = new searchBySingerForm();
            this.Hide();
            sb.Show();
            sb.previous = this;
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
