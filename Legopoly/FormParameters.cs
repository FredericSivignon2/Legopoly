﻿using FoundationLibraries.Xml;
using Legopoly.Parameters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legopoly
{
    public partial class FormParameters : Form
    {
        public FormParameters()
        {
            InitializeComponent();
        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            ParametersMain parameters = new ParametersMain();
            parameters.CreateDefault();
        }
    }
}
