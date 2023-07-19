namespace hesap
{
    public partial class Form1 : Form
    {
        int islem;
        int _ilksayi = 0;
        bool ekran;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekran) { label1.Text = ""; }
            ekran = false;
            if (label1.Text == "0")
                label1.Text = "1";
            else
            {
                label1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekran) { label1.Text = ""; }
            ekran = false;
            if (label1.Text == "0")
                label1.Text = "2";
            else
            {
                label1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ekran) { label1.Text = ""; }
            ekran = false;
            if (label1.Text == "0")
                label1.Text = "3";
            else
            {
                label1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ekran) { label1.Text = ""; }
            ekran = false;
            if (label1.Text == "0")
                label1.Text = "4";
            else
            {
                label1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ekran) { label1.Text = ""; }
            ekran = false;
            if (label1.Text == "0")
                label1.Text = "5";
            else
            {
                label1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ekran) { label1.Text = ""; }
            ekran = false;
            if (label1.Text == "0")
                label1.Text = "6";
            else
            {
                label1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ekran) { label1.Text = ""; }
            ekran = false;
            if (label1.Text == "0")
                label1.Text = "7";
            else
            {
                label1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ekran) { label1.Text = ""; }
            ekran = false;
            if (label1.Text == "0")
                label1.Text = "8";
            else
            {
                label1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ekran) { label1.Text = ""; }
            ekran = false;
            if (label1.Text == "0")
                label1.Text = "9";
            else
            {
                label1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ekran) { label1.Text = ""; }
            ekran = false;
            if (label1.Text == "0")
                label1.Text = "0";
            else
            {
                label1.Text += "0";
            }

        }
        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }




        private void button11_Click(object sender, EventArgs e)
        {
            islem = 1;
            ekran = true;
            _ilksayi = _ilksayi + Convert.ToInt32(label1.Text);

        }
        private void button12_Click(object sender, EventArgs e)
        {
            islem = 2;
            ekran = true;
            _ilksayi = Convert.ToInt32(label1.Text) - _ilksayi;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int _ikincisayi;
            int ikincisayi = Convert.ToInt32(label1.Text);
            if (islem == 1)
            {
                _ikincisayi = _ilksayi + Convert.ToInt32(label1.Text);

                label1.Text = _ikincisayi.ToString();
                islem = 0;
                _ilksayi = 0;
            }
            else if (islem == 2)
            {
                int sonuc;
                ikincisayi = Convert.ToInt32(label1.Text);
                sonuc = _ilksayi - ikincisayi;
                label1.Text = sonuc.ToString();
                islem = 0;
                _ilksayi = 0;

            }
            else if (islem == 3)
            {
                int sonuc;
                ikincisayi = Convert.ToInt32(label1.Text);
                sonuc = _ilksayi / ikincisayi;
                label1.Text = sonuc.ToString();
                islem = 0;
                _ilksayi = 0;
            }
            else if (islem == 4)
            {
                int sonuc;
                ikincisayi = Convert.ToInt32(label1.Text);
                sonuc = _ilksayi * ikincisayi;
                label1.Text = sonuc.ToString();
                islem = 0;
                _ilksayi = 0;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            islem = 3;
            ekran = true;
            _ilksayi = Convert.ToInt32(label1.Text);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            islem = 4;
            ekran = true;
            _ilksayi = Convert.ToInt32(label1.Text);
        }
    }
}