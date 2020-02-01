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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buildQR_Click(object sender, EventArgs e)
        {
            Form2 QRwindow = new Form2();
            QRwindow.Show();
    
        }

        private void megbt_Click(object sender, EventArgs e)
        {
            Form3 MGwindow = new Form3();
            MGwindow.Show();
        }
    }
}
