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
    public partial class donestore : Form
    {
        public donestore()
        {
            InitializeComponent();
        }

        public static string getmsg(string item,string all)
        {
            string result = "";
            char spec = Convert.ToChar(13);
            for (int i = 0; i < all.Length; i++)
            {
                if (item[0] == all[i])
                {
                    int getid = i + item.Length ;
                    while (all[getid] != spec)
                    {
                        result += all[getid];
                        getid += 1;
                    }
                }
            }

            return result;
        }
        private void btreadEQ_Click(object sender, EventArgs e)
        {
            string filename = "F:/product_info.png";
            string EQinfo = EQcoder.readEQ(filename);
            tbname.Text = getmsg(lbname.Text, EQinfo);
            tbnumber.Text = getmsg(lbnumber.Text, EQinfo);
            tbscale.Text = getmsg(lbscale.Text, EQinfo);
            rbmsg.Text = getmsg(lbmsg.Text, EQinfo);
            tempmsg.Text = EQcoder.readEQ(filename);

        }

        private void btperson_Click(object sender, EventArgs e)
        {
            string filename = "F:/person_info.png";
            string personinfo = EQcoder.readEQ(filename);
            string secrectname = getmsg("姓名:", personinfo);
            inperson.Text = getmsg("姓名:",personinfo);
            securitycode privacy = new securitycode();
            truename.Text = privacy.Decrypt(secrectname);
        }
    }
}
