﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Za_Ro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrikaziPoruku_Click(object sender, EventArgs e)
        {
            lblLjubavnaPoruka.Text = "Kad pripadam tebi, tad konačno potpuno pripadam i samome sebi";
            btnPrikaziPoruku.Enabled = false;
            lblSutra.Visible = true;
        }
    }
}
