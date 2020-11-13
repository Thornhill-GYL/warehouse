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
          

            //读取打印机状态，0=待机中，2=卡纸，4 =缺纸
            //TSCLIB.openport("TSC TTP-244 Pro");
            TSCLIB.openportExt();
            TSCLIB.printCode("1","1");
            TSCLIB.closeportExt();
            //rb_mstest.Text = "打印机状态=" + status.ToString();
            //TSCLIB.nobackfeed();
            //TSCLIB.clearbuffer();
            //// 设置 打印的方向.
            //TSCLIB.sendcommand("DIRECTION 1");
            //// 纸回拉指定长度
            ////TSCLIB_DLL.sendcommand("BACKFEED 60");

            ////二维码
            ////需要清除上一次的打印记忆
            //TSCLIB.sendcommand("CLS");
            ////語法：BAR x, y, width, height。画横线,
            ////width線條寬度，單位 dot
            ////200 DPI: 1 mm = 8 dots 
            ////TSCLIB_DLL.sendcommand("BAR 50,0,500,2");

            ////QRCODE x,y,ECC Level,cell width,mode,rotation,[justification,]model,]mask,]area] "content"
            ////ECC level容错率，H=30%,Q=25%,M=15%
            ////cell width 1~10，二维码大小，尺寸
            ////画分隔线290，不画270

            ////打印内容距离打印机出口值
            //int startY = 200;
            ////“测试ABC123”为要生成的二维码字符串
            //string command = "QRCODE 180," + startY + ",H,6,A,0,M2,S7,\"测试ABC123\"";
            //TSCLIB.sendcommand(command);

            ////设置墨汁浓度  
            ////TSCLIB_DLL.sendcommand("DENSITY 15");
            //// TSCLIB_DLL.windowsfont(100, 50, 30, 0, 0, 0, "ARIAL", "收货区域：北京(BJ)北京(010)");
            ////TSS24.BF2简体中文24*24 
            ////TSCLIB_DLL.printerfont("100", "0", "FONT001", "0", "1", "1", "收货区域：北京(BJ)北京(010)");
            //// TSCLIB_DLL.setup("79", "40", "4", "16", "40", "1", "0");

            //int fontSize = 30;
            ////离左侧边距
            //int x = 20;
            ////画分隔线290，不画270
            //int y = startY + 170;
            ////行高
            //int addNum = 40;
            //TSCLIB.windowsfont(x, y, fontSize, 0, 0, 0, "ARIAL", "收货区域：成都武侯区");

            //TSCLIB.printlabel("1", "1");
            //TSCLIB.closeport();


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
