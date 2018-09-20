using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;

namespace CLICKER2
{
    
    
   
    public partial class Form1 : Form
    {
        Keys add; //Holds the key code for the add action hotkey
        Keys startStop; //Holds the keycode for the start/stop hotkey
        bool running = false; //Holds the running state of the script
        PixelColor pcolor; // Frame when doule clicking Wait For Pixel action 
        public int additionalDelay; //Additional time after wait for pixel finished
        string READ_FILENAME = ""; //Stores path for Read From File function to read from

        /*  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *
         *  Handles mouse click events
         */
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        [DllImport("gdi32.dll")]
        public static extern int BitBlt(IntPtr hObject, int nXDest, int nYDest,
           int nWidth, int nHeight, IntPtr hObjSource, int nXSrc, int nYSrc, int dwRop);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);



        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        //*  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *  *

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int STARTSTOP_ID = 1;

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
            this.comboBox1.SelectedIndex = 0;
            this.repeatBox.Text = "1";
            this.delayBox.Text = "100";
            string empt = "";
            pcolor = new PixelColor(this, empt);

            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, STARTSTOP_ID, 4, (int)Keys.F7);

           
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == STARTSTOP_ID)
            {

                running = !running;
                if (running)
                    performAction();
                 
                 
            }
            base.WndProc(ref m);
        }


        public void DoMouseClick(int x, int y, char c)
        {
            
            SetCursorPos(x, y);
            this.Refresh();
            if (c == 'L')
            {
                //left click
                Application.DoEvents();
                mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
            }
            else if (c == 'R')
            {
                //right click
                Application.DoEvents();
                mouse_event(MOUSEEVENTF_RIGHTDOWN, x, y, 0, 0);
                mouse_event(MOUSEEVENTF_RIGHTUP, x, y, 0, 0);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                delayBox.Text = listView1.SelectedItems[0].SubItems[4].Text; //Delay
                noteBox.Text = listView1.SelectedItems[0].SubItems[6].Text;//note
                comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text; //copy action
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //keypress
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == add) //add an action
            {
                if (Int32.Parse(repeatBox.Text) <= 0) repeatBox.Text = "1"; //If user enters invalid repeat value

                if (delayBox.Text == "" || Int32.Parse(delayBox.Text) < 0 )
                {
                    ToolTip tt = new ToolTip();
                    tt.Show("Delay must be a positive integer", delayBox, 5, 5, 2000);
                    return;
                }
                if (comboBox1.Text == "Left Click" || comboBox1.Text == "Right Click" || comboBox1.Text == "Double Click")
                {
                    //Build an item that contains coordinates
                    
                    String[] row = { (listView1.Items.Count + 1).ToString(), comboBox1.Text, Cursor.Position.X.ToString(), Cursor.Position.Y.ToString(), delayBox.Text, repeatBox.Text, noteBox.Text, "" };
                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);
                }
                else if (comboBox1.Text != "Wait For Pixel" && comboBox1.Text != "Read From File") //build an item that does not contain coordinates
                {
                    String[] row = { (listView1.Items.Count + 1).ToString(), comboBox1.Text, "", "", delayBox.Text, repeatBox.Text, noteBox.Text, "" };
                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);
                }
                else if (comboBox1.Text == "Wait For Pixel")
                {
                    Color c = new Color();
                    String[] row = { (listView1.Items.Count + 1).ToString(), comboBox1.Text, "", "", delayBox.Text, repeatBox.Text, noteBox.Text, c.ToString() };
                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);

                }
                else if (comboBox1.Text == "Read From File")
                {
                    String[] row = { (listView1.Items.Count + 1).ToString(), comboBox1.Text, "", "", delayBox.Text, repeatBox.Text, noteBox.Text };
                    ListViewItem item = new ListViewItem(row);
                    listView1.Items.Add(item);

                    OpenFileDialog ofd = new OpenFileDialog();
                                    ofd.Filter = "TXT files|*.txt";



                    ofd.Title = "Load Text File";
                    var dialogResult = ofd.ShowDialog();

                    if (!string.IsNullOrEmpty(ofd.FileName))
                    {
                        READ_FILENAME = ofd.FileName;
 

                     } //end if
                }

                
            }
            else if (e.KeyCode == startStop) //if the start stop button is pressed
            {
                running = !running; //toggle the running state
                
                performAction(); //iterate through the listView and perform each action
            }
        }



        private void performAction()
        {

                int i = 0;
                int delay;
                 
                if (running && listView1.Items.Count != 0) //if currently running, iterate through listView, reading the action and executing
                {
                   // this.Cursor = Cursors.Cross; // Change cursor to cross
                    foreach (ListViewItem itemRow in this.listView1.Items)
                    {
                        for (int j = 0; j < Int32.Parse(itemRow.SubItems[5].Text); j++) //Repeat the action based on the repeat amount
                        {
                            if (running)
                            {
                                delay = Int32.Parse(itemRow.SubItems[4].Text); //sleep for delay amount before action
                                System.Threading.Thread.Sleep(delay);


                                if (itemRow.SubItems[1].Text == "Left Click")
                                {
                                    DoMouseClick(Int32.Parse(itemRow.SubItems[2].Text), Int32.Parse(itemRow.SubItems[3].Text), 'L');
                                }
                                if (itemRow.SubItems[1].Text == "Double Click")
                                {
                                    DoMouseClick(Int32.Parse(itemRow.SubItems[2].Text), Int32.Parse(itemRow.SubItems[3].Text), 'L');
                                    System.Threading.Thread.Sleep(5);
                                    DoMouseClick(Int32.Parse(itemRow.SubItems[2].Text), Int32.Parse(itemRow.SubItems[3].Text), 'L');
                                }
                                if (itemRow.SubItems[1].Text == "Right Click")
                                {
                                    DoMouseClick(Int32.Parse(itemRow.SubItems[2].Text), Int32.Parse(itemRow.SubItems[3].Text), 'R');
                                }
                                if (itemRow.SubItems[1].Text == "CTRL+C")
                                {
                                    SendKeys.Send("^(c)");
                                }
                                if (itemRow.SubItems[1].Text == "CTRL+V")
                                {
                                    SendKeys.Send("^(v)");
                                }
                                if (itemRow.SubItems[1].Text == "CTRL+A")
                                {
                                    SendKeys.Send("^(a)");
                                }
                                if (itemRow.SubItems[1].Text == "CTRL+F")
                                {
                                    SendKeys.Send("^(f)");
                                }
                                if (itemRow.SubItems[1].Text == "CTRL+S")
                                {
                                    SendKeys.Send("^(s)");
                                }
                                if (itemRow.SubItems[1].Text == "Press Esc")
                                {
                                    SendKeys.Send("{ESC}");
                                }
                                if (itemRow.SubItems[1].Text == "Press Tab")
                                {
                                    SendKeys.Send("{TAB}");
                                }
                                if (itemRow.SubItems[1].Text == "Press Enter")
                                {
                                    SendKeys.Send("{ENTER}");
                                }
                                if (itemRow.SubItems[1].Text == "Press Backspace")
                                {
                                    SendKeys.Send("{BACKSPACE}");
                                }
                                if (itemRow.SubItems[1].Text == "Left Arrow")
                                {
                                    SendKeys.Send("{LEFT}");
                                }
                                if (itemRow.SubItems[1].Text == "Right Arrow")
                                {
                                    SendKeys.Send("{RIGHT}");
                                }
                                if (itemRow.SubItems[1].Text == "Up Arrow")
                                {
                                    SendKeys.Send("{UP}");
                                }
                                if (itemRow.SubItems[1].Text == "Down Arrow")
                                {
                                    SendKeys.Send("{DOWN}");
                                }
                                if (itemRow.SubItems[1].Text == "Type Note")
                                {
                                    foreach (char c in itemRow.SubItems[6].Text)
                                    {
                                        string key = "" + c;
                                        SendKeys.Send(key);
                                    }
                                }
                                if (itemRow.SubItems[1].Text == "Wait For Pixel")
                                {
                                    Point p1 = new Point();
                                    p1.X = Int32.Parse(itemRow.SubItems[2].Text);
                                    p1.Y = Int32.Parse(itemRow.SubItems[3].Text);
                                    Color current = GetColorAt(p1);
                                    Color dest = ColorTranslator.FromHtml(itemRow.SubItems[7].Text);

                                    while (running)
                                    {

                                        //current = GetColorAt(p1);
                                        if (current == dest)
                                            break;
                                        else
                                        {

                                            current = GetColorAt(p1);
                                        }
                                    }

                                    System.Threading.Thread.Sleep(additionalDelay);
                                }
                                if (itemRow.SubItems[1].Text == "Read From File")
                                {


                                  //  MessageBox.Show(READ_FILENAME);
                                    using (StreamReader sr = new StreamReader(READ_FILENAME))
                                    {
                                        while (sr.Peek() >= 0)
                                        {
                                            char c = (char)sr.Read();
                                            string key = "" + c;
                                            SendKeys.Send(key);
                                        }
                                    }
                                    

                                }
                            }
                            // end loop if last item is reached
                            if (i == listView1.Items.Count - 1)
                            {
                                running = false; //terminate script
                                break;
                            }

                            i++;

                        }//end for loop
                    }//end if running
                    this.Cursor = Cursors.Arrow;
                }
        }
    

        private void startStopButton_Click(object sender, EventArgs e)
        {
            running = !running;
            if(running)
                performAction();
        }

        private void assignActionHotkey_Click(object sender, EventArgs e)
        {
            //set global keycode to the entered value
            Enum.TryParse<Keys>(addActionHotkey.Text, out add);
        }

        private void assignStartStop_Click_1(object sender, EventArgs e)
        {
            //set global keycode to the entered value
            Enum.TryParse<Keys>(startStopBox.Text, out startStop);
        }

        private void addActionHotkey_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            addActionHotkey.Text = String.Empty;
                addActionHotkey.Text = "" + e.KeyCode.ToString();
          
        }

        private void startStopBox_KeyDown(object sender, KeyEventArgs e)
        {
            startStopBox.Text = String.Empty;
            startStopBox.Text = "" + e.KeyCode.ToString();
        }


        private void removeActionButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            int newVal;
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                index = listView1.SelectedIndices[0];
                listView1.Items.Remove(eachItem);
            }


        }









        //----------------------------------------------------------------------------------
        private void actionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void xBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void delayBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void noteBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addActionHotkey_TextChanged(object sender, EventArgs e)
        {

           // addActionHotkey.Text = addActionHot;
        }

        private void startStopBox_TextChanged_1(object sender, EventArgs e)
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
             e .Handled = true;
          
            }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            // If double clicking an item, show appropriate windows
            PixelColor pWindow = new PixelColor(this, listView1.SelectedItems[0].SubItems[7].Text);
            if (listView1.SelectedItems[0].SubItems[1].Text == "Wait For Pixel")
            {
                
                pWindow.Show();
            }
            else
            {
                // Code here to edit parameters of existing actions
            }
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

        private void comboBox1_TextChanged(object sender, EventArgs e)
        { 
            repeatBox.Text = "1";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SAVE FILE

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Files (*.txt)|*.txt", ValidateNames = true })
            
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        tw.WriteLine(item.SubItems[0].Text + "\t" +
                            item.SubItems[1].Text + "\t" +
                            item.SubItems[2].Text + "\t" +
                            item.SubItems[3].Text + "\t" +
                            item.SubItems[4].Text + "\t" +
                            item.SubItems[5].Text + "\t" +
                            item.SubItems[6].Text + "\t" +
                            item.SubItems[7].Text + "\t" );

                    }
                }
            }

        }

        private void openScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OPEN SCRIPT

            OpenFileDialog ofd = new OpenFileDialog();
          ofd.Filter = "TXT files|*.txt";



            ofd.Title = "Load SmartMacro Script";
            var dialogResult = ofd.ShowDialog();

            if (!string.IsNullOrEmpty(ofd.FileName))
            {
                string filename = ofd.FileName;
                FileStream textFile = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader reader = new StreamReader(textFile);


                if (dialogResult == DialogResult.OK)
                {

                    string line = "";
                    string[] items;
                    ListViewItem listItem;

                    //While there are lines to read.
                    while ((line = reader.ReadLine()) != null)
                    {
                        items = line.Split('\t'); //Split the line.
                        listItem = new ListViewItem(); //"Row" object.

                        //For each item in the line.
                        for (int i = 0; i < items.Length; i++)
                        {
                            if (i == 0)
                            {
                                listItem.Text = items[i]; //First item is not a "subitem".
                            }
                            else
                            {
                                listItem.SubItems.Add(items[i]); //Add it to the "Row" object.
                            }
                        }

                        listView1.Items.Add(listItem); //Add the row object to the listview.
                    }


                } //end if

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void moveActionUp_Click(object sender, EventArgs e)
        {
            //Moves an item up in the list view

            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                if (lvi.Index > 0)
                {
                    lvi.SubItems[0].Text = (Int32.Parse(lvi.SubItems[0].Text)-1).ToString();
                    int index = lvi.Index - 1;
                    listView1.Items.RemoveAt(lvi.Index);
                    listView1.Items.Insert(index, lvi);

                    //This line handles the enumeration of elements in the listview
                    listView1.Items[lvi.Index+1].SubItems[0].Text = (Int32.Parse(listView1.Items[lvi.Index+1].SubItems[0].Text) + 1).ToString();
                }
            }
        } //end open file click

        private void moveActionDown_Click(object sender, EventArgs e)
        {
            //Moves an item down in the list view

            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                if (lvi.Index >= 0 && (lvi.Index + 1) < listView1.Items.Count)
                {
                    
                    lvi.SubItems[0].Text = (Int32.Parse(lvi.SubItems[0].Text) + 1).ToString();
                    int index = lvi.Index + 1;
                    listView1.Items.RemoveAt(lvi.Index);
                    listView1.Items.Insert(index, lvi);

                    //This line handles the enumeration of elements in the listview
                    listView1.Items[lvi.Index-1].SubItems[0].Text = (Int32.Parse(listView1.Items[lvi.Index-1].SubItems[0].Text) - 1).ToString();
                    
                }
            }
        }




    }        
}
