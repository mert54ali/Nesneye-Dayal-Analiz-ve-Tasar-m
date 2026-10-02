<<<<<<< HEAD
﻿namespace tasarimproje
{
    partial class Form1
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            textBox3 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            btnCancel = new Button();
            btnCompositeTest = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(78, 172);
            button1.Name = "button1";
            button1.Size = new Size(204, 25);
            button1.TabIndex = 0;
            button1.Text = "Siparişi Oluştur";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(148, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 25);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "MNG Kargo", "Aras Kargo", "Yurtiçi Kargo" });
            comboBox2.Location = new Point(148, 45);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(134, 25);
            comboBox2.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(25, 225);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(516, 181);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 4;
            label1.Text = "Ödeme Yöntemi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 45);
            label2.Name = "label2";
            label2.Size = new Size(85, 17);
            label2.TabIndex = 5;
            label2.Text = "Kargo Seçimi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 25);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 25);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 82);
            label3.Name = "label3";
            label3.Size = new Size(112, 17);
            label3.TabIndex = 8;
            label3.Text = "Sipariş Tutarı (TL):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 113);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 9;
            label4.Text = "Ağırlık (KG):";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 145);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(238, 21);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Hediye Paketi / Sigorta İster misiniz?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(415, 42);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 25);
            textBox3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 45);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 12;
            label5.Text = "Ürün Adı:";
            // 
            // button2
            // 
            button2.Location = new Point(343, 81);
            button2.Name = "button2";
            button2.Size = new Size(198, 25);
            button2.TabIndex = 13;
            button2.Text = "Sipariş Durumunu İlerlet";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(343, 130);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(198, 25);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Siparişi İptal Et / İade Et";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCompositeTest
            // 
            btnCompositeTest.Location = new Point(343, 172);
            btnCompositeTest.Name = "btnCompositeTest";
            btnCompositeTest.Size = new Size(198, 25);
            btnCompositeTest.TabIndex = 15;
            btnCompositeTest.Text = "Montajlı Ürün";
            btnCompositeTest.UseVisualStyleBackColor = true;
            btnCompositeTest.Click += btnCompositeTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 450);
            Controls.Add(btnCompositeTest);
            Controls.Add(btnCancel);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private Label label5;
        private Button button2;
        private Button btnCancel;
        private Button btnCompositeTest;
    }
=======
﻿namespace tasarimproje
{
    partial class Form1
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            textBox3 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            btnCancel = new Button();
            btnCompositeTest = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(78, 172);
            button1.Name = "button1";
            button1.Size = new Size(204, 25);
            button1.TabIndex = 0;
            button1.Text = "Siparişi Oluştur";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(148, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 25);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "MNG Kargo", "Aras Kargo", "Yurtiçi Kargo" });
            comboBox2.Location = new Point(148, 45);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(134, 25);
            comboBox2.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(25, 225);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(516, 181);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 4;
            label1.Text = "Ödeme Yöntemi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 45);
            label2.Name = "label2";
            label2.Size = new Size(85, 17);
            label2.TabIndex = 5;
            label2.Text = "Kargo Seçimi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 25);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 25);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 82);
            label3.Name = "label3";
            label3.Size = new Size(112, 17);
            label3.TabIndex = 8;
            label3.Text = "Sipariş Tutarı (TL):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 113);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 9;
            label4.Text = "Ağırlık (KG):";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 145);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(238, 21);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Hediye Paketi / Sigorta İster misiniz?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(415, 42);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 25);
            textBox3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 45);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 12;
            label5.Text = "Ürün Adı:";
            // 
            // button2
            // 
            button2.Location = new Point(343, 81);
            button2.Name = "button2";
            button2.Size = new Size(198, 25);
            button2.TabIndex = 13;
            button2.Text = "Sipariş Durumunu İlerlet";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(343, 130);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(198, 25);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Siparişi İptal Et / İade Et";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCompositeTest
            // 
            btnCompositeTest.Location = new Point(343, 172);
            btnCompositeTest.Name = "btnCompositeTest";
            btnCompositeTest.Size = new Size(198, 25);
            btnCompositeTest.TabIndex = 15;
            btnCompositeTest.Text = "Montajlı Ürün";
            btnCompositeTest.UseVisualStyleBackColor = true;
            btnCompositeTest.Click += btnCompositeTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 450);
            Controls.Add(btnCompositeTest);
            Controls.Add(btnCancel);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private Label label5;
        private Button button2;
        private Button btnCancel;
        private Button btnCompositeTest;
    }
>>>>>>> a0005938bba87bf4dba2d87124c65b16e14df65d
}