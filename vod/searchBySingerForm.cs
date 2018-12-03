using MySql.Data.MySqlClient;
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
    public partial class searchBySingerForm : Form
    {
        
        public mainForm previous { get; internal set; }
        //List<string> res = new imagePathList().res;
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
            this.Close();
            this.previous.Show();//显示前驱界面

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
                MessageBox.Show(listBox1.SelectedItem.ToString());
            }
        }
    }
}
