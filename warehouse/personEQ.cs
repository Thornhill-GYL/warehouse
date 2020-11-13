using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warehouse
{
    public partial class personEQ : Form
    {
        public personEQ()
        {
            InitializeComponent();
        }

        private void personEQ_Load(object sender, EventArgs e)
        {
            string info = "姓名:" + personinfo.name + "\n";
            string filename = "F:/person_info.png";
            //生成二维码的函数
            imgeq.ImageLocation = EQcoder.generate(filename, 300, 300, info);
            
            //*****打印二维码***
            TSCLIB.openportExt();
            TSCLIB.print_name_Code(info, "person");
            TSCLIB.closeportExt();
            //****打印二维码
            //timer.Interval = 30000; // here time in milliseconds
            //timer.Tick += timer_Tick;
            //timer.Start();
            //btgen.Enabled = false;
        }
    }
}
