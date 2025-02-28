using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railes_move
{
    public partial class Replay : Form
    {
        public Replay()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void replay_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void excute_btn_Click(object sender, EventArgs e)
        {
            string filename = textBox1.Text;
            string dataFilePath = Path.Combine("C:\\Users\\LISA\\Desktop\\LIN\\data", filename); // 전체 경로로 변환

            try
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "python";
                start.Arguments = $"\"C:\\Users\\LISA\\Desktop\\LIN\\LIN_replayattack.py\" \"{dataFilePath}\"";
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                start.RedirectStandardError = true;

                using (Process process = new Process { StartInfo = start })
                {
                    process.Start();
                    string output = process.StandardOutput.ReadToEnd();
                    string errors = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    // 출력
                    if (string.IsNullOrEmpty(errors))
                    {
                        MessageBox.Show(output, "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to start Python script: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Replay_Load(object sender, EventArgs e)
        {

        }
    }
}
