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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            listCombobox = getComboboxItems(this.cbname);//获取Item 
        }
        private List<string> listCombobox;
        public List<string> getComboboxItems(ComboBox cb)
        {
            //初始化绑定默认关键词
            List<string> listOnit = new List<string>();
            //将数据项添加到listOnit中
            for (int i = 0; i < cb.Items.Count; i++)
            {
                listOnit.Add(cb.Items[i].ToString());
            }

            return listOnit;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
     
                
        }

        private void cbname_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void selectcombobox(ComboBox cb , List<string> listOnit)
        {
            //输入key之后返回的关键词
            List<string> listNew = new List<string>();
            //清空combobx
            cb.Items.Clear();
            //清空listnew
            listNew.Clear();
            //遍历全部备查数据
            foreach (var item in listOnit)
            {
                if(item.Contains(cb.Text))
                {
                    //符合，插入ListNew
                    listNew.Add(item);
                }
                cb.Items.AddRange(listNew.ToArray());
                cb.SelectionStart = cb.Text.Length;
                Cursor = Cursors.Default;
                cb.DroppedDown = true;
            }

        }
        private void cbname_TextUpdate(object sender, EventArgs e)
        {
            
            selectcombobox(cbname, listCombobox);
        }
    }
}
