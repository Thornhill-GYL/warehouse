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
            string info = personinfo.name + personinfo.position + personinfo.apartment
                + personinfo.A_authority + personinfo.B_authority + personinfo.C_authority
                + personinfo.D_authority + personinfo.E_authority;
            string filename = "F:/person_info.png";
            //生成二维码的函数
            imgeq.ImageLocation = EQcoder.generate(filename, 300, 300, info);
            //timer.Interval = 30000; // here time in milliseconds
            //timer.Tick += timer_Tick;
            //timer.Start();
            //btgen.Enabled = false;
        }
    }
}
