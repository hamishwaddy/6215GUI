using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2nWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowResult.Text = "custom text";
        }

        private void ShowResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Messages.StringTotal(Word.Text));
        }

        private void Word_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Messages.StringBreak(Word.Text));
        }
    }
}
