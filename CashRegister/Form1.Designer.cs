namespace CashRegister
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            btn_elaveEt = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnHesabla = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnDot = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnDel = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            textBox_mebleg = new TextBox();
            listBox1_system = new ListBox();
            total = new Label();
            pay = new Label();
            returned = new Label();
            label_error = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 20);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "Məhsul kodu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 39);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(478, 16);
            label2.Name = "label2";
            label2.Size = new Size(170, 30);
            label2.TabIndex = 2;
            label2.Text = "Ümumi məbləğ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(461, 49);
            label3.Name = "label3";
            label3.Size = new Size(187, 30);
            label3.TabIndex = 3;
            label3.Text = "Ödənilən məbləğ:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button1.Location = new Point(180, 13);
            button1.Name = "button1";
            button1.Size = new Size(129, 39);
            button1.TabIndex = 4;
            button1.Text = "Kod siyahısı";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_elaveEt
            // 
            btn_elaveEt.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btn_elaveEt.Location = new Point(180, 62);
            btn_elaveEt.Name = "btn_elaveEt";
            btn_elaveEt.Size = new Size(129, 42);
            btn_elaveEt.TabIndex = 5;
            btn_elaveEt.Text = "Əlavə et";
            btn_elaveEt.UseVisualStyleBackColor = true;
            btn_elaveEt.Click += btn_elaveEt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.Location = new Point(498, 83);
            label4.Name = "label4";
            label4.Size = new Size(150, 30);
            label4.TabIndex = 6;
            label4.Text = "Qalıq məbləğ:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHesabla);
            groupBox1.Controls.Add(btn0);
            groupBox1.Controls.Add(btn9);
            groupBox1.Controls.Add(btn8);
            groupBox1.Controls.Add(btn7);
            groupBox1.Controls.Add(btnDot);
            groupBox1.Controls.Add(btn6);
            groupBox1.Controls.Add(btn5);
            groupBox1.Controls.Add(btn4);
            groupBox1.Controls.Add(btnDel);
            groupBox1.Controls.Add(btn3);
            groupBox1.Controls.Add(btn2);
            groupBox1.Controls.Add(btn1);
            groupBox1.Controls.Add(textBox_mebleg);
            groupBox1.Location = new Point(43, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 299);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Məbləğ";
            // 
            // btnHesabla
            // 
            btnHesabla.Location = new Point(13, 248);
            btnHesabla.Name = "btnHesabla";
            btnHesabla.Size = new Size(174, 42);
            btnHesabla.TabIndex = 18;
            btnHesabla.Text = "Hesabla";
            btnHesabla.UseVisualStyleBackColor = true;
            btnHesabla.Click += btnHesabla_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(199, 199);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 91);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(137, 199);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 43);
            btn9.TabIndex = 16;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(75, 199);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 43);
            btn8.TabIndex = 15;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(13, 199);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 43);
            btn7.TabIndex = 14;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(199, 150);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(50, 43);
            btnDot.TabIndex = 13;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(137, 150);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 43);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(75, 150);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 43);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(13, 150);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 43);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(199, 101);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(50, 43);
            btnDel.TabIndex = 9;
            btnDel.Text = "<";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(137, 101);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 43);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(75, 101);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 43);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(13, 101);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 43);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // textBox_mebleg
            // 
            textBox_mebleg.Location = new Point(13, 44);
            textBox_mebleg.Name = "textBox_mebleg";
            textBox_mebleg.Size = new Size(236, 39);
            textBox_mebleg.TabIndex = 0;
            // 
            // listBox1_system
            // 
            listBox1_system.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1_system.FormattingEnabled = true;
            listBox1_system.ItemHeight = 25;
            listBox1_system.Location = new Point(387, 150);
            listBox1_system.Name = "listBox1_system";
            listBox1_system.Size = new Size(360, 229);
            listBox1_system.TabIndex = 8;
            listBox1_system.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            total.Location = new Point(648, 16);
            total.Name = "total";
            total.Size = new Size(106, 30);
            total.TabIndex = 9;
            total.Text = "0.00 AZN";
            // 
            // pay
            // 
            pay.AutoSize = true;
            pay.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            pay.Location = new Point(648, 49);
            pay.Name = "pay";
            pay.Size = new Size(106, 30);
            pay.TabIndex = 10;
            pay.Text = "0.00 AZN";
            // 
            // returned
            // 
            returned.AutoSize = true;
            returned.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            returned.Location = new Point(648, 83);
            returned.Name = "returned";
            returned.Size = new Size(106, 30);
            returned.TabIndex = 11;
            returned.Text = "0.00 AZN";
            // 
            // label_error
            // 
            label_error.AutoSize = true;
            label_error.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_error.ForeColor = Color.Red;
            label_error.Location = new Point(397, 113);
            label_error.Name = "label_error";
            label_error.Size = new Size(357, 23);
            label_error.TabIndex = 12;
            label_error.Text = "Ödənilən məbləğ ümumi məbləğdən azdır!";
            label_error.Visible = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button2.Location = new Point(387, 385);
            button2.Name = "button2";
            button2.Size = new Size(360, 38);
            button2.TabIndex = 13;
            button2.Text = "Qəbzi çap et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(794, 452);
            Controls.Add(button2);
            Controls.Add(label_error);
            Controls.Add(returned);
            Controls.Add(pay);
            Controls.Add(total);
            Controls.Add(listBox1_system);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(btn_elaveEt);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button btn_elaveEt;
        private Label label4;
        private GroupBox groupBox1;
        private Button btnDel;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private TextBox textBox_mebleg;
        private ListBox listBox1_system;
        private Button btnHesabla;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDot;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Label total;
        private Label pay;
        private Label returned;
        private Label label_error;
        private Button button2;
    }
}
