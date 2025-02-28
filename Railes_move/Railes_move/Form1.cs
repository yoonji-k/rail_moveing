using System.IO.Ports;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

namespace Railes_move
{
    public partial class Form1 : Form
    {
        SerialPort port = new SerialPort();

        private bool messageShown = false;
        public Form1()
        {
            InitializeComponent();
            isChecked1(first_rail.Checked);
            isChecked2(second_rail.Checked);
            isChecked3(third_rail.Checked);
            isChecked4(fourth_rail.Checked);
            isChecked5(same_time.Checked);
            numericUpDown1.KeyUp += new KeyEventHandler(numericUpDown1_ValueChanged);
            numericUpDown2.KeyUp += new KeyEventHandler(numericUpDown2_ValueChanged);
            numericUpDown3.KeyUp += new KeyEventHandler(numericUpDown3_ValueChanged);
            numericUpDown4.KeyUp += new KeyEventHandler(numericUpDown4_ValueChanged);
            numericUpDown5.KeyUp += new KeyEventHandler(numericUpDown5_ValueChanged);
            string[] port = SerialPort.GetPortNames();
            foreach (string name in port)
            {
                combobox1.Items.Add(name);
            }
        }
        public void isChecked1(bool Checked)
        {
            if (Checked)
            {
                f_btn_30cm.Enabled = true;
                f_btn_60cm.Enabled = true;
                f_btn_82cm.Enabled = true;
                f_btn_input.Enabled = true;
                f_btn_reset.Enabled = true;
                richTextBox1.Text += "1번째 레일이 체크되었습니다." + Environment.NewLine;
            }

            else
            {
                f_btn_30cm.Enabled = false;
                f_btn_60cm.Enabled = false;
                f_btn_82cm.Enabled = false;
                f_btn_input.Enabled = false;
                f_btn_reset.Enabled = false;
                //richTextBox1.Text += "체크되어 있지 않습니다." + Environment.NewLine;
            }
        }
        public void isChecked2(bool Checked)
        {
            if (Checked)
            {
                s_btn_30cm.Enabled = true;
                s_btn_60cm.Enabled = true;
                s_btn_82cm.Enabled = true;
                s_btn_input.Enabled = true;
                s_btn_reset.Enabled = true;
                richTextBox1.Text += "2번째 레일이 체크되었습니다." + Environment.NewLine;
            }

            else
            {
                s_btn_30cm.Enabled = false;
                s_btn_60cm.Enabled = false;
                s_btn_82cm.Enabled = false;
                s_btn_input.Enabled = false;
                s_btn_reset.Enabled = false;
                //richTextBox1.Text += "체크되어 있지 않습니다." + Environment.NewLine;
            }
        }
        public void isChecked3(bool Checked)
        {
            if (Checked)
            {
                t_btn_30cm.Enabled = true;
                t_btn_60cm.Enabled = true;
                t_btn_82cm.Enabled = true;
                t_btn_input.Enabled = true;
                t_btn_reset.Enabled = true;
                richTextBox1.Text += "3번째 레일이 체크되었습니다." + Environment.NewLine;
            }

            else
            {
                t_btn_30cm.Enabled = false;
                t_btn_60cm.Enabled = false;
                t_btn_82cm.Enabled = false;
                t_btn_input.Enabled = false;
                t_btn_reset.Enabled = false;
                //richTextBox1.Text += "체크되어 있지 않습니다." + Environment.NewLine;
            }
        }

        public void isChecked4(bool Checked)
        {
            if (Checked)
            {
                four_btn_30cm.Enabled = true;
                four_btn_60cm.Enabled = true;
                four_btn_82cm.Enabled = true;
                four_btn_input.Enabled = true;
                four_btn_reset.Enabled = true;
                richTextBox1.Text += "4번째 레일이 체크되었습니다." + Environment.NewLine;
            }

            else
            {
                four_btn_30cm.Enabled = false;
                four_btn_60cm.Enabled = false;
                four_btn_82cm.Enabled = false;
                four_btn_input.Enabled = false;
                four_btn_reset.Enabled = false;
                //richTextBox1.Text += "체크되어 있지 않습니다." + Environment.NewLine;
            }
        }

        public void isChecked5(bool Checked)
        {
            if (Checked)
            {
                same_30cm.Enabled = true;
                same_60cm.Enabled = true;
                same_82cm.Enabled = true;
                same_input.Enabled = true;
                same_reset.Enabled = true;
                richTextBox1.Text += "동시 무브 모드 선택" + Environment.NewLine;
            }

            else
            {
                same_30cm.Enabled = false;
                same_60cm.Enabled = false;
                same_82cm.Enabled = false;
                same_input.Enabled = false;
                same_reset.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (port.IsOpen == false)
            {
                MessageBox.Show("포트를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text += "포트를 선택해주세요" + Environment.NewLine;
            }
            else if (port.IsOpen == true)
            {
                isChecked1(first_rail.Checked);
                same_time.Enabled = false;
                if (second_rail.Checked == false && first_rail.Checked == false && third_rail.Checked == false && fourth_rail.Checked == false)
                {
                    same_time.Enabled = true;
                }
                //port.Write("A");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Open_btn_Click(object sender, EventArgs e)
        {
            if (port.IsOpen == false)
            {
                port.PortName = combobox1.SelectedItem.ToString();
                port.BaudRate = 9600;
                port.DataBits = 8;
                port.StopBits = StopBits.One;
                port.Parity = Parity.None;
                port.Open();
                //MessageBox.Show("♥연결되었습니다♥", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Open_btn.Enabled = false;
                richTextBox1.Text += "성공적으로 연결하였습니다..." + Environment.NewLine;
                first_rail.Enabled = true;
                second_rail.Enabled = true;
                third_rail.Enabled = true;
                fourth_rail.Enabled = true;
                same_time.Enabled = true;
            }
            else
            {
                MessageBox.Show("포트를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text += "포트를 선택해주세요..." + Environment.NewLine;
            }
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            if (port.IsOpen == true)
            {
                port.Close();
                MessageBox.Show("해제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Open_btn.Enabled = true;
                richTextBox1.Text += "성공적으로 해제되었습니다..." + Environment.NewLine;
                DisableAllButtons();
            }
            else
            {
                //MessageBox.Show("♥해제되어 있습니다♥", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                richTextBox1.Text += "이미 해제되어 있습니다..." + Environment.NewLine;
            }
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 82 && !messageShown)
            {
                MessageBox.Show("최대길이는 82cm입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                messageShown = true;
            }

            else if (numericUpDown1.Value <= 82)
            {
                messageShown = false;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > 82 && !messageShown)
            {
                MessageBox.Show("최대길이는 82cm입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                messageShown = true;
            }

            else if (numericUpDown2.Value <= 82)
            {
                messageShown = false;
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > 82 && !messageShown)
            {
                MessageBox.Show("최대길이는 82cm입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                messageShown = true;
            }

            else if (numericUpDown3.Value <= 82)
            {
                messageShown = false;
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value > 82 && !messageShown)
            {
                MessageBox.Show("최대길이는 82cm입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                messageShown = true;
            }

            else if (numericUpDown4.Value <= 82)
            {
                messageShown = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void f_btn_30cm_Click(object sender, EventArgs e)
        {
            port.Write("A0");
            f_btn_30cm.Enabled = false;
            f_btn_60cm.Enabled = false;
            f_btn_82cm.Enabled = false;
            f_btn_input.Enabled = false;
            f_btn_reset.Enabled = true;
            richTextBox1.Text += "1번째 레일: 30cm 이동" + Environment.NewLine;
        }

        private void f_btn_60cm_Click(object sender, EventArgs e)
        {
            port.Write("A1");
            f_btn_30cm.Enabled = false;
            f_btn_60cm.Enabled = false;
            f_btn_82cm.Enabled = false;
            f_btn_input.Enabled = false;
            f_btn_reset.Enabled = true;
            richTextBox1.Text += "1번째 레일: 60cm 이동" + Environment.NewLine;
        }

        private void f_btn_82cm_Click(object sender, EventArgs e)
        {
            port.Write("A2");
            f_btn_30cm.Enabled = false;
            f_btn_60cm.Enabled = false;
            f_btn_82cm.Enabled = false;
            f_btn_input.Enabled = false;
            f_btn_reset.Enabled = true;
            richTextBox1.Text += "1번째 레일: 82cm 이동" + Environment.NewLine;
        }

        private void f_btn_input_Click(object sender, EventArgs e)
        {
            string value1 = numericUpDown1.Text;
            string revalue1 = "E" + value1.ToString();
            port.Write(revalue1);
            f_btn_30cm.Enabled = false;
            f_btn_60cm.Enabled = false;
            f_btn_82cm.Enabled = false;
            f_btn_input.Enabled = false;
            f_btn_reset.Enabled = true;
            richTextBox1.Text += "1번째 레일: " + value1 + "cm" + Environment.NewLine;
        }

        private void f_btn_reset_Click(object sender, EventArgs e)
        {
            port.Write("A3");
            f_btn_30cm.Enabled = true;
            f_btn_60cm.Enabled = true;
            f_btn_82cm.Enabled = true;
            f_btn_input.Enabled = true;
            f_btn_reset.Enabled = true;
            richTextBox1.Text += "1번째 레일: Reset 선택" + Environment.NewLine;
        }

        private void second_rail_CheckedChanged(object sender, EventArgs e)
        {
            if (port.IsOpen == false)
            {
                MessageBox.Show("포트를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text += "포트를 선택해주세요." + Environment.NewLine;
            }
            else if (port.IsOpen == true)
            {
                isChecked2(second_rail.Checked);
                same_time.Enabled = false;
                if (second_rail.Checked == false && first_rail.Checked == false && third_rail.Checked == false && fourth_rail.Checked == false)
                {
                    same_time.Enabled = true;
                }
            }
        }

        private void third_rail_CheckedChanged(object sender, EventArgs e)
        {
            if (port.IsOpen == false)
            {
                MessageBox.Show("포트를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text += "포트를 선택해주세요." + Environment.NewLine;
            }
            else if (port.IsOpen == true)
            {
                isChecked3(third_rail.Checked);
                same_time.Enabled = false;
                if (second_rail.Checked == false && first_rail.Checked == false && third_rail.Checked == false && fourth_rail.Checked == false)
                {
                    same_time.Enabled = true;
                }
            }
        }

        private void fourth_rail_CheckedChanged(object sender, EventArgs e)
        {
            if (port.IsOpen == false)
            {
                MessageBox.Show("포트를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text += "포트를 선택해주세요." + Environment.NewLine;
            }
            else if (port.IsOpen == true)
            {
                isChecked4(fourth_rail.Checked);
                same_time.Enabled = false;
                if (second_rail.Checked == false && first_rail.Checked == false && third_rail.Checked == false && fourth_rail.Checked == false)
                {
                    same_time.Enabled = true;
                }
            }

        }

        private void s_btn_30cm_Click(object sender, EventArgs e)
        {
            port.Write("B0");
            s_btn_30cm.Enabled = false;
            s_btn_60cm.Enabled = false;
            s_btn_82cm.Enabled = false;
            s_btn_input.Enabled = false;
            s_btn_reset.Enabled = true;
            richTextBox1.Text += "2번째 레일: 30cm 이동" + Environment.NewLine;
        }

        private void s_btn_60cm_Click(object sender, EventArgs e)
        {
            port.Write("B1");
            s_btn_30cm.Enabled = false;
            s_btn_60cm.Enabled = false;
            s_btn_82cm.Enabled = false;
            s_btn_input.Enabled = false;
            s_btn_reset.Enabled = true;
            richTextBox1.Text += "2번째 레일: 60cm 이동" + Environment.NewLine;
        }

        private void s_btn_82cm_Click(object sender, EventArgs e)
        {
            port.Write("B2");
            s_btn_30cm.Enabled = false;
            s_btn_60cm.Enabled = false;
            s_btn_82cm.Enabled = false;
            s_btn_input.Enabled = false;
            s_btn_reset.Enabled = true;
            richTextBox1.Text += "2번째 레일: 82cm 이동" + Environment.NewLine;
        }

        private void s_btn_input_Click(object sender, EventArgs e)
        {
            string value2 = numericUpDown2.Text;
            string realvalue2 = "F" + value2.ToString();
            port.Write(realvalue2);
            s_btn_30cm.Enabled = false;
            s_btn_60cm.Enabled = false;
            s_btn_82cm.Enabled = false;
            s_btn_input.Enabled = false;
            s_btn_reset.Enabled = true;
            richTextBox1.Text += "2번째 레일: " + value2 + "cm" + Environment.NewLine;
        }

        private void s_btn_reset_Click(object sender, EventArgs e)
        {
            port.Write("B3");
            s_btn_30cm.Enabled = true;
            s_btn_60cm.Enabled = true;
            s_btn_82cm.Enabled = true;
            s_btn_input.Enabled = true;
            s_btn_reset.Enabled = true;
            richTextBox1.Text += "2번째 레일: Reset 선택" + Environment.NewLine;
        }

        private void same_time_CheckedChanged(object sender, EventArgs e)
        {
            if (port.IsOpen == false)
            {
                MessageBox.Show("포트를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text += "포트를 선택해주세요." + Environment.NewLine;
            }
            else if (port.IsOpen == true)
            {
                isChecked5(same_time.Checked);
                first_rail.Enabled = false;
                second_rail.Enabled = false;
                third_rail.Enabled = false;
                fourth_rail.Enabled = false;

                if (same_time.Checked == false)
                {
                    first_rail.Enabled = true;
                    second_rail.Enabled = true;
                    third_rail.Enabled = true;
                    fourth_rail.Enabled = true;
                }
            }
        }

        private void same_30cm_Click(object sender, EventArgs e)
        {
            port.Write("K0");
            same_30cm.Enabled = false;
            same_60cm.Enabled = false;
            same_82cm.Enabled = false;
            same_input.Enabled = false;
            same_reset.Enabled = true;
            richTextBox1.Text += "모든 레일: 30cm 선택" + Environment.NewLine;
        }

        private void same_60cm_Click(object sender, EventArgs e)
        {
            port.Write("K1");
            same_30cm.Enabled = true;
            same_60cm.Enabled = false;
            same_82cm.Enabled = false;
            same_input.Enabled = false;
            same_reset.Enabled = true;
            richTextBox1.Text += "모든 레일: 60cm 선택" + Environment.NewLine;
        }

        private void same_82cm_Click(object sender, EventArgs e)
        {
            port.Write("K2");
            same_30cm.Enabled = true;
            same_60cm.Enabled = true;
            same_82cm.Enabled = false;
            same_input.Enabled = false;
            same_reset.Enabled = true;
            richTextBox1.Text += "모든 레일: 82cm 선택" + Environment.NewLine;
        }

        private void same_input_Click(object sender, EventArgs e)
        {
            string value5 = numericUpDown5.Text;
            string realvalue5 = "Y" + value5.ToString();
            port.Write(realvalue5);
            same_30cm.Enabled = false;
            same_60cm.Enabled = false;
            same_82cm.Enabled = false;
            same_input.Enabled = false;
            same_reset.Enabled = true;
            richTextBox1.Text += "모든 레일:" + value5 + "cm 선택" + Environment.NewLine;
        }

        private void same_reset_Click(object sender, EventArgs e)
        {
            port.Write("K3");
            same_30cm.Enabled = true;
            same_60cm.Enabled = true;
            same_82cm.Enabled = true;
            same_input.Enabled = true;
            same_reset.Enabled = true;
            richTextBox1.Text += "모든 레일: Reset 선택" + Environment.NewLine;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value > 82 && !messageShown)
            {
                MessageBox.Show("최대길이는 82cm입니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                messageShown = true;
            }

            else if (numericUpDown5.Value <= 82)
            {
                messageShown = false;
            }
        }

        private void Firstrail_Enter(object sender, EventArgs e)
        {

        }

        private void DisableAllButtons()
        {
            f_btn_30cm.Enabled = false;
            f_btn_60cm.Enabled = false;
            f_btn_82cm.Enabled = false;
            f_btn_input.Enabled = false;
            f_btn_reset.Enabled = false;

            s_btn_30cm.Enabled = false;
            s_btn_60cm.Enabled = false;
            s_btn_82cm.Enabled = false;
            s_btn_input.Enabled = false;
            s_btn_reset.Enabled = false;

            t_btn_30cm.Enabled = false;
            t_btn_60cm.Enabled = false;
            t_btn_82cm.Enabled = false;
            t_btn_input.Enabled = false;
            t_btn_reset.Enabled = false;

            four_btn_30cm.Enabled = false;
            four_btn_60cm.Enabled = false;
            four_btn_82cm.Enabled = false;
            four_btn_input.Enabled = false;
            four_btn_reset.Enabled = false;

            same_30cm.Enabled = false;
            same_60cm.Enabled = false;
            same_82cm.Enabled = false;
            same_input.Enabled = false;
            same_reset.Enabled = false;
        }

        private void t_btn_30cm_Click(object sender, EventArgs e)
        {
            port.Write("C0");
            t_btn_30cm.Enabled = false;
            t_btn_60cm.Enabled = false;
            t_btn_82cm.Enabled = false;
            t_btn_input.Enabled = false;
            t_btn_reset.Enabled = true;
            richTextBox1.Text += "3번째 레일: 30cm 이동" + Environment.NewLine;
        }

        private void t_btn_60cm_Click(object sender, EventArgs e)
        {
            port.Write("C1");
            t_btn_30cm.Enabled = false;
            t_btn_60cm.Enabled = false;
            t_btn_82cm.Enabled = false;
            t_btn_input.Enabled = false;
            t_btn_reset.Enabled = true;
            richTextBox1.Text += "3번째 레일: 60cm 이동" + Environment.NewLine;
        }

        private void t_btn_82cm_Click(object sender, EventArgs e)
        {
            port.Write("C2");
            t_btn_30cm.Enabled = false;
            t_btn_60cm.Enabled = false;
            t_btn_82cm.Enabled = false;
            t_btn_input.Enabled = false;
            t_btn_reset.Enabled = true;
            richTextBox1.Text += "3번째 레일: 82cm 이동" + Environment.NewLine;
        }

        private void t_btn_input_Click(object sender, EventArgs e)
        {
            string value3 = numericUpDown3.Text;
            string realvalue3 = "G" + value3.ToString();
            port.Write(realvalue3);
            t_btn_30cm.Enabled = false;
            t_btn_60cm.Enabled = false;
            t_btn_82cm.Enabled = false;
            t_btn_input.Enabled = false;
            t_btn_reset.Enabled = true;
            richTextBox1.Text += "3번째 레일: " + value3 + "cm" + Environment.NewLine;
        }

        private void t_btn_reset_Click(object sender, EventArgs e)
        {
            port.Write("C3");
            t_btn_30cm.Enabled = true;
            t_btn_60cm.Enabled = true;
            t_btn_82cm.Enabled = true;
            t_btn_input.Enabled = true;
            t_btn_reset.Enabled = true;
            richTextBox1.Text += "3번째 레일: Reset 선택" + Environment.NewLine;
        }

        private void four_btn_30cm_Click(object sender, EventArgs e)
        {
            port.Write("D0");
            four_btn_30cm.Enabled = false;
            four_btn_60cm.Enabled = false;
            four_btn_82cm.Enabled = false;
            four_btn_input.Enabled = false;
            four_btn_reset.Enabled = true;
            richTextBox1.Text += "4번째 레일: 30cm 이동" + Environment.NewLine;
        }

        private void four_btn_60cm_Click(object sender, EventArgs e)
        {
            port.Write("D1");
            four_btn_30cm.Enabled = false;
            four_btn_60cm.Enabled = false;
            four_btn_82cm.Enabled = false;
            four_btn_input.Enabled = false;
            four_btn_reset.Enabled = true;
            richTextBox1.Text += "4번째 레일: 60cm 이동" + Environment.NewLine;
        }

        private void four_btn_82cm_Click(object sender, EventArgs e)
        {
            port.Write("D2");
            four_btn_30cm.Enabled = false;
            four_btn_60cm.Enabled = false;
            four_btn_82cm.Enabled = false;
            four_btn_input.Enabled = false;
            four_btn_reset.Enabled = true;
            richTextBox1.Text += "4번째 레일: 82cm 이동" + Environment.NewLine;
        }

        private void four_btn_input_Click(object sender, EventArgs e)
        {
            string value4 = numericUpDown4.Text;
            string realvalue4 = "H" + value4.ToString();
            port.Write(realvalue4);
            t_btn_30cm.Enabled = false;
            t_btn_60cm.Enabled = false;
            t_btn_82cm.Enabled = false;
            t_btn_input.Enabled = false;
            t_btn_reset.Enabled = true;
            richTextBox1.Text += "4번째 레일: " + value4 + "cm" + Environment.NewLine;
        }

        private void four_btn_reset_Click(object sender, EventArgs e)
        {
            port.Write("D3");
            four_btn_30cm.Enabled = true;
            four_btn_60cm.Enabled = true;
            four_btn_82cm.Enabled = true;
            four_btn_input.Enabled = true;
            four_btn_reset.Enabled = true;
            richTextBox1.Text += "4번째 레일: Reset 선택" + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                client.Connect(IPAddress.Parse("127.0.0.1"), 6000);
                client.Send(Encoding.ASCII.GetBytes("wakeup"));
            }
            */
            if (port.IsOpen == false)
            {
                MessageBox.Show("포트를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text += "포트를 선택해주세요." + Environment.NewLine;
            }
            else if (port.IsOpen == true)
            {
                MessageBox.Show("[LIN] 네트워크가 활성화되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text += "[LIN] 네트워크가 활성화되었습니다." + Environment.NewLine;
                ProcessStartInfo pyDosAttack = new ProcessStartInfo();
                pyDosAttack.FileName = "python";
                pyDosAttack.Arguments = string.Format("C:\\Users\\LISA\\Desktop\\LINCAN_final\\CAN_dosattack.py");
                pyDosAttack.UseShellExecute = false;
                pyDosAttack.RedirectStandardOutput = true;
                pyDosAttack.RedirectStandardError = true;
                pyDosAttack.CreateNoWindow = true;

                Process process = Process.Start(pyDosAttack);
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (port.IsOpen == false)
            {
                MessageBox.Show("포트를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text += "포트를 선택해주세요." + Environment.NewLine;
            }
            else if (port.IsOpen == true)
            {
                port.Write("M"); 
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
        }

        private void form1_close_Click(object sender, EventArgs e)
        {
            if (port.IsOpen == false)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("포트를 닫고 다시 시도해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Text += "포트를 닫고 다시 시도해주세요" + Environment.NewLine;
            }
        }
    }
}
