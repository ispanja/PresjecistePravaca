using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinearnaJednadzba;

namespace VsiteCSharpLinearnaJednadzbaGui
{
    public partial class ResultDisplay : UserControl
    {
        public ResultDisplay()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public readonly Pravac p1 = new Pravac();
        public readonly Pravac p2 = new Pravac();
        public Tocka t = new Tocka();

        public void FillResults()
        {
            p1.A = (double) numericUpDowna1.Value;
            p1.B = (double) numericUpDownb1.Value;

            p2.A = (double) numericUpDowna2.Value;
            p2.B = (double) numericUpDownb2.Value;

            
            t = Tocka.Sjeciste(p1, p2);
            textBoxNultocka1.Text = p1.Nultocka.ToString();
            textBox2Nultocka2.Text = p2.Nultocka.ToString();
            textBox3Sjeciste.Text = t.ToString();

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FillResults();
        }
    }
}
