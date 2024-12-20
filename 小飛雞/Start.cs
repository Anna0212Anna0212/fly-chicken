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

        private void button1_Click(object sender, EventArgs e)
        {
            //大小參考:200,72、175, 68

            //開啟Form1專案
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            
        }
    }
}
