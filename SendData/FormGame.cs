using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SendData
{
    public partial class FormGame : Form
    {
        string userName;
        public FormGame()
        {
            InitializeComponent();
        }

        public FormGame(string name) : this()
        {
            userName = name;
            this.Text = "Пользователь: " + userName;
        }

        private void buttonInc_Click(object sender, EventArgs e)
        {

        }
    }
}
