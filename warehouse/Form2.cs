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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void btn_encoder_Click(object sender, EventArgs e)
        {
            int version = Convert.ToInt16(cb_version.Text);

            int pixel = Convert.ToInt16(cb_pixel.Text);

            string str_msg = msg_str.Text;

            int int_icon_size = Convert.ToInt16(cb_pic.Text);

            int int_icon_border = Convert.ToInt16(cb_line.Text);

            bool b_we = w_line_y.Checked ? true : false;

            Bitmap bmp = encoder.code(str_msg, version, pixel, "E:/lenovo/Pictures/soul-friend/li.JPG", int_icon_size, int_icon_border, b_we);

            QRpic.Image = bmp;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cb_version.SelectedIndex = 0;

            cb_pixel.SelectedIndex = 0;

            cb_pic.SelectedIndex = 0;

            cb_line.SelectedIndex = 0;
        }
    }
}
