namespace Parti_Secim_Anketi
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbx_ilce = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btn_oy = new Button();
            btn_cikis = new Button();
            btn_grafikler = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 32);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "İLÇE ADI :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 111);
            label2.Name = "label2";
            label2.Size = new Size(191, 28);
            label2.TabIndex = 1;
            label2.Text = "A PARTİ OY SAYISI :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 149);
            label3.Name = "label3";
            label3.Size = new Size(190, 28);
            label3.TabIndex = 2;
            label3.Text = "B PARTİ OY SAYISI :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 187);
            label4.Name = "label4";
            label4.Size = new Size(190, 28);
            label4.TabIndex = 3;
            label4.Text = "C PARTİ OY SAYISI :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 225);
            label5.Name = "label5";
            label5.Size = new Size(192, 28);
            label5.TabIndex = 4;
            label5.Text = "D PARTİ OY SAYISI :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 263);
            label6.Name = "label6";
            label6.Size = new Size(188, 28);
            label6.TabIndex = 5;
            label6.Text = "E PARTİ OY SAYISI :";
            // 
            // tbx_ilce
            // 
            tbx_ilce.Location = new Point(173, 29);
            tbx_ilce.Name = "tbx_ilce";
            tbx_ilce.Size = new Size(246, 34);
            tbx_ilce.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(255, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 34);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(255, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 34);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(255, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 34);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(255, 226);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 34);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(255, 266);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(165, 34);
            textBox5.TabIndex = 11;
            // 
            // btn_oy
            // 
            btn_oy.Location = new Point(58, 310);
            btn_oy.Name = "btn_oy";
            btn_oy.Size = new Size(362, 64);
            btn_oy.TabIndex = 13;
            btn_oy.Text = "OY GİRİŞİ";
            btn_oy.UseVisualStyleBackColor = true;
            btn_oy.Click += btn_oy_Click;
            // 
            // btn_cikis
            // 
            btn_cikis.Location = new Point(255, 385);
            btn_cikis.Name = "btn_cikis";
            btn_cikis.Size = new Size(164, 59);
            btn_cikis.TabIndex = 14;
            btn_cikis.Text = "ÇıkışYap";
            btn_cikis.UseVisualStyleBackColor = true;
            btn_cikis.Click += btn_cikis_Click;
            // 
            // btn_grafikler
            // 
            btn_grafikler.Location = new Point(58, 385);
            btn_grafikler.Name = "btn_grafikler";
            btn_grafikler.Size = new Size(164, 59);
            btn_grafikler.TabIndex = 15;
            btn_grafikler.Text = "Grafikler";
            btn_grafikler.UseVisualStyleBackColor = true;
            btn_grafikler.Click += btn_grafikler_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(462, 470);
            Controls.Add(btn_grafikler);
            Controls.Add(btn_cikis);
            Controls.Add(btn_oy);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(tbx_ilce);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "OY SEÇİM SİSTEMİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbx_ilce;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btn_oy;
        private Button btn_cikis;
        private Button btn_grafikler;
    }
}