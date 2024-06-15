namespace CashRegister
{
    partial class Receipt
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            returned = new Label();
            pay = new Label();
            total = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listBox1_receipt = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(returned);
            panel1.Controls.Add(pay);
            panel1.Controls.Add(total);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(listBox1_receipt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(237, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 426);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(114, 354);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 59);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // returned
            // 
            returned.AutoSize = true;
            returned.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            returned.Location = new Point(233, 317);
            returned.Name = "returned";
            returned.Size = new Size(63, 17);
            returned.TabIndex = 17;
            returned.Text = "0.00 AZN";
            // 
            // pay
            // 
            pay.AutoSize = true;
            pay.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            pay.Location = new Point(233, 296);
            pay.Name = "pay";
            pay.Size = new Size(63, 17);
            pay.TabIndex = 16;
            pay.Text = "0.00 AZN";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            total.Location = new Point(233, 276);
            total.Name = "total";
            total.Size = new Size(63, 17);
            total.TabIndex = 15;
            total.Text = "0.00 AZN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(137, 317);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 14;
            label4.Text = "Qalıq məbləğ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(114, 296);
            label5.Name = "label5";
            label5.Size = new Size(114, 17);
            label5.TabIndex = 13;
            label5.Text = "Ödənilən məbləğ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.Location = new Point(124, 276);
            label6.Name = "label6";
            label6.Size = new Size(104, 17);
            label6.TabIndex = 12;
            label6.Text = "Ümumi məbləğ:";
            // 
            // listBox1_receipt
            // 
            listBox1_receipt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1_receipt.ForeColor = Color.DimGray;
            listBox1_receipt.FormattingEnabled = true;
            listBox1_receipt.ItemHeight = 17;
            listBox1_receipt.Location = new Point(3, 134);
            listBox1_receipt.Name = "listBox1_receipt";
            listBox1_receipt.Size = new Size(293, 140);
            listBox1_receipt.TabIndex = 4;
            listBox1_receipt.SelectedIndexChanged += listBox1_receipt_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(3, 102);
            label3.Name = "label3";
            label3.Size = new Size(293, 17);
            label3.TabIndex = 3;
            label3.Text = "Kod   |   Ad   |   Miqdar   |   Qiymət   |   Məbləğ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(118, 69);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 2;
            label2.Text = "00.00.0000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(147, 16);
            label1.Name = "label1";
            label1.Size = new Size(60, 34);
            label1.TabIndex = 1;
            label1.Text = "SUPER\r\nMARKET";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.supermarket_ecommerce_icon;
            pictureBox1.Location = new Point(106, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Receipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private ListBox listBox1_receipt;
        private Label returned;
        private Label pay;
        private Label total;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox2;
    }
}