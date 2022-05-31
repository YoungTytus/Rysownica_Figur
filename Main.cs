using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ButStartRand_Click(object sender, EventArgs e)
        {
            var form = new Slajd();
            Hide();
            form.Show();
        }

        private void ButStartMysz_Click(object sender, EventArgs e)
        {
            var form = new Mysz();
            Hide();
            form.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}