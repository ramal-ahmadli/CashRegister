using MessagingToolkit.QRCode.Codec;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal toplam = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
             Kod 101 | Alma
             Kod 102 | Çörək
             Kod 103 | Şəkər");
        }

        private void btn_elaveEt_Click(object sender, EventArgs e)
        {
            string[] codes = { "101", "102", "103" };
            string[] products = { "Qatıq", "Çörək", "Şəkər" };
            decimal[] quantity = { 1, 1.00M };
            decimal[] price = { 1.00M, 0.55M, 1.20M };

            if (textBox1.Text == codes[0])
            {
                listBox1_system.Items.Add($"{codes[0]} | {products[0]} | {quantity[0]} əd | {price[0]} AZN");
                toplam = toplam + price[0];
            }
            else if (textBox1.Text == codes[1])
            {
                listBox1_system.Items.Add($"{codes[1]} | {products[1]} | {quantity[1]} əd | {price[1]} AZN");
                toplam = toplam + price[1];
            }
            else if (textBox1.Text == codes[2])
            {
                listBox1_system.Items.Add($"{codes[2]} | {products[2]} | {quantity[2]} əd | {price[2]} AZN");
                toplam = toplam + price[1];
            }
            else
            {
                MessageBox.Show("Yalnış kod!");
            }

            total.Text = toplam.ToString() + " " + "AZN";

            //QRCodeEncoder encoder = new QRCodeEncoder();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox_mebleg.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox_mebleg.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox_mebleg.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox_mebleg.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox_mebleg.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox_mebleg.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox_mebleg.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox_mebleg.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox_mebleg.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox_mebleg.Text += btn.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox_mebleg.Text += btn.Text;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            textBox_mebleg.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHesabla_Click(object sender, EventArgs e)
        {
            decimal _pay = Convert.ToDecimal(textBox_mebleg.Text);
            if (_pay < toplam)
            {
                label_error.Visible = true;
            }
            else
            {
                label_error.Visible = false;
                decimal _returned = _pay - toplam;
                pay.Text = _pay.ToString() + " " + "AZN";
                returned.Text = _returned.ToString() + " " + "AZN";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.Show();
        }
    }
}
