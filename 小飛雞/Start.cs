using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小飛雞
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // 視窗居中顯示
        }
        public static int top_num = 0;
        public static int num = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //大小參考:200,72、175, 68

            //開啟Form1專案
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            MessageBox.Show("使用空白鍵\n進行小雞飛飛~","遊玩方式");
            timer1.Start();  //顯示成績
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num > top_num)    //設定最高分
                top_num = num;
            label1.Text = "最高分" + top_num;    //顯示分數
            label2.Text = "上次成績" + num;
        }
    }
}
