using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace warehouse
{
    class TSCLIB
    {
        [DllImport("TSCLib.dll", EntryPoint = "about")]
        public static extern int about();

        [DllImport("TSCLib.dll", EntryPoint = "openport")]
        public static extern int openport(string printername);

        [DllImport("TSCLib.dll", EntryPoint = "barcode")]
        public static extern int barcode(string x, string y, string type,
                    string height, string readable, string rotation,
                    string narrow, string wide, string code);

        [DllImport("TSCLib.dll", EntryPoint = "clearbuffer")]
        public static extern int clearbuffer();

        [DllImport("TSCLib.dll", EntryPoint = "closeport")]
        public static extern int closeport();

        [DllImport("TSCLib.dll", EntryPoint = "downloadpcx")]
        public static extern int downloadpcx(string filename, string image_name);

        [DllImport("TSCLib.dll", EntryPoint = "formfeed")]
        public static extern int formfeed();

        [DllImport("TSCLib.dll", EntryPoint = "nobackfeed")]
        public static extern int nobackfeed();

        [DllImport("TSCLib.dll", EntryPoint = "printerfont")]
        public static extern int printerfont(string x, string y, string fonttype,
                        string rotation, string xmul, string ymul,
                        string text);

        [DllImport("TSCLib.dll", EntryPoint = "printlabel")]
        public static extern int printlabel(string set, string copy);

        [DllImport("TSCLib.dll", EntryPoint = "sendcommand")]
        public static extern int sendcommand(string printercommand);

        [DllImport("TSCLib.dll", EntryPoint = "setup")]
        public static extern int setup(string width, string height,
                  string speed, string density,
                  string sensor, string vertical,
                  string offset);

        [DllImport("TSCLib.dll", EntryPoint = "windowsfont")]
        public static extern int windowsfont(int x, int y, int fontheight,
                        int rotation, int fontstyle, int fontunderline,
                        string szFaceName, string content);
        [DllImport("TSCLib.dll", EntryPoint = "usbportqueryprinter")]
        public static extern int usbportqueryprinter();




        //打开打印机端口,并进行相关设置
        public static void openportExt()
        {
            
            TSCLIB.openport("TSC TTP-244 Pro");//找打打印机端口

            //TSCLIB.setup("94", "25", "4", "8", "0", "3.5", "0");
            TSCLIB.sendcommand("SIZE 60 mm,30 mm");//设置条码大小
            TSCLIB.sendcommand("GAP 2 mm,0");//设置条码间隙
            TSCLIB.sendcommand("SPEED 4");//设置打印速度
            TSCLIB.sendcommand("DENSITY 7");//设置墨汁浓度
            TSCLIB.sendcommand("DERECTION 1");//设置相对起点
            TSCLIB.sendcommand("REFERENCE 3 mm,3 mm");//设置偏移边框
            TSCLIB.sendcommand("CLS");//清除记忆（每次打印新的条码时先清除上一次的打印记忆）
        }
        //打印二维码
        public static void printCode(string strcode,string info)
        {
           
            securitycode privacy = new securitycode();
            string newtext = privacy.Encrypt(strcode); //进行加密处理
            string codeValue = newtext;
            TSCLIB.sendcommand("CLS");//需要清除上一次的打印记忆
            TSCLIB.sendcommand("DIRECTION 1");
            TSCLIB.sendcommand("QRCODE 100,20,H,4,A,0,M2,S7,\"" + codeValue + "\"");
          
            

            TSCLIB.printlabel("1", "1");
        }
        //打印姓名二维码
        public static void print_name_Code(string strcode, string info)
        {

            securitycode privacy = new securitycode();
            string newtext = privacy.Encrypt(strcode); //进行加密处理
            string codeValue = newtext;
            TSCLIB.sendcommand("CLS");//需要清除上一次的打印记忆
            TSCLIB.sendcommand("DIRECTION 1");
            TSCLIB.sendcommand("QRCODE 100,50,H,4,A,0,M2,S7,\"" + codeValue + "\"");
            TSCLIB.windowsfont(200, 20, 24, 200, 0, 0, "黑体", info);



            TSCLIB.printlabel("1", "1");
        }





        //关闭打印机端口
        public static void closeportExt()
        {
            TSCLIB.closeport();
        }
    }
}
