﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Household_account
{
    public partial class FOut : Form
    {
        public FOut()
        {
            InitializeComponent();
        }

        private void bt_out_OK_Click(object sender, EventArgs e)
        {
            DialogResult= System.Windows.Forms.DialogResult.OK;
        }
    }
}
