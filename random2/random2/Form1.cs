using System;

namespace random2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();

        

        private void button1_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(1, 100);
            int b = rastgele.Next(1, 100);
            label1.Text = a.ToString();
            label2.Text = b.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}