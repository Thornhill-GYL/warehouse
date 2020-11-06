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
            InputMG MGwindow = new InputMG();
            MGwindow.Show();
        }

        private void sysbt_Click(object sender, EventArgs e)
        {
            //Setsystem configwindow = new Setsystem();
            //configwindow.Show();
            authority usercode = new authority();
            usercode.Show();
        }

        private void storebt_Click(object sender, EventArgs e)
        {
            donestore instorewindow = new donestore();
            instorewindow.Show();
        }

        private void outbt_Click(object sender, EventArgs e)
        {
            outstore outstorewindow = new outstore();
            outstorewindow.Show();
        }
    }
}
