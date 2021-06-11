using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS005NasobeniCisel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vynasobitButton_Click(object sender, EventArgs e)
        {
            vysledekLabel.Text =
                string.Format(
                    "={0:0.000}",
                    double.Parse(cislo1TextBox.Text) * 
                    double.Parse(cislo2TextBox.Text) * 
                    double.Parse(cislo3TextBox.Text)
                );
        }
    }
}
