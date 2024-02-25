namespace bilgiYarismasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            lblSoruNo = new Label();
            labelSoru = new Label();
            lblDogru = new Label();
            labelDogru = new Label();
            lblYanlıs = new Label();
            labelyanlıs = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSonraki = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(520, 211);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnA.Location = new Point(2, 219);
            btnA.Name = "btnA";
            btnA.Size = new Size(243, 42);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnB.Location = new Point(279, 219);
            btnB.Name = "btnB";
            btnB.Size = new Size(243, 42);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnC.Location = new Point(2, 289);
            btnC.Name = "btnC";
            btnC.Size = new Size(243, 42);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnD.Location = new Point(279, 289);
            btnD.Name = "btnD";
            btnD.Size = new Size(243, 42);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // lblSoruNo
            // 
            lblSoruNo.AutoSize = true;
            lblSoruNo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSoruNo.Location = new Point(601, 28);
            lblSoruNo.Name = "lblSoruNo";
            lblSoruNo.Size = new Size(82, 23);
            lblSoruNo.TabIndex = 5;
            lblSoruNo.Text = "Soru No :";
            // 
            // labelSoru
            // 
            labelSoru.AutoSize = true;
            labelSoru.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelSoru.Location = new Point(704, 28);
            labelSoru.Name = "labelSoru";
            labelSoru.Size = new Size(19, 23);
            labelSoru.TabIndex = 6;
            labelSoru.Text = "0";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblDogru.Location = new Point(601, 84);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(67, 23);
            lblDogru.TabIndex = 7;
            lblDogru.Text = "Doğru :";
            // 
            // labelDogru
            // 
            labelDogru.AutoSize = true;
            labelDogru.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelDogru.Location = new Point(703, 84);
            labelDogru.Name = "labelDogru";
            labelDogru.Size = new Size(19, 23);
            labelDogru.TabIndex = 8;
            labelDogru.Text = "0";
            // 
            // lblYanlıs
            // 
            lblYanlıs.AutoSize = true;
            lblYanlıs.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblYanlıs.Location = new Point(601, 140);
            lblYanlıs.Name = "lblYanlıs";
            lblYanlıs.Size = new Size(61, 23);
            lblYanlıs.TabIndex = 9;
            lblYanlıs.Text = "Yanlış :";
            // 
            // labelyanlıs
            // 
            labelyanlıs.AutoSize = true;
            labelyanlıs.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            labelyanlıs.Location = new Point(703, 140);
            labelyanlıs.Name = "labelyanlıs";
            labelyanlıs.Size = new Size(19, 23);
            labelyanlıs.TabIndex = 10;
            labelyanlıs.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(558, 219);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(704, 219);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 112);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // btnSonraki
            // 
            btnSonraki.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSonraki.Location = new Point(569, 170);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(243, 43);
            btnSonraki.TabIndex = 13;
            btnSonraki.Text = "Sonraki";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(860, 364);
            Controls.Add(btnSonraki);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelyanlıs);
            Controls.Add(lblYanlıs);
            Controls.Add(labelDogru);
            Controls.Add(lblDogru);
            Controls.Add(labelSoru);
            Controls.Add(lblSoruNo);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bilgi Yarışması";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label lblSoruNo;
        private Label labelSoru;
        private Label lblDogru;
        private Label labelDogru;
        private Label lblYanlıs;
        private Label labelyanlıs;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnSonraki;
    }
}
