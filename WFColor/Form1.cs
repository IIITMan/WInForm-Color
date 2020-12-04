using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WFColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]//取设备场景 
        private static extern IntPtr GetDC(IntPtr hwnd);//返回设备场景句柄 
        [DllImport("gdi32.dll")]
        private static extern int GetPixel(IntPtr hdc, Point p);
        [DllImport("gdi32.dll")]//取指定点颜色 
        private static extern bool BitBlt(
          IntPtr hdcDest,//目标设备的句柄
          int nXDest,//目标对象的左上角x坐标
          int nYDest,//目标对象的左上角Y坐标
          int nWidth,//目标对象的矩形宽度
          int nHeight,//目标对象的矩形长度
          IntPtr hdcSrc,//源设备的句柄
          int nXSrc,//源对象的左上角x坐标
          int nYSrc,//源对象的左上角y坐标
          System.Int32 dwRop//光栅的操作值
          );

        public const int SRCCOPY = 0x00CC0020;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            Timer tim = new Timer();
            tim.Interval = 1;
            tim.Tick += delegate
            {
                lbl_X.Text = "X:" + MousePosition.X;
                lbl_Y.Text = "Y:" + MousePosition.Y;
                Point p = new Point(MousePosition.X, MousePosition.Y);//取置顶点坐标 
                IntPtr hdc = GetDC(new IntPtr(0));//取到设备场景(0就是全屏的设备场景) 
                int c = GetPixel(hdc, p);//取指定点颜色 
                int r = (c & 0xFF);//转换R 
                int g = (c & 0xFF00) / 256;//转换G 
                int b = (c & 0xFF0000) / 65536;//转换B 
                pictureBox2.BackColor = Color.FromArgb(r, g, b);
                Graphics grDest = Graphics.FromHwnd(pictureBox1.Handle);
                //Graphics grSrc = Graphics.FromImage(bmp);
                IntPtr hdcDest = grDest.GetHdc();
                //IntPtr hdcSrc = grSrc.GetHdc();
                txt_16.Text = System.Drawing.ColorTranslator.ToHtml(Color.FromArgb(r, g, b));
                txt_rgb.Text = "rgb(" + r + "," + g + "," + b + ")";
                BitBlt(hdcDest, 0, 0, 150, 150, hdc, MousePosition.X - 75, MousePosition.Y - 75, SRCCOPY);
                Graphics grfx = pictureBox1.CreateGraphics();
                grfx.DrawLine(new Pen(Color.Red, 1), 75, 70, 75, 80);
                grfx.DrawLine(new Pen(Color.Red, 1), 70, 75, 80, 75);
                grfx.Dispose(); 
            };
            tim.Start();
            
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txt_16.Text, true);
            lbl01.Text = "已复制";
            lbl02.Text = "Alt+W复制";
        }

        private void copyrgb_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txt_rgb.Text, true);
            lbl01.Text = "Alt+Q复制";
            lbl02.Text = "已复制";
        }
    }
}
