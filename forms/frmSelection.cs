﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_pos_system
{
    public partial class frmSelection : Form
    {
        public frmSelection()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You have Confirm the order");

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTopping_DropDown(object sender, EventArgs e)
        {
            this.cbTopping.ForeColor = Color.Black;
        }

        private void cbSuger_DropDown(object sender, EventArgs e)
        {
            this.cbSuger.ForeColor = Color.Black;
        }

        private void cbCup_DropDown(object sender, EventArgs e)
        {
            this.cbCup.ForeColor = Color.Black;
        }
    }
}