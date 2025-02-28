using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railes_move
{
    public partial class Form2 : Form
    {
        private Process myProcess1;
        private Process myProcess2;
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ExecutePythonScript1();
        }

        private void ExecutePythonScript1()
        {
            ProcessStartInfo lincancollector = new ProcessStartInfo();
            lincancollector.FileName = "python";
            lincancollector.Arguments = string.Format("C:\\Users\\LISA\\Desktop\\LINCAN_final\\multiprocessing_final.py");
            lincancollector.UseShellExecute = false;
            lincancollector.RedirectStandardOutput = true;
            lincancollector.RedirectStandardInput = true;
            lincancollector.RedirectStandardError = true;
            lincancollector.CreateNoWindow = true;

            myProcess1 = new Process
            {
                StartInfo = lincancollector,
                EnableRaisingEvents = true
            };

            myProcess1.OutputDataReceived += (sender, args) =>
            {
                if (!string.IsNullOrEmpty(args.Data))
                {
                    if (args.Data.Contains("[CAN]"))
                    {
                        this.Invoke(new Action(() =>
                        {
                            richTextBox1.AppendText(args.Data + Environment.NewLine);
                        }));
                    }
                    else if (args.Data.Contains("[LIN]"))
                    {
                        this.Invoke(new Action(() =>
                        {
                            richTextBox2.AppendText(args.Data + Environment.NewLine);
                        }));
                    }
                    else if (args.Data.Contains("[Caution]"))
                    {
                        this.Invoke(new Action(() =>
                        {
                            richTextBox4.AppendText(args.Data + Environment.NewLine);
                        }));
                    }
                }
            };

            myProcess1.ErrorDataReceived += (sender, args) =>
            {
                if (!string.IsNullOrEmpty(args.Data))
                {
                    this.Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText("Error: " + args.Data + Environment.NewLine);
                    }));
                }
            };

            myProcess1.Exited += (sender, args) =>
            {
                this.Invoke(new Action(() =>
                {
                    richTextBox1.AppendText("Process exited." + Environment.NewLine);
                }));
            };

            myProcess1.Start();
            myProcess1.BeginOutputReadLine();
            myProcess1.BeginErrorReadLine();

        }

        private void ExecutePythonScript2()
        {
            ProcessStartInfo lijprint = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = "C:\\Users\\LISA\\Desktop\\LIN\\SOUL_injection.py",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            myProcess2 = new Process
            {
                StartInfo = lijprint,
                EnableRaisingEvents = true
            };

            myProcess2.OutputDataReceived += (s, args) =>
            {
                if (!string.IsNullOrEmpty(args.Data))
                {
                    if (args.Data.Contains("[LIJ]"))
                    {
                        this.Invoke(new Action(() =>
                        {
                            richTextBox3.AppendText(args.Data + Environment.NewLine);
                        }));
                    }
                }
            };

            myProcess2.ErrorDataReceived += (s, args) =>
            {
                if (!string.IsNullOrEmpty(args.Data))
                {
                    this.Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText("Error: " + args.Data + Environment.NewLine);
                    }));
                }
            };

            myProcess2.Exited += (s, args) =>
            {
                this.Invoke(new Action(() =>
                {
                    richTextBox3.AppendText("Process exited." + Environment.NewLine);
                }));
            };

            myProcess2.Start();
            myProcess2.BeginOutputReadLine();
            myProcess2.BeginErrorReadLine();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            stop_btn.Enabled = false;
            if (myProcess1 != null && !myProcess1.HasExited)
            {
                myProcess1.StandardInput.WriteLine("exit");
                //myProcess.WaitForExit();
                myProcess1.Close();
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.SelectionStart = richTextBox2.Text.Length;  // 텍스트 박스의 끝으로 커서 이동
            richTextBox2.ScrollToCaret();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            injection_btn.Enabled = false;
            ExecutePythonScript2();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            richTextBox3.SelectionStart = richTextBox3.Text.Length;  // 텍스트 박스의 끝으로 커서 이동
            richTextBox3.ScrollToCaret();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            richTextBox4.SelectionStart = richTextBox4.Text.Length;  // 텍스트 박스의 끝으로 커서 이동
            richTextBox4.ScrollToCaret();
        }

        private void stop_btn2_Click(object sender, EventArgs e)
        {
            stop_btn2.Enabled = false;
            if (myProcess2 != null && !myProcess2.HasExited)
            {
                myProcess2.StandardInput.WriteLine("exit");
                //myProcess.WaitForExit();
                myProcess2.Close();
            }
        }

        private void replay_btn_Click(object sender, EventArgs e)
        {
            Replay form3 = new Replay();
            form3.Show();
        }
    }
}
