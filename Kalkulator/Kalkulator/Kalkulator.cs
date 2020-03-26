using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class frmKalkulator : MetroFramework.Forms.MetroForm
    {
        public frmKalkulator()
        {
            InitializeComponent();
        }

        private void HjelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klikk på Regneart for valg av Regneart\nKlikk på Modus for valg av Modus", "Hjelp");
        }

        private void BtnAvslutt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnVisk_Click(object sender, EventArgs e)
        {
            txtSvar.Text = "";
            txtTall1.Text = "";
            txtTall2.Text = "";
        }

        private void BtnErLik_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTall1.Text) || !string.IsNullOrEmpty(txtTall2.Text))
            {
                float Tall1 = Convert.ToInt32(txtTall1.Text);
                float Tall2 = Convert.ToInt32(txtTall2.Text);
                if (lblRegneart.Text == "+")
                {
                    txtSvar.Text = Convert.ToString(Tall1 + Tall2);
                }
                else if (lblRegneart.Text == "-")
                {
                    txtSvar.Text = Convert.ToString(Tall1 - Tall2);
                }
                else if (lblRegneart.Text == "X")
                {
                    txtSvar.Text = Convert.ToString(Tall1 * Tall2);
                }
                else if (lblRegneart.Text == "÷")
                {
                    txtSvar.Text = Convert.ToString(Tall1 / Tall2);
                }
            }
        }

        private void MinusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblRegneart.Text = "-";
        }

        private void PlussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblRegneart.Text = "+";
        }

        private void GangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblRegneart.Text = "X";
        }

        private void DelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblRegneart.Text = "÷";
        }

        private void MnuAvansert_Click(object sender, EventArgs e)
        {
            Form Avansert = new frmAvansert();
            Avansert.Show();
            this.Hide();
        }

        private void FrmKalkulator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
