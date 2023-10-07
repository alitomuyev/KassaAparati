using KassaAparati.Entity;

namespace KassaAparati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Product a = new Product();
        decimal result = 0;

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox5.Text += btn.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox5.Text += btn.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox5.Text += btn.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox5.Text += btn.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox5.Text += btn.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox5.Text += btn.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox5.Text += btn.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox5.Text += btn.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox5.Text += btn.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox5.Text += btn.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox5.Text += btn.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"202: Lays \n" +
                $"203: Coca-Cola \n" +
                $"204: Kurassan \n");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "202")
            {
                object[] list = { a.Name = "Lays", a.Price = 2.20M };

                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
                result = result + a.Price;

            }
            else if (textBox1.Text == "203")
            {
                object[] list = { a.Name = "Coca-Cola", a.Price = 1.20M };

                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }
                result = result + a.Price;

            }
            else
            {
                MessageBox.Show("Mehsul kodu movcud deyil");
            }



            label7.Text = result.ToString() + " " + "azn";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            decimal money = Convert.ToDecimal(textBox5.Text);

            if (money < result)
            {
                MessageBox.Show("Odenilen mebleg umumi meblegden kicik ola bilmez!");
                label8.ForeColor = Color.Red;
                label8.Text = money.ToString() + " " + "azn";

            }
            else
            {
                decimal tot = money - result;
                label9.Text = tot.ToString() + " " + "azn";
                label9.ForeColor = Color.Green;
                label8.ForeColor = Color.White;
                label8.Text = money.ToString() + " " + "azn";

            }
        }
    }
}
