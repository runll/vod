using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vod
{
    public partial class myTabPage : UserControl
    {
        List<string> iPath = new imagePathList().res;
        int count = 0;

        public myTabPage()
        {
            InitializeComponent();
            foreach (System.Windows.Forms.TabPage tp in this.tabControl1.TabPages)
            {
                myPanel myPanel1 = new myPanel(19,30);
                
                tp.Controls.Add(myPanel1);
                myPanel myPanel2 = new myPanel(19, 260);
                tp.Controls.Add(myPanel2);
                myPanel myPanel3 = new myPanel(19, tp.Width-230);
                tp.Controls.Add(myPanel3);
                myPanel myPanel4 = new myPanel(170, 30);
                tp.Controls.Add(myPanel4);
                myPanel myPanel5 = new myPanel(170, 260);
                tp.Controls.Add(myPanel5);
                myPanel myPanel6 = new myPanel(170, tp.Width - 230);
                tp.Controls.Add(myPanel6);



                addImagth(myPanel1);
                addImagth(myPanel2);
                addImagth(myPanel3);
                addImagth(myPanel4);
                addImagth(myPanel5);
                addImagth(myPanel6);

            }
        }/// <summary>
        ///12-1 14：00
        /// 给panel里的picbox增加图片，并由路径名获取歌手名放在label中
        /// </summary>
        /// <param name="mp"></param>
        public void addImagth(myPanel mp) {
            if (count<iPath.Count) {
                mp.pictureBox1.ImageLocation = iPath[count];
                string[] imageName = iPath[count].Split('\\');
                string singerNameBySplit = imageName[imageName.Length - 1].Split('.')[0];
                mp.label1.Text = singerNameBySplit;
                
                    count++;
            }
        }
    }
}
