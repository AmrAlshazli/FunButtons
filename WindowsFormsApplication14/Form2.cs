using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();

            panel1.Location = new Point(rnd.Next(0,300), rnd.Next(0, 300));

            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            button1.BackColor = randomColor;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();

            panel1.Location = new Point(rnd.Next(0, 300), rnd.Next(0, 300));

            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            button1.BackColor = randomColor;

        }
    }
}
