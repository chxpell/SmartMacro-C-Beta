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
using System.Drawing.Imaging;
using System.Diagnostics;


namespace CLICKER2
{


    public partial class PixelColor : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        [DllImport("gdi32.dll")]
        public static extern int BitBlt(IntPtr hObject, int nXDest, int nYDest,
           int nWidth, int nHeight, IntPtr hObjSource, int nXSrc, int nYSrc, int dwRop);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);






        // public string c;
        Form1 frm1;
        bool state;
        int xPos;
        int yPos;
        Color c;
        string colorHTML;
        public PixelColor(Form1 F, string cHTML)
        {
            InitializeComponent();
            frm1 = F;
            state = false;
            pictureBox1.BackColor = c;
            colorHTML = cHTML;
           
        }

        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (xPos != 0 && yPos != 0)
            {

                string colorHTML = ColorTranslator.ToHtml(c);
                
                frm1.listView1.SelectedItems[0].SubItems[2].Text = xPos.ToString();
                frm1.listView1.SelectedItems[0].SubItems[3].Text = yPos.ToString();
                frm1.listView1.SelectedItems[0].SubItems[7].Text = colorHTML;
                frm1.additionalDelay = Int32.Parse(delayBox.Text);
                
            }
            if (delayBox.Text == "") delayBox.Text = "0";
            frm1.additionalDelay = Int32.Parse(delayBox.Text);

            this.Close();
        }



        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }
    



        private void PixelColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (state)
            {
                Point p1 = new Point();
                p1.X = Cursor.Position.X;
                p1.Y = Cursor.Position.Y;
                xPos = Cursor.Position.X;
                yPos = Cursor.Position.Y;
                xPosLabel.Text = xPos.ToString();
                yPosLabel.Text = yPos.ToString();
                c = GetColorAt(p1);
                pictureBox1.BackColor = c;
                state = false;
                this.TopMost = false;
            }
            this.Cursor = Cursors.Arrow;
            

        }

        public static Cursor ActuallyLoadCursor(String path)
        {
            return new Cursor(LoadCursorFromFile(path));
        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr LoadCursorFromFile(string fileName);
        

       
        private void pickColorButton_Click(object sender, EventArgs e)
        {
                state = !state;
                this.TopMost = true;
               // string filename = "C:\\Windows\\Cursors\\Eyedropper.Cur";
               // Cursor cur = ActuallyLoadCursor(filename);
               // this.Cursor = cur;
            
        }


        private void PixelColor_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }

        private void PixelColor_Shown(object sender, EventArgs e)
        {
            //Fill relevant values
            xPos = 0;
            yPos = 0;
            xPosLabel.Text = frm1.listView1.SelectedItems[0].SubItems[2].Text.ToString();
            yPosLabel.Text = frm1.listView1.SelectedItems[0].SubItems[3].Text.ToString();
            delayBox.Text = frm1.additionalDelay.ToString();
            if (colorHTML != "Color [Empty]")
            {
                //color HTML value passed in from the list view
                pictureBox1.BackColor = ColorTranslator.FromHtml(colorHTML);
            }
            
        }

        private void PixelColor_Load(object sender, EventArgs e)
        {

        }

        private void delayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Restrit user input to numbers only in a given textbox
            if (Char.IsDigit(e.KeyChar))
                return;
            else if (e.KeyChar < ' ') // <- I suggest that you allow user to press ESC, TAB etc.
                return;

            // Other keys are forbidden
            e.Handled = true;
          
        }




        
    }
}
