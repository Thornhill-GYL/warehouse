﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace warehouse
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       
        public void normal(string text)
        {

            
            //调用saveFileDialog选择导出二维码保存位置
            string filename = "F:/generate1.png";
            //初始化
            BarcodeWriter writer = new BarcodeWriter();
            // writer.Format = BarcodeFormat.QR_CODE;
            writer.Format = BarcodeFormat.QR_CODE;
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            //禁用ECI
            options.DisableECI = true;
            //内容编码格式
            options.CharacterSet = "UTF-8";
            //二维码的宽高
            options.Width = int.Parse("300");
            options.Height = int.Parse("300");
            //二维码边距
            options.Margin = int.Parse("1");
            writer.Options = options;
            //导出图片
            Bitmap p = writer.Write(text);
            p.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
            p.Dispose();
            //在程序中加载导出的二维码
            pictureBox.ImageLocation = filename;


        }
       

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        public string readEQ(string filename)
        {
            BarcodeReader reader = new BarcodeReader();
            reader.Options.CharacterSet = "UTF-8";
            Bitmap map = new Bitmap(filename);
            Result result = reader.Decode(map);
            return result == null ? "" : result.Text;
        }
        private void btgen_Click(object sender, EventArgs e)
        {
            normal(tbmsg.Text);
        }

        private void btget_Click(object sender, EventArgs e)
        {
            string filename = "F:/product_info.png";
            rtshow.Text = readEQ(filename);
        }
    }
}
