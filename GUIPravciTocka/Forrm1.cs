﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VsiteCSharpLinearnaJednadzbaGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultDisplay1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            resultDisplay1.FillResults();
        }
    }
}