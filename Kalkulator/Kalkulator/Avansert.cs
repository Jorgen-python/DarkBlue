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
    public partial class frmAvansert : MetroFramework.Forms.MetroForm
    {
        public frmAvansert()
        {
            InitializeComponent();
        }

        private void MnuBasisk_Click(object sender, EventArgs e)
        {
            Form Basisk = new frmKalkulator();
            Basisk.Show();
            this.Hide();
        }

        private void FrmAvansert_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtResultat.Text += "0";
        }

        private void BtnVisk_Click(object sender, EventArgs e)
        {
            txtResultat.Text = "";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtResultat.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtResultat.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtResultat.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtResultat.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtResultat.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtResultat.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtResultat.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtResultat.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtResultat.Text += "9";
        }

        private void BtnKomma_Click(object sender, EventArgs e)
        {
            txtResultat.Text += ".";
        }

        private void BtnGange_Click(object sender, EventArgs e)
        {
            Tall1 = float.Parse(txtResultat.Text);
            Regnart = "x";
            txtResultat.Text = "";
        }
        public static float Tall1, Tall2;
        public static string Regnart;

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            Tall1 = float.Parse(txtResultat.Text);
            Regnart = "-";
            txtResultat.Text = "";
        }

        private void BtnPluss_Click(object sender, EventArgs e)
        {
            Tall1 = float.Parse(txtResultat.Text);
            Regnart = "+";
            txtResultat.Text = "";
        }

        private void BtnDeling_Click(object sender, EventArgs e)
        {
            Tall1 = float.Parse(txtResultat.Text);
            Regnart = "÷";
            txtResultat.Text = "";
        }

        private void BtnSin_Click(object sender, EventArgs e)
        {
            Tall1 = float.Parse(txtResultat.Text);
            txtResultat.Text = Convert.ToString(Math.Sin(Tall1));
        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            Tall1 = float.Parse(txtResultat.Text);
            txtResultat.Text = Convert.ToString(Math.Cos(Tall1));
        }

        private void BtnFaktorial_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtResultat.Text);
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            txtResultat.Text = Convert.ToString(factorial);
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            Tall1 = float.Parse(txtResultat.Text);
            txtResultat.Text = Convert.ToString(Math.Log(Tall1));
        }

        private void BtnSquareRoot_Click(object sender, EventArgs e)
        {
            Tall1 = float.Parse(txtResultat.Text);
            txtResultat.Text = Convert.ToString(Math.Sqrt(Tall1));
        }

        private void BtnOpphøyd_Click(object sender, EventArgs e)
        {
            Tall1 = float.Parse(txtResultat.Text);
            Regnart = "^";
            txtResultat.Text = "";
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            Tall1 = float.Parse(txtResultat.Text);
            txtResultat.Text = Convert.ToString(Math.Tan(Tall1));
        }

        private void BtnProsent_Click(object sender, EventArgs e)
        {
            Tall1 = float.Parse(txtResultat.Text);
            Regnart = "%";
            txtResultat.Text = "";
        }

        private void BtnErLik_Click(object sender, EventArgs e)
        {
            if (Regnart == "x")
            {
                Tall2 = float.Parse(txtResultat.Text);
                txtResultat.Text = Convert.ToString(Tall1 * Tall2);
            }
            else if (Regnart == "-")
            {
                Tall2 = float.Parse(txtResultat.Text);
                txtResultat.Text = Convert.ToString(Tall1 - Tall2);
            }
            else if (Regnart == "+")
            {
                Tall2 = float.Parse(txtResultat.Text);
                txtResultat.Text = Convert.ToString(Tall1 + Tall2);
            }
            else if (Regnart == "/")
            {
                Tall2 = float.Parse(txtResultat.Text);
                txtResultat.Text = Convert.ToString(Tall1 / Tall2);
            }
            else if (Regnart == "^")
            {
                Tall2 = float.Parse(txtResultat.Text);
                txtResultat.Text = Convert.ToString(Math.Pow(Tall1, Tall2));
            }
            else if (Regnart == "%")
            {
                Tall2 = float.Parse(txtResultat.Text);
                txtResultat.Text = Convert.ToString((Tall1 / Tall2) * 100);
            }
        }
    }
}
