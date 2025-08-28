namespace Pizzacı_uygulaması
{
    public partial class Pizzacım : Form
    {
        int fiyat = 0;
        public Pizzacım()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                fiyat += 100;
            }
            else
            {
                fiyat -= 100;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                fiyat += 90;
            }
            else
            {
                fiyat -= 90;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                fiyat += 85;
            }
            else
            {
                fiyat -= 85;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                fiyat += 70;
            }
            else
            {
                fiyat -= 70;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                fiyat += 0;
            }
            else
            {
                fiyat -= 0;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                fiyat += 10;
            }
            else
            {
                fiyat -= 10;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                fiyat += 20;
            }
            else
            {
                fiyat -= 20;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                fiyat += 35;
            }
            else
            {
                fiyat -= 35;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fiyat += 3;
            }
            else
            {
                fiyat -= 3;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                fiyat += 5;
            }
            else
            {
                fiyat -= 5;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                fiyat += 6;
            }
            else
            {
                fiyat -= 6;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                fiyat += 15;
            }
            else
            {
                fiyat -= 15;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                fiyat += 12;
            }
            else
            {
                fiyat -= 12;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                fiyat += 8;
            }
            else
            {
                fiyat -= 8;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sipariş Alındı!!!");
            listBox1.Items.Add($"İsim-Soyisim: {textBox1.Text}");
            listBox1.Items.Add($"Telefon Numarası: {maskedTextBox1.Text}");
            listBox1.Items.Add($"Adres: {textBox2.Text}");
            label24.Text = fiyat.ToString();
        }

        //private void panel2_paint(object sender, painteventargs e)
        //{

        //}
    }
}
