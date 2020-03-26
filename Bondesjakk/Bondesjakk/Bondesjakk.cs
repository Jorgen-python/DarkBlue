using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bondesjakk
{
    public partial class frmBondesjakk : MetroFramework.Forms.MetroForm 
    {
        public int bot;
        public int x = 0;
        public int o = 0;
        public frmBondesjakk()
        {
            InitializeComponent();
        }

        private void Lbl1_Click(object sender, EventArgs e)
        {
            lbl1.Text = "X";
            sjekkvinn();
            if (bot == 1)
            {
                AI();
            }
        }

        private void Lbl5_Click(object sender, EventArgs e)
        {
            lbl5.Text = "X";
            sjekkvinn();
            if (bot == 1)
            {
                AI();
            }
        }

        private void Lbl2_Click(object sender, EventArgs e)
        {
            lbl2.Text = "X";
            sjekkvinn();
            if (bot == 1)
            {
                AI();
            }
        }

        private void Lbl3_Click(object sender, EventArgs e)
        {
            lbl3.Text = "X";
            sjekkvinn();
            if (bot == 1)
            {
                AI();
            }
        }

        private void Lbl6_Click(object sender, EventArgs e)
        {
            lbl6.Text = "X";
            sjekkvinn();
            if (bot == 1)
            {
                AI();
            }
        }

        private void Lbl4_Click(object sender, EventArgs e)
        {
            lbl4.Text = "X";
            sjekkvinn();
            if (bot == 1)
            {
                AI();
            }
        }
        private void Lbl7_Click(object sender, EventArgs e)
        {
            lbl7.Text = "X";
            sjekkvinn();
            if (bot == 1)
            {
                AI();
            }
        }

        private void Lbl8_Click(object sender, EventArgs e)
        {
            lbl8.Text = "X";
            sjekkvinn();
            if (bot == 1)
            {
                AI();
            }
        }

        private void Lbl9_Click(object sender, EventArgs e)
        {
            lbl9.Text = "X";
            sjekkvinn();
            if (bot == 1)
            {
                AI();
            }
        }

        private void Lbl1_DoubleClick(object sender, EventArgs e)
        {
            lbl1.Text = "O";
            sjekkvinn();
        }

        private void Lbl2_DoubleClick(object sender, EventArgs e)
        {
            lbl2.Text = "O";
            sjekkvinn();
        }

        private void Lbl3_DoubleClick(object sender, EventArgs e)
        {
            lbl3.Text = "O";
            sjekkvinn();
        }

        private void Lbl4_DoubleClick(object sender, EventArgs e)
        {
            lbl4.Text = "O";
            sjekkvinn();
        }

        private void Lbl5_DoubleClick(object sender, EventArgs e)
        {
            lbl5.Text = "O";
            sjekkvinn();
        }

        private void Lbl6_DoubleClick(object sender, EventArgs e)
        {
            lbl6.Text = "O";
            sjekkvinn();
        }

        private void Lbl7_DoubleClick(object sender, EventArgs e)
        {
            lbl7.Text = "O";
            sjekkvinn();
        }

        private void Lbl8_DoubleClick(object sender, EventArgs e)
        {
            lbl8.Text = "O";
            sjekkvinn();
        }

        private void Lbl9_DoubleClick(object sender, EventArgs e)
        {
            lbl9.Text = "O";
            sjekkvinn();
        }

        private void BtnNyttForsøk_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnAvslutt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public void Reset()        
        {
        lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
            lbl7.Text = "";
            lbl8.Text = "";
            lbl9.Text = "";
        }
    private void sjekkvinn()
        {
            //Sjekker om X har vunnet

            if (lbl1.Text == "X" && lbl2.Text == "X" && lbl3.Text == "X" || lbl4.Text == "X" && lbl6.Text == "X" && lbl5.Text == "X" || lbl7.Text == "X" && lbl8.Text == "X" && lbl9.Text == "X")
            {
                MessageBox.Show("X Wins!");
                x += 1;
                lblScoreX.Text = x.ToString();
                Reset();
            }
            if (lbl1.Text == "X" && lbl4.Text == "X" && lbl7.Text == "X" || lbl2.Text == "X" && lbl5.Text == "X" && lbl8.Text == "X" || lbl3.Text == "X" && lbl6.Text == "X" && lbl9.Text == "X")
            {
                MessageBox.Show("X Wins!");
                x += 1;
                lblScoreX.Text = x.ToString();
                Reset();
            }
            if (lbl1.Text == "X" && lbl5.Text == "X" && lbl9.Text == "X" || lbl3.Text == "X" && lbl5.Text == "X" && lbl7.Text == "X")
            {
                MessageBox.Show("X Wins!");
                x += 1;
                lblScoreX.Text = x.ToString();
                Reset();
            }
            //Sjekker om O har vunnet

            if (lbl1.Text == "O" && lbl2.Text == "O" && lbl3.Text == "O" || lbl4.Text == "O" && lbl6.Text == "O" && lbl5.Text == "O" || lbl7.Text == "O" && lbl8.Text == "O" && lbl9.Text == "O")
            {
                MessageBox.Show("O Wins!");
                o += 1;
                lblScoreO.Text = o.ToString();
                Reset();
            }
            if (lbl1.Text == "O" && lbl4.Text == "O" && lbl7.Text == "O" || lbl2.Text == "O" && lbl5.Text == "O" && lbl8.Text == "O" || lbl3.Text == "O" && lbl6.Text == "O" && lbl9.Text == "O")
            {
                MessageBox.Show("O Wins!");
                o += 1;
                lblScoreO.Text = o.ToString();
                Reset();
            }
            if (lbl1.Text == "O" && lbl5.Text == "O" && lbl9.Text == "O" || lbl3.Text == "O" && lbl5.Text == "O" && lbl7.Text == "O")
            {
                MessageBox.Show("O Wins!");
                o += 1;
                lblScoreO.Text = o.ToString();
                Reset();
            }
        }
        public void AI()
        {
            Random rnd = new Random();
            bool retry = true;
            while(retry)
            {
                int num = rnd.Next(0, 10);
                //Bruker annerledes metode på første for å vise at det er andre måter å gjøre det på :)
                if (lbl1.Text == "" && num == 1)
                {
                    lbl1.Text = "O";
                    retry = false;
                    sjekkvinn();
                }
                if (string.IsNullOrEmpty(lbl2.Text) && num == 2)
                {
                    lbl2.Text = "O";
                    retry = false;
                    sjekkvinn();
                }
                if (string.IsNullOrEmpty(lbl3.Text) && num == 3)
                {
                    lbl3.Text = "O";
                    retry = false;
                    sjekkvinn();
                }
                if (string.IsNullOrEmpty(lbl4.Text) && num == 4)
                {
                    lbl4.Text = "O";
                    retry = false;
                    sjekkvinn();
                }
                if (string.IsNullOrEmpty(lbl5.Text) && num == 5)
                {
                    lbl5.Text = "O";
                    retry = false;
                    sjekkvinn();
                }
                if (string.IsNullOrEmpty(lbl6.Text) && num == 6)
                {
                    lbl6.Text = "O";
                    retry = false;
                    sjekkvinn();
                }
                if (string.IsNullOrEmpty(lbl7.Text) && num == 7)
                {
                    lbl7.Text = "O";
                    retry = false;
                    sjekkvinn();
                }
                if (string.IsNullOrEmpty(lbl8.Text) && num == 8)
                {
                    lbl8.Text = "O";
                    retry = false;
                    sjekkvinn();
                }
                if (string.IsNullOrEmpty(lbl9.Text) && num == 9)
                {
                    lbl9.Text = "O";
                    retry = false;
                    sjekkvinn();
                }

            }
        }

        private void MotAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bot = 1;
            lblTextO.Text = "Bot er O";
        }

        private void NormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bot = 0;
            lblTextO.Text = "Dobbel-Klikk for O";
        }
    }
}
