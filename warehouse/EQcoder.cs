using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ZXing;
using ZXing.QrCode;
using System.Web;
using CoreScanner;
using System.Xml;

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
        public static string generate(string filename, int width, int height, string text)
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

            securitycode privacy = new securitycode();
            string newtext = privacy.Encrypt(text); //进行加密处理

            //导出图片
            Bitmap p = writer.Write(newtext);
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
        // Declare CoreScannerClass
        //属性框中将嵌入互操作类型设定为Fslse
        static CCoreScannerClass cCoreScannerClass;
        void OnBarcodeEvent(short eventType, ref string pscanData)
        {
            
            string barcode = pscanData;
            // this.Invoke((MethodInvoker)delegate { rb_mstest.Text = barcode; });
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(barcode);
            //rtshow.Text=outXML;

            string strData = String.Empty;
            string TRU_barcode = xmlDoc.DocumentElement.GetElementsByTagName("datalabel").Item(0).InnerText;
            string symbology = xmlDoc.DocumentElement.GetElementsByTagName("datatype").Item(0).InnerText;
            string[] numbers = TRU_barcode.Split(' ');
            securitycode privacy = new securitycode();

            foreach (string number in numbers)
            {
                if (String.IsNullOrEmpty(number))
                {
                    break;
                }

                strData += ((char)Convert.ToInt32(number, 16)).ToString();

            }
            string needText = privacy.Decrypt(strData);

            //filestring.itemfile_string = needText;
            filestring.tmp_string = needText;

        }
        public void getEQ_product()
        {
            
            //Instantiate CoreScanner Class
            cCoreScannerClass = new CCoreScannerClass();
            //Call Open API
            short[] scannerTypes = new short[1]; // Scanner Types you are interested in
            scannerTypes[0] = 1; // 1 for all scanner types
            short numberOfScannerTypes = 1; // Size of the scannerTypes array
            int status; // Extended API return code
            cCoreScannerClass.Open(0, scannerTypes, numberOfScannerTypes, out status);

            
            // Subscribe for barcode events in cCoreScannerClass
            cCoreScannerClass.BarcodeEvent += new
            _ICoreScannerEvents_BarcodeEventEventHandler(OnBarcodeEvent);

            // Let's subscribe for events
            int opcode = 1001; // Method for Subscribe events
            string outXML; // XML Output
            string inXML = "<inArgs>" +
            "<cmdArgs>" +
            "<arg-int>1</arg-int>" + // Number of events you want to subscribe
            "<arg-int>1</arg-int>" + // Comma separated event IDs
            "</cmdArgs>" +
            "</inArgs>";
            cCoreScannerClass.ExecCommand(opcode, ref inXML, out outXML, out status);
        }

    }
}