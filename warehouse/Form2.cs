using System;
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
using CoreScanner;
using System.Xml;

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
            //normal(tbmsg.Text);
            string ch = "示例";

        }

        private void btget_Click(object sender, EventArgs e)
        {
            string filename = "F:/product_info.png";
            rtshow.Text = readEQ(filename);
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
           
            filestring.itemfile_string = needText;
            //if (rtshow.InvokeRequired)
            //{
            //    rtshow.Invoke(new MethodInvoker(delegate
            //    {
            //        rtshow.Clear();
            //        rtshow.Text = strData;
            //        string needText = privacy.Decrypt(rtshow.Text);
            //        see16.Text = needText;
            //        filestring.itemfile_string = see16.Text;

            //    }));
            //}
           
         
        }
        private void bt_api_Click(object sender, EventArgs e)
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



            //if (txtSyblogy.InvokeRequired)
            //{
            //    txtSyblogy.Invoke(new MethodInvoker(delegate
            //    {
            //        txtSyblogy.Text = GetSymbology((int)Convert.ToInt32(symbology));
            //    }));
            //}


        }
    }
}
