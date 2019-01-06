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
    public partial class managerForm : Form
    {
        public mainForm previous { get; internal set; }

        public managerForm()
        {
            InitializeComponent();
            label14.Visible = false;
            label17.Visible = false;
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //this.SetStyle(ControlStyles.UserPaint, true);
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
                label14.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox15.Text.Equals("") || textBox14.Text.Equals("") ||
                textBox13.Text.Equals("") || textBox1.Text.Equals(""))
                MessageBox.Show("请补全歌手信息！");
            else
            {

                MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=123456;Database=vod");
                con.Open();
                string s = "insert into singers(Sino,Siname,Sisex,Siimage)" +
                    " value('" + textBox15.Text + "','" + textBox14.Text + "','" + textBox13.Text +
                    "','" + textBox1.Text + "')";
                MySqlCommand mysqlcmd_Query = new MySqlCommand(s, con);
                mysqlcmd_Query.ExecuteNonQuery();
                MessageBox.Show("添加成功!");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            mySql my = new mySql("select * from singers where Sino = " + textBox20.Text);
            if (my.res.Count() != 0)
            {
                textBox19.Text = my.res[1];
                textBox18.Text = my.res[2];
                textBox16.Text = my.res[3];
                label17.Visible = false;
            }
            else
                label17.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定修改此条歌手信息吗？\n注意：歌手编号不容许修改，修改过程不可逆",
    "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=123456;Database=vod");
                con.Open();
                string s = "update singers " +
                    "set Siname = '" + textBox19.Text + "',Sisex = '" + textBox18.Text + "',Siimage = '" + textBox16.Text +"'"+
                    "where Sino = " + textBox20.Text;

                MySqlCommand mysqlcmd_Query = new MySqlCommand(s, con);
                mysqlcmd_Query.ExecuteNonQuery();
                MessageBox.Show("修改成功!");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("您确定删除此条歌手信息吗？此过程不可逆",
            "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                MySqlConnection con = new MySqlConnection("server=localhost;User Id=root;password=123456;Database=vod");
                con.Open();
                string s = "delete from singers where Sino = " + textBox20.Text;
                MySqlCommand mysqlcmd_Query = new MySqlCommand(s, con);
                mysqlcmd_Query.ExecuteNonQuery();
                MessageBox.Show("删除成功!");
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.previous.Show();
        }
    }
}
