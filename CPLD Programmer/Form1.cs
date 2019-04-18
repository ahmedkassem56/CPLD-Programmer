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
using System.IO;
using System.Threading; 

namespace CPLD_Programmer
{
    public partial class Form1 : Form
    {
        #region DLL Import
        [DllImport("helper.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public static extern int startProgramming(int compare, int verbose, [MarshalAs(UnmanagedType.LPStr)]String filename, [MarshalAs(UnmanagedType.LPStr)]String logname, [MarshalAs(UnmanagedType.LPStr)]String errname);
        #endregion

        static int sessionID;
        static string logName;
        static string errName; 
        static long logPosition = 0;
        static long errPosition = 0;

        System.Timers.Timer logTimer; 
        
        public Form1()
        {
            InitializeComponent();
        }

        public void InvokeUI(Action a)
        {
            this.BeginInvoke(new MethodInvoker(a));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    // MessageBox.Show("Please specify SVF file.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    statusLabel.BackColor = Color.IndianRed;
                    statusLabel.Text = "Please specify SVF file.";
                    return;
                }
                button1.Enabled = false;
                statusLabel.BackColor = Color.Silver;
                statusLabel.Text = "Programming in progress";

                int compareMode = compCheckBox.Checked ? 1 : 0;
                int verboseMode = verbCheckBox.Checked ? 1 : 0;

                sessionID = new Random().Next(1, 9999);
                logName = string.Format("log_{0}.txt", sessionID);
                errName = string.Format("err_{0}.txt", sessionID);

                try
                {
                    File.Delete(logName);
                    File.Delete(errName);
                }
                catch { }

                idLabel.Text = string.Format("Session ID:{0}", sessionID);

                logPosition = 0;
                errPosition = 0;

                logTimer.Enabled = true;
                int ret = startProgramming(compareMode, verboseMode, textBox1.Text, logName, errName);

                button1.Enabled = true;
            }
            catch (Exception ex)
            {
                button1.Enabled = false;
                statusLabel.BackColor = Color.IndianRed;
                statusLabel.Text = ex.Message;
            }
        }

        /* public void ReEnable()
         {
             Thread.Sleep(50);
             InvokeUI(() =>
             {
                 button1.Enabled = true;
             });
         }*/
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); 
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;

            logTimer = new System.Timers.Timer(20);
            logTimer.AutoReset = true;
            logTimer.Elapsed += LogTimer_Elapsed;

            statusLabel.BorderSides = ToolStripStatusLabelBorderSides.All;
            statusLabel.BorderStyle = Border3DStyle.Etched;
            statusStrip1.ShowItemToolTips = true;


            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;

        }

        private void LogTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            #region Error file
            try
            {
                using (var file = File.Open(errName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    //Console.WriteLine(file.Length);
                    if (errPosition != file.Length)
                    {
                        file.Position = errPosition;
                        using (var reader = new StreamReader(file))
                        {
                            string text = reader.ReadToEnd();
                            statusLabel.Text = text.Replace(Environment.NewLine,"");
                            statusLabel.BackColor = Color.IndianRed;
                            errPosition = file.Position;
                        }
                    }
                }
            }
            catch { }
            #endregion

            #region Log file
            try
            {
                using (var file = File.Open(logName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    if (logPosition != file.Length)
                    {
                        file.Position = logPosition;
                        using (var reader = new StreamReader(file))
                        {
                            string text = reader.ReadToEnd();
                            InvokeUI(() =>
                            {
                                logTxtBox.AppendText(text);
                            });
                            logPosition = file.Position;
                        }
                    }
                }
            }
            catch { }
            #endregion

            if (button1.Enabled) // this means that we have finished executing. No need to keep the timer running
            {
                if (deleteCheckBox.Checked) // delete log files
                {
                    File.Delete(errName);
                    File.Delete(logName); 
                }

                logTimer.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logTxtBox.Text = "";
        }
    }
    
}
