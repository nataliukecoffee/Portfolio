using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double svoris;
            double ugis;
            int kmi;

            svoris = Convert.ToDouble(textBox1.Text);
            ugis = Convert.ToDouble(textBox2.Text);
            kmi = (int)(svoris / (Math.Pow(ugis, 2)));

            MessageBox.Show(kmi.ToString());
        }
    }
}
