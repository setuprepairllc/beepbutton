using System;

namespace beepbutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            System.Media.SystemSounds.Beep.Play();
            textBox1.Text = "beep!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
