using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace warehouse
{
    public partial class ConfirmEQ : Form
    {
        public ConfirmEQ()
        {
            InitializeComponent();
        }
     
       
        private void Form4_Load(object sender, EventArgs e)
        {
            cfname.Text = Instoremg.name;
            cfnumber.Text = Instoremg.number;
            cfstandard.Text = Instoremg.standard;
            if (Instoremg.moremg!= "")
            {
                cfmore.Text = Instoremg.moremg;
            }   
            else
                cfmore.Text = "无";


        }

        private void btgen_Click(object sender, EventArgs e)
        {
            string info = "物品名称："+cfname.Text+"\n"
                +"序列号："+ cfnumber.Text+"\n"
                +"产品规格："+ cfstandard.Text +"\n"
                +"备注："+ cfmore.Text+"\n";
            string filename = "F:/product_info.png";
            //生成二维码的函数
            pbcode.ImageLocation = EQcoder.generate(filename, 300, 300, info);
            timer.Interval = 30000; // here time in milliseconds
            timer.Tick += timer_Tick;
            timer.Start();
            btgen.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btgen.Enabled = true;
            timer.Stop();
        }
    }
}
