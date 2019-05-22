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
            labelScore.Text = (Convert.ToInt32(labelScore.Text) + 1).ToString();
        }

        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы точно закончить игру?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
        }
    }
}
