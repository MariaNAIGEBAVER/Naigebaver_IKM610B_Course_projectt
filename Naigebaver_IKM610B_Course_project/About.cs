﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Naigebaver_IKM610B_Course_project
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void tAbout_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }
            timer1.Start();
        }
    }
}