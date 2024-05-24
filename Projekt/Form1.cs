namespace Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button1.Enabled = true;
            label4.Hide();
            textBox1.Hide();
            label5.Hide();
            comboBox1.Hide();
            button2.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Hide();
            button1.Hide();
            label4.Show();
            textBox1.Show();
            label5.Show();
            comboBox1.Show();
            button2.Show();
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double slutLängd;
            int startLängd = int.Parse(textBox1.Text);
            try
            {
                string underlag = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                if (underlag == "Bunker")
                {
                    slutLängd = startLängd * 1.2;
                }
                else if (underlag == "Fairway")
                {
                    slutLängd = startLängd;
                }
                else if (underlag == "Lätt Ruff")
                {
                    slutLängd = startLängd * 1.1;
                }
                else if (underlag == "Mellan Ruff")
                {
                    slutLängd = startLängd * 1.2;
                }
                else
                {
                    slutLängd = startLängd * 1.3;
                }
                Form2 f2 = new Form2();
                f2.längd = slutLängd;
                f2.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Något gick fel", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}