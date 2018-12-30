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
    public partial class signIn : Form
    {
        public mainForm previous { get; internal set; }
        public signIn()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void signIn_Load(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.PasswordChar = new char();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mySql my = new mySql("select Mid,Mpassword from managers");
            for (int i = 0; i < my.res.Count(); i++)
            {
                if (my.res[i].Equals(textBox1.Text.Trim()) && i % 2 == 0 && my.res[i + 1].Equals(textBox2.Text.Trim()))
                {
                    MessageBox.Show("欢迎您！\n管理员 " + textBox1.Text);
                    manegerForm mf = new manegerForm();
                    mf.previous = this.previous;
                    mf.Show();
                    this.Hide();

                    break;
                }
                if (i == my.res.Count() - 1)
                    label3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.previous.Show();
            
        }
    }
}
