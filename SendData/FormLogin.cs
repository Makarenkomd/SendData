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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEnterLogin_Click(object sender, EventArgs e)
        {
            FormGame f = new FormGame(textBoxLogin.Text);
            //f.Show();
            this.Hide();
            f.ShowDialog();
            this.Close();
            

        }
    }
}
