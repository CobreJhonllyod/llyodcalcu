using System.Data;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button15_Click(object sender, EventArgs e)
        {
            string equation = textBox1.Text;
            var result = new DataTable().Compute(equation, null);
            textBox1.Text = result.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void bnt(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
