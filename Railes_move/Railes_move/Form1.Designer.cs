namespace Railes_move
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            first_rail = new CheckBox();
            portset = new GroupBox();
            Close_btn = new Button();
            Open_btn = new Button();
            label1 = new Label();
            combobox1 = new ComboBox();
            f_btn_30cm = new Button();
            f_btn_60cm = new Button();
            f_btn_82cm = new Button();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            f_btn_input = new Button();
            f_btn_reset = new Button();
            Firstrail = new GroupBox();
            groupBox1 = new GroupBox();
            second_rail = new CheckBox();
            s_btn_30cm = new Button();
            s_btn_60cm = new Button();
            s_btn_82cm = new Button();
            s_btn_input = new Button();
            s_btn_reset = new Button();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            groupBox2 = new GroupBox();
            third_rail = new CheckBox();
            t_btn_30cm = new Button();
            t_btn_60cm = new Button();
            t_btn_82cm = new Button();
            t_btn_input = new Button();
            t_btn_reset = new Button();
            numericUpDown3 = new NumericUpDown();
            label4 = new Label();
            groupBox3 = new GroupBox();
            fourth_rail = new CheckBox();
            four_btn_30cm = new Button();
            four_btn_60cm = new Button();
            four_btn_82cm = new Button();
            four_btn_input = new Button();
            four_btn_reset = new Button();
            numericUpDown4 = new NumericUpDown();
            label5 = new Label();
            groupBox4 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox5 = new GroupBox();
            same_time = new CheckBox();
            same_30cm = new Button();
            same_60cm = new Button();
            same_82cm = new Button();
            same_input = new Button();
            same_reset = new Button();
            numericUpDown5 = new NumericUpDown();
            label6 = new Label();
            button1 = new Button();
            start_btn = new Button();
            form1_close = new Button();
            portset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            Firstrail.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            SuspendLayout();
            // 
            // first_rail
            // 
            first_rail.AutoSize = true;
            first_rail.Location = new Point(7, 27);
            first_rail.Margin = new Padding(2);
            first_rail.Name = "first_rail";
            first_rail.Size = new Size(71, 19);
            first_rail.TabIndex = 0;
            first_rail.Text = "First Rail";
            first_rail.UseVisualStyleBackColor = true;
            first_rail.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // portset
            // 
            portset.Controls.Add(Close_btn);
            portset.Controls.Add(Open_btn);
            portset.Controls.Add(label1);
            portset.Controls.Add(combobox1);
            portset.Location = new Point(246, 9);
            portset.Margin = new Padding(2);
            portset.Name = "portset";
            portset.Padding = new Padding(2);
            portset.Size = new Size(352, 61);
            portset.TabIndex = 1;
            portset.TabStop = false;
            portset.Text = "포트 설정";
            // 
            // Close_btn
            // 
            Close_btn.Location = new Point(269, 26);
            Close_btn.Margin = new Padding(2);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(72, 22);
            Close_btn.TabIndex = 3;
            Close_btn.Text = "해제";
            Close_btn.UseVisualStyleBackColor = true;
            Close_btn.Click += Close_btn_Click;
            // 
            // Open_btn
            // 
            Open_btn.Location = new Point(193, 26);
            Open_btn.Margin = new Padding(2);
            Open_btn.Name = "Open_btn";
            Open_btn.Size = new Size(72, 22);
            Open_btn.TabIndex = 2;
            Open_btn.Text = "연결";
            Open_btn.UseVisualStyleBackColor = true;
            Open_btn.Click += Open_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "COM :";
            // 
            // combobox1
            // 
            combobox1.FormattingEnabled = true;
            combobox1.Location = new Point(61, 26);
            combobox1.Margin = new Padding(2);
            combobox1.Name = "combobox1";
            combobox1.Size = new Size(118, 23);
            combobox1.TabIndex = 0;
            combobox1.SelectedIndexChanged += combobox1_SelectedIndexChanged;
            // 
            // f_btn_30cm
            // 
            f_btn_30cm.Location = new Point(9, 52);
            f_btn_30cm.Margin = new Padding(2);
            f_btn_30cm.Name = "f_btn_30cm";
            f_btn_30cm.Size = new Size(140, 32);
            f_btn_30cm.TabIndex = 2;
            f_btn_30cm.Text = "30cm";
            f_btn_30cm.UseVisualStyleBackColor = true;
            f_btn_30cm.Click += f_btn_30cm_Click;
            // 
            // f_btn_60cm
            // 
            f_btn_60cm.Location = new Point(9, 89);
            f_btn_60cm.Margin = new Padding(2);
            f_btn_60cm.Name = "f_btn_60cm";
            f_btn_60cm.Size = new Size(140, 32);
            f_btn_60cm.TabIndex = 3;
            f_btn_60cm.Text = "60cm";
            f_btn_60cm.UseVisualStyleBackColor = true;
            f_btn_60cm.Click += f_btn_60cm_Click;
            // 
            // f_btn_82cm
            // 
            f_btn_82cm.Location = new Point(9, 126);
            f_btn_82cm.Margin = new Padding(2);
            f_btn_82cm.Name = "f_btn_82cm";
            f_btn_82cm.Size = new Size(140, 32);
            f_btn_82cm.TabIndex = 4;
            f_btn_82cm.Text = "82cm";
            f_btn_82cm.UseVisualStyleBackColor = true;
            f_btn_82cm.Click += f_btn_82cm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 165);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Value";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(44, 164);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(53, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // f_btn_input
            // 
            f_btn_input.Location = new Point(102, 163);
            f_btn_input.Margin = new Padding(2);
            f_btn_input.Name = "f_btn_input";
            f_btn_input.Size = new Size(47, 22);
            f_btn_input.TabIndex = 7;
            f_btn_input.Text = "입력";
            f_btn_input.UseVisualStyleBackColor = true;
            f_btn_input.Click += f_btn_input_Click;
            // 
            // f_btn_reset
            // 
            f_btn_reset.Location = new Point(9, 190);
            f_btn_reset.Margin = new Padding(2);
            f_btn_reset.Name = "f_btn_reset";
            f_btn_reset.Size = new Size(140, 32);
            f_btn_reset.TabIndex = 8;
            f_btn_reset.Text = "Reset";
            f_btn_reset.UseVisualStyleBackColor = true;
            f_btn_reset.Click += f_btn_reset_Click;
            // 
            // Firstrail
            // 
            Firstrail.Controls.Add(f_btn_30cm);
            Firstrail.Controls.Add(f_btn_60cm);
            Firstrail.Controls.Add(f_btn_82cm);
            Firstrail.Controls.Add(f_btn_input);
            Firstrail.Controls.Add(f_btn_reset);
            Firstrail.Controls.Add(numericUpDown1);
            Firstrail.Controls.Add(first_rail);
            Firstrail.Controls.Add(label2);
            Firstrail.Location = new Point(9, 74);
            Firstrail.Margin = new Padding(2);
            Firstrail.Name = "Firstrail";
            Firstrail.Padding = new Padding(2);
            Firstrail.Size = new Size(158, 228);
            Firstrail.TabIndex = 9;
            Firstrail.TabStop = false;
            Firstrail.Text = "1st Rail";
            Firstrail.Enter += Firstrail_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(second_rail);
            groupBox1.Controls.Add(s_btn_30cm);
            groupBox1.Controls.Add(s_btn_60cm);
            groupBox1.Controls.Add(s_btn_82cm);
            groupBox1.Controls.Add(s_btn_input);
            groupBox1.Controls.Add(s_btn_reset);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(172, 74);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(158, 228);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "2nd Rail";
            // 
            // second_rail
            // 
            second_rail.AutoSize = true;
            second_rail.Location = new Point(7, 27);
            second_rail.Margin = new Padding(2);
            second_rail.Name = "second_rail";
            second_rail.Size = new Size(89, 19);
            second_rail.TabIndex = 9;
            second_rail.Text = "Second Rail";
            second_rail.UseVisualStyleBackColor = true;
            second_rail.CheckedChanged += second_rail_CheckedChanged;
            // 
            // s_btn_30cm
            // 
            s_btn_30cm.Location = new Point(9, 52);
            s_btn_30cm.Margin = new Padding(2);
            s_btn_30cm.Name = "s_btn_30cm";
            s_btn_30cm.Size = new Size(140, 32);
            s_btn_30cm.TabIndex = 2;
            s_btn_30cm.Text = "30cm";
            s_btn_30cm.UseVisualStyleBackColor = true;
            s_btn_30cm.Click += s_btn_30cm_Click;
            // 
            // s_btn_60cm
            // 
            s_btn_60cm.Location = new Point(9, 89);
            s_btn_60cm.Margin = new Padding(2);
            s_btn_60cm.Name = "s_btn_60cm";
            s_btn_60cm.Size = new Size(140, 32);
            s_btn_60cm.TabIndex = 3;
            s_btn_60cm.Text = "60cm";
            s_btn_60cm.UseVisualStyleBackColor = true;
            s_btn_60cm.Click += s_btn_60cm_Click;
            // 
            // s_btn_82cm
            // 
            s_btn_82cm.Location = new Point(9, 126);
            s_btn_82cm.Margin = new Padding(2);
            s_btn_82cm.Name = "s_btn_82cm";
            s_btn_82cm.Size = new Size(140, 32);
            s_btn_82cm.TabIndex = 4;
            s_btn_82cm.Text = "82cm";
            s_btn_82cm.UseVisualStyleBackColor = true;
            s_btn_82cm.Click += s_btn_82cm_Click;
            // 
            // s_btn_input
            // 
            s_btn_input.Location = new Point(102, 163);
            s_btn_input.Margin = new Padding(2);
            s_btn_input.Name = "s_btn_input";
            s_btn_input.Size = new Size(47, 22);
            s_btn_input.TabIndex = 7;
            s_btn_input.Text = "입력";
            s_btn_input.UseVisualStyleBackColor = true;
            s_btn_input.Click += s_btn_input_Click;
            // 
            // s_btn_reset
            // 
            s_btn_reset.Location = new Point(9, 190);
            s_btn_reset.Margin = new Padding(2);
            s_btn_reset.Name = "s_btn_reset";
            s_btn_reset.Size = new Size(140, 32);
            s_btn_reset.TabIndex = 8;
            s_btn_reset.Text = "Reset";
            s_btn_reset.UseVisualStyleBackColor = true;
            s_btn_reset.Click += s_btn_reset_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(44, 164);
            numericUpDown2.Margin = new Padding(2);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(53, 23);
            numericUpDown2.TabIndex = 6;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 165);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Value";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(third_rail);
            groupBox2.Controls.Add(t_btn_30cm);
            groupBox2.Controls.Add(t_btn_60cm);
            groupBox2.Controls.Add(t_btn_82cm);
            groupBox2.Controls.Add(t_btn_input);
            groupBox2.Controls.Add(t_btn_reset);
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(334, 74);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(158, 228);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "3rd Rail";
            // 
            // third_rail
            // 
            third_rail.AutoSize = true;
            third_rail.Location = new Point(7, 27);
            third_rail.Margin = new Padding(2);
            third_rail.Name = "third_rail";
            third_rail.Size = new Size(76, 19);
            third_rail.TabIndex = 10;
            third_rail.Text = "Third Rail";
            third_rail.UseVisualStyleBackColor = true;
            third_rail.CheckedChanged += third_rail_CheckedChanged;
            // 
            // t_btn_30cm
            // 
            t_btn_30cm.Location = new Point(9, 52);
            t_btn_30cm.Margin = new Padding(2);
            t_btn_30cm.Name = "t_btn_30cm";
            t_btn_30cm.Size = new Size(140, 32);
            t_btn_30cm.TabIndex = 2;
            t_btn_30cm.Text = "30cm";
            t_btn_30cm.UseVisualStyleBackColor = true;
            t_btn_30cm.Click += t_btn_30cm_Click;
            // 
            // t_btn_60cm
            // 
            t_btn_60cm.Location = new Point(9, 89);
            t_btn_60cm.Margin = new Padding(2);
            t_btn_60cm.Name = "t_btn_60cm";
            t_btn_60cm.Size = new Size(140, 32);
            t_btn_60cm.TabIndex = 3;
            t_btn_60cm.Text = "60cm";
            t_btn_60cm.UseVisualStyleBackColor = true;
            t_btn_60cm.Click += t_btn_60cm_Click;
            // 
            // t_btn_82cm
            // 
            t_btn_82cm.Location = new Point(9, 126);
            t_btn_82cm.Margin = new Padding(2);
            t_btn_82cm.Name = "t_btn_82cm";
            t_btn_82cm.Size = new Size(140, 32);
            t_btn_82cm.TabIndex = 4;
            t_btn_82cm.Text = "82cm";
            t_btn_82cm.UseVisualStyleBackColor = true;
            t_btn_82cm.Click += t_btn_82cm_Click;
            // 
            // t_btn_input
            // 
            t_btn_input.Location = new Point(102, 163);
            t_btn_input.Margin = new Padding(2);
            t_btn_input.Name = "t_btn_input";
            t_btn_input.Size = new Size(47, 22);
            t_btn_input.TabIndex = 7;
            t_btn_input.Text = "입력";
            t_btn_input.UseVisualStyleBackColor = true;
            t_btn_input.Click += t_btn_input_Click;
            // 
            // t_btn_reset
            // 
            t_btn_reset.Location = new Point(9, 190);
            t_btn_reset.Margin = new Padding(2);
            t_btn_reset.Name = "t_btn_reset";
            t_btn_reset.Size = new Size(140, 32);
            t_btn_reset.TabIndex = 8;
            t_btn_reset.Text = "Reset";
            t_btn_reset.UseVisualStyleBackColor = true;
            t_btn_reset.Click += t_btn_reset_Click;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(44, 164);
            numericUpDown3.Margin = new Padding(2);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(53, 23);
            numericUpDown3.TabIndex = 6;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 165);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 5;
            label4.Text = "Value";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(fourth_rail);
            groupBox3.Controls.Add(four_btn_30cm);
            groupBox3.Controls.Add(four_btn_60cm);
            groupBox3.Controls.Add(four_btn_82cm);
            groupBox3.Controls.Add(four_btn_input);
            groupBox3.Controls.Add(four_btn_reset);
            groupBox3.Controls.Add(numericUpDown4);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(497, 74);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(158, 228);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "4th Rail";
            // 
            // fourth_rail
            // 
            fourth_rail.AutoSize = true;
            fourth_rail.Location = new Point(7, 27);
            fourth_rail.Margin = new Padding(2);
            fourth_rail.Name = "fourth_rail";
            fourth_rail.Size = new Size(84, 19);
            fourth_rail.TabIndex = 11;
            fourth_rail.Text = "Fourth Rail";
            fourth_rail.UseVisualStyleBackColor = true;
            fourth_rail.CheckedChanged += fourth_rail_CheckedChanged;
            // 
            // four_btn_30cm
            // 
            four_btn_30cm.Location = new Point(9, 52);
            four_btn_30cm.Margin = new Padding(2);
            four_btn_30cm.Name = "four_btn_30cm";
            four_btn_30cm.Size = new Size(140, 32);
            four_btn_30cm.TabIndex = 2;
            four_btn_30cm.Text = "30cm";
            four_btn_30cm.UseVisualStyleBackColor = true;
            four_btn_30cm.Click += four_btn_30cm_Click;
            // 
            // four_btn_60cm
            // 
            four_btn_60cm.Location = new Point(9, 89);
            four_btn_60cm.Margin = new Padding(2);
            four_btn_60cm.Name = "four_btn_60cm";
            four_btn_60cm.Size = new Size(140, 32);
            four_btn_60cm.TabIndex = 3;
            four_btn_60cm.Text = "60cm";
            four_btn_60cm.UseVisualStyleBackColor = true;
            four_btn_60cm.Click += four_btn_60cm_Click;
            // 
            // four_btn_82cm
            // 
            four_btn_82cm.Location = new Point(9, 126);
            four_btn_82cm.Margin = new Padding(2);
            four_btn_82cm.Name = "four_btn_82cm";
            four_btn_82cm.Size = new Size(140, 32);
            four_btn_82cm.TabIndex = 4;
            four_btn_82cm.Text = "82cm";
            four_btn_82cm.UseVisualStyleBackColor = true;
            four_btn_82cm.Click += four_btn_82cm_Click;
            // 
            // four_btn_input
            // 
            four_btn_input.Location = new Point(102, 163);
            four_btn_input.Margin = new Padding(2);
            four_btn_input.Name = "four_btn_input";
            four_btn_input.Size = new Size(47, 22);
            four_btn_input.TabIndex = 7;
            four_btn_input.Text = "입력";
            four_btn_input.UseVisualStyleBackColor = true;
            four_btn_input.Click += four_btn_input_Click;
            // 
            // four_btn_reset
            // 
            four_btn_reset.Location = new Point(9, 190);
            four_btn_reset.Margin = new Padding(2);
            four_btn_reset.Name = "four_btn_reset";
            four_btn_reset.Size = new Size(140, 32);
            four_btn_reset.TabIndex = 8;
            four_btn_reset.Text = "Reset";
            four_btn_reset.UseVisualStyleBackColor = true;
            four_btn_reset.Click += four_btn_reset_Click;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(44, 164);
            numericUpDown4.Margin = new Padding(2);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(53, 23);
            numericUpDown4.TabIndex = 6;
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 165);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 5;
            label5.Text = "Value";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(richTextBox1);
            groupBox4.Location = new Point(9, 305);
            groupBox4.Margin = new Padding(2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2);
            groupBox4.Size = new Size(808, 115);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Status";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(5, 18);
            richTextBox1.Margin = new Padding(2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 126);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(same_time);
            groupBox5.Controls.Add(same_30cm);
            groupBox5.Controls.Add(same_60cm);
            groupBox5.Controls.Add(same_82cm);
            groupBox5.Controls.Add(same_input);
            groupBox5.Controls.Add(same_reset);
            groupBox5.Controls.Add(numericUpDown5);
            groupBox5.Controls.Add(label6);
            groupBox5.Location = new Point(660, 74);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(158, 228);
            groupBox5.TabIndex = 13;
            groupBox5.TabStop = false;
            groupBox5.Text = "동시작동";
            // 
            // same_time
            // 
            same_time.AutoSize = true;
            same_time.Location = new Point(7, 27);
            same_time.Margin = new Padding(2);
            same_time.Name = "same_time";
            same_time.Size = new Size(84, 19);
            same_time.TabIndex = 11;
            same_time.Text = "Same time";
            same_time.UseVisualStyleBackColor = true;
            same_time.CheckedChanged += same_time_CheckedChanged;
            // 
            // same_30cm
            // 
            same_30cm.Location = new Point(9, 52);
            same_30cm.Margin = new Padding(2);
            same_30cm.Name = "same_30cm";
            same_30cm.Size = new Size(140, 32);
            same_30cm.TabIndex = 2;
            same_30cm.Text = "30cm";
            same_30cm.UseVisualStyleBackColor = true;
            same_30cm.Click += same_30cm_Click;
            // 
            // same_60cm
            // 
            same_60cm.Location = new Point(9, 89);
            same_60cm.Margin = new Padding(2);
            same_60cm.Name = "same_60cm";
            same_60cm.Size = new Size(140, 32);
            same_60cm.TabIndex = 3;
            same_60cm.Text = "60cm";
            same_60cm.UseVisualStyleBackColor = true;
            same_60cm.Click += same_60cm_Click;
            // 
            // same_82cm
            // 
            same_82cm.Location = new Point(9, 126);
            same_82cm.Margin = new Padding(2);
            same_82cm.Name = "same_82cm";
            same_82cm.Size = new Size(140, 32);
            same_82cm.TabIndex = 4;
            same_82cm.Text = "82cm";
            same_82cm.UseVisualStyleBackColor = true;
            same_82cm.Click += same_82cm_Click;
            // 
            // same_input
            // 
            same_input.Location = new Point(102, 163);
            same_input.Margin = new Padding(2);
            same_input.Name = "same_input";
            same_input.Size = new Size(47, 22);
            same_input.TabIndex = 7;
            same_input.Text = "입력";
            same_input.UseVisualStyleBackColor = true;
            same_input.Click += same_input_Click;
            // 
            // same_reset
            // 
            same_reset.Location = new Point(9, 190);
            same_reset.Margin = new Padding(2);
            same_reset.Name = "same_reset";
            same_reset.Size = new Size(140, 32);
            same_reset.TabIndex = 8;
            same_reset.Text = "Reset";
            same_reset.UseVisualStyleBackColor = true;
            same_reset.Click += same_reset_Click;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(44, 164);
            numericUpDown5.Margin = new Padding(2);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(53, 23);
            numericUpDown5.TabIndex = 6;
            numericUpDown5.ValueChanged += numericUpDown5_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 165);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 5;
            label6.Text = "Value";
            // 
            // button1
            // 
            button1.Location = new Point(631, 33);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Wakeup";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // start_btn
            // 
            start_btn.Location = new Point(712, 33);
            start_btn.Name = "start_btn";
            start_btn.Size = new Size(75, 23);
            start_btn.TabIndex = 15;
            start_btn.Text = "Start";
            start_btn.UseVisualStyleBackColor = true;
            start_btn.Click += start_btn_Click;
            // 
            // form1_close
            // 
            form1_close.Location = new Point(739, 426);
            form1_close.Name = "form1_close";
            form1_close.Size = new Size(75, 23);
            form1_close.TabIndex = 16;
            form1_close.Text = "닫기";
            form1_close.UseVisualStyleBackColor = true;
            form1_close.Click += form1_close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 460);
            Controls.Add(form1_close);
            Controls.Add(start_btn);
            Controls.Add(button1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(portset);
            Controls.Add(Firstrail);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rails Move!";
            Load += Form1_Load;
            portset.ResumeLayout(false);
            portset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            Firstrail.ResumeLayout(false);
            Firstrail.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CheckBox first_rail;
        private GroupBox portset;
        private Button Close_btn;
        private Button Open_btn;
        private Label label1;
        private ComboBox combobox1;
        private Button f_btn_30cm;
        private Button f_btn_60cm;
        private Button f_btn_82cm;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button f_btn_input;
        private Button f_btn_reset;
        private GroupBox Firstrail;
        private GroupBox groupBox1;
        private Button s_btn_30cm;
        private Button s_btn_60cm;
        private Button s_btn_82cm;
        private Button s_btn_input;
        private Button s_btn_reset;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private GroupBox groupBox2;
        private Button t_btn_30cm;
        private Button t_btn_60cm;
        private Button t_btn_82cm;
        private Button t_btn_input;
        private Button t_btn_reset;
        private NumericUpDown numericUpDown3;
        private Label label4;
        private GroupBox groupBox3;
        private Button four_btn_30cm;
        private Button four_btn_60cm;
        private Button four_btn_82cm;
        private Button four_btn_input;
        private Button four_btn_reset;
        private NumericUpDown numericUpDown4;
        private Label label5;
        private GroupBox groupBox4;
        private RichTextBox richTextBox1;
        private CheckBox second_rail;
        private CheckBox third_rail;
        private CheckBox fourth_rail;
        private GroupBox groupBox5;
        private CheckBox same_time;
        private Button same_30cm;
        private Button same_60cm;
        private Button same_82cm;
        private Button same_input;
        private Button same_reset;
        private NumericUpDown numericUpDown5;
        private Label label6;
        private Button button1;
        private Button start_btn;
        private Button form1_close;
    }
}
