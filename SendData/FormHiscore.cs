﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SendData
{
    public partial class FormHiscore : Form
    {
        public FormHiscore()
        {
            InitializeComponent();
        }

        public FormHiscore(user u):this()
        {
            labelResult.Text = u.ToString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

        }
    }
}
