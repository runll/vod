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
    public partial class manegerForm : Form
    {
        public mainForm previous { get; internal set; }

        public manegerForm()
        {
            InitializeComponent();
            label14.Visible = false;
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //add
        private void button2_Click(object sender, EventArgs e)
        {
            
            panel3.Visible = true;

        }

        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        //modify
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals("") || textBox4.Text.Equals("") ||
                textBox5.Text.Equals("") || textBox6.Text.Equals("") ||
                textBox7.Text.Equals("") )
                MessageBox.Show("请补全歌曲信息！");
            else
            {

                MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=123456;Database=vod");
                con.Open();
                string s = "insert into songs(Sono,Soname,Sino,Lno,Sopath,Socount)" +
                    " value('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + 
                    "','"+textBox6.Text+"','"+ textBox7.Text + "','0')" ;
                MySqlCommand mysqlcmd_Query = new MySqlCommand(s, con);
                mysqlcmd_Query.ExecuteNonQuery();
                MessageBox.Show("添加成功!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mySql my = new mySql("select * from songs where Sono = "+textBox8.Text);
            if (my.res.Count() != 0)
            {
                textBox12.Text = my.res[1];
                textBox11.Text = my.res[2];
                textBox10.Text = my.res[3];
                textBox9.Text = my.res[4];
            }
            else
                label14.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定删除此条歌曲吗？此过程不可逆",
                "提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=123456;Database=vod");
                con.Open();
                string s = "delete from songs where Sono = " + textBox8.Text;
                MySqlCommand mysqlcmd_Query = new MySqlCommand(s, con);
                mysqlcmd_Query.ExecuteNonQuery();
                MessageBox.Show("删除成功!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定修改此条歌曲信息吗？\n注意：歌曲编号不容许修改，修改过程不可逆",
                "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=123456;Database=vod");
                con.Open();
                string s = "update songs " +
                    "set Soname = '" + textBox12.Text + "',Sino = '" + textBox11.Text + "',Lno = '" + textBox10.Text + "',Sopath = '" + textBox9.Text + "'" +
                    "where Sono = " + textBox8.Text;

                MySqlCommand mysqlcmd_Query = new MySqlCommand(s, con);
                mysqlcmd_Query.ExecuteNonQuery();
                MessageBox.Show("修改成功!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.previous.Show();
        }
    }
}
