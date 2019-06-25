using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double laipsniai;
            double kelvin;
            double faringeit;
            double reomiur;

            laipsniai = Convert.ToDouble(textBox1.Text);

            kelvin = laipsniai + 273.16;
            faringeit = laipsniai * (9 / 5) + 32;
            reomiur = 0.8 * laipsniai;

            textBox2.Text = kelvin.ToString();
            textBox3.Text = faringeit.ToString();
            textBox4.Text = reomiur.ToString();
            
        }
    }
}
