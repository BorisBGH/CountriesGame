﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countries
{
    public partial class Finish : Form
    {
        public Finish()
        {
            InitializeComponent();
            
        }

        private void label_result_Click(object sender, EventArgs e)
        {

        }

        private void Finish_Load(object sender, EventArgs e)
        {
            
        }

        private void button_playAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
