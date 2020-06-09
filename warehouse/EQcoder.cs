using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ZXing;
using ZXing.QrCode;

namespace warehouse
{
    class EQcoder
    {
        /*
         * generate 用于生成二维码函数
         * filename:是指定生成文件的文件名和文件地址
         * width:指定的宽度
         * height：指定的高度
         * text:输入的内容信息
         * return：返回最终生成文件的地址
         */
        public static string generate(string filename,int width,int height,string text)
        {


            //调用saveFileDialog选择导出二维码保存位置
            //string filename = "F:/product_info.png";
            //初始化
            BarcodeWriter writer = new BarcodeWriter();
           
            writer.Format = BarcodeFormat.QR_CODE;
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            //禁用ECI
            options.DisableECI = true;
            //内容编码格式
            options.CharacterSet = "UTF-8";
            //二维码的宽高
            options.Width = width;
            options.Height = height;
            //二维码边距
            options.Margin = 1;
            writer.Options = options;
            //导出图片
            Bitmap p = writer.Write(text);
            p.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
            p.Dispose();
            //在程序中加载导出的二维码
            //pbcode.ImageLocation = filename;
            return filename;

        }
        /*
         * readEQ函数：读取二维码，目前的形式是从系统中保存的图片读取
         * filename：是系统中有的二维码的信息
         * 之后将其改为从扫描枪读取；
         */
        public static string readEQ(string filename)
        {
            BarcodeReader reader = new BarcodeReader();
            reader.Options.CharacterSet = "UTF-8";
            Bitmap map = new Bitmap(filename);
            Result result = reader.Decode(map);
            return result == null ? "" : result.Text;
        }
    }
}