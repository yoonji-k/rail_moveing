namespace Railes_move
{
    partial class Replay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            excute_btn = new Button();
            replay_close = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 32);
            label1.Name = "label1";
            label1.Size = new Size(237, 15);
            label1.TabIndex = 0;
            label1.Text = "Replay 파일명과 확장자명을 입력해주세요.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // excute_btn
            // 
            excute_btn.Location = new Point(190, 79);
            excute_btn.Name = "excute_btn";
            excute_btn.Size = new Size(75, 23);
            excute_btn.TabIndex = 2;
            excute_btn.Text = "실행";
            excute_btn.UseVisualStyleBackColor = true;
            excute_btn.Click += excute_btn_Click;
            // 
            // replay_close
            // 
            replay_close.Location = new Point(271, 79);
            replay_close.Name = "replay_close";
            replay_close.Size = new Size(75, 23);
            replay_close.TabIndex = 3;
            replay_close.Text = "닫기";
            replay_close.UseVisualStyleBackColor = true;
            replay_close.Click += replay_close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.replay_img;
            pictureBox1.Location = new Point(12, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Replay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 122);
            Controls.Add(pictureBox1);
            Controls.Add(replay_close);
            Controls.Add(excute_btn);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Replay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Replay";
            Load += Replay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button excute_btn;
        private Button replay_close;
        private PictureBox pictureBox1;
    }
}