using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.Pythegoras
{
    public partial class Pythegoras1 : Form
    {
        public Pythegoras1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B, C;
            if (double.TryParse(textBox1.Text, out A) && double.TryParse(textBox2.Text, out B))
            {
                C = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
                textBox3.Text = C.ToString();
            }
        }
    }
}
