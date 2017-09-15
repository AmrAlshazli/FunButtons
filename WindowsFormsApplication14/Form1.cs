using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            richTextBox1.Text = "Press anywhere";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "button1 is pressed";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "button2 is pressed";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "button3 is pressed";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "button4 is pressed ";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "button5 is pressed";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "button6 is pressed";
        }

        

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = "Rich text box is pressed";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = "Form is pressed ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F = new Form2();
            F.ShowDialog();

        }
    }
}
