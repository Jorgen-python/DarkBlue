namespace Kalkulator
{
    partial class frmKalkulator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mnuModus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBasisk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAvansert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegneart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPluss = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMinus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeling = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHjelp = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTall1 = new MetroFramework.Controls.MetroTextBox();
            this.txtTall2 = new MetroFramework.Controls.MetroTextBox();
            this.lblRegneart = new System.Windows.Forms.Label();
            this.btnErLik = new MetroFramework.Controls.MetroButton();
            this.txtSvar = new MetroFramework.Controls.MetroTextBox();
            this.btnVisk = new MetroFramework.Controls.MetroButton();
            this.btnAvslutt = new MetroFramework.Controls.MetroButton();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuModus,
            this.mnuRegneart,
            this.mnuHjelp});
            this.mnuMenu.Location = new System.Drawing.Point(20, 60);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(548, 24);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mnuModus
            // 
            this.mnuModus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBasisk,
            this.mnuAvansert});
            this.mnuModus.Name = "mnuModus";
            this.mnuModus.Size = new System.Drawing.Size(56, 20);
            this.mnuModus.Text = "Modus";
            // 
            // mnuBasisk
            // 
            this.mnuBasisk.Name = "mnuBasisk";
            this.mnuBasisk.Size = new System.Drawing.Size(180, 22);
            this.mnuBasisk.Text = "Basisk";
            // 
            // mnuAvansert
            // 
            this.mnuAvansert.Name = "mnuAvansert";
            this.mnuAvansert.Size = new System.Drawing.Size(180, 22);
            this.mnuAvansert.Text = "Avansert";
            this.mnuAvansert.Click += new System.EventHandler(this.MnuAvansert_Click);
            // 
            // mnuRegneart
            // 
            this.mnuRegneart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPluss,
            this.mnuMinus,
            this.mnuGange,
            this.mnuDeling});
            this.mnuRegneart.Name = "mnuRegneart";
            this.mnuRegneart.Size = new System.Drawing.Size(66, 20);
            this.mnuRegneart.Text = "Regneart";
            // 
            // mnuPluss
            // 
            this.mnuPluss.Name = "mnuPluss";
            this.mnuPluss.Size = new System.Drawing.Size(108, 22);
            this.mnuPluss.Text = "Pluss";
            this.mnuPluss.Click += new System.EventHandler(this.PlussToolStripMenuItem_Click);
            // 
            // mnuMinus
            // 
            this.mnuMinus.Name = "mnuMinus";
            this.mnuMinus.Size = new System.Drawing.Size(108, 22);
            this.mnuMinus.Text = "Minus";
            this.mnuMinus.Click += new System.EventHandler(this.MinusToolStripMenuItem_Click);
            // 
            // mnuGange
            // 
            this.mnuGange.Name = "mnuGange";
            this.mnuGange.Size = new System.Drawing.Size(108, 22);
            this.mnuGange.Text = "Gange";
            this.mnuGange.Click += new System.EventHandler(this.GangeToolStripMenuItem_Click);
            // 
            // mnuDeling
            // 
            this.mnuDeling.Name = "mnuDeling";
            this.mnuDeling.Size = new System.Drawing.Size(108, 22);
            this.mnuDeling.Text = "Deling";
            this.mnuDeling.Click += new System.EventHandler(this.DelingToolStripMenuItem_Click);
            // 
            // mnuHjelp
            // 
            this.mnuHjelp.Name = "mnuHjelp";
            this.mnuHjelp.Size = new System.Drawing.Size(47, 20);
            this.mnuHjelp.Text = "Hjelp";
            this.mnuHjelp.Click += new System.EventHandler(this.HjelpToolStripMenuItem_Click);
            // 
            // txtTall1
            // 
            this.txtTall1.Location = new System.Drawing.Point(23, 121);
            this.txtTall1.Name = "txtTall1";
            this.txtTall1.Size = new System.Drawing.Size(173, 23);
            this.txtTall1.TabIndex = 1;
            // 
            // txtTall2
            // 
            this.txtTall2.Location = new System.Drawing.Point(23, 262);
            this.txtTall2.Name = "txtTall2";
            this.txtTall2.Size = new System.Drawing.Size(173, 23);
            this.txtTall2.TabIndex = 1;
            // 
            // lblRegneart
            // 
            this.lblRegneart.AutoSize = true;
            this.lblRegneart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegneart.Location = new System.Drawing.Point(92, 184);
            this.lblRegneart.Name = "lblRegneart";
            this.lblRegneart.Size = new System.Drawing.Size(30, 31);
            this.lblRegneart.TabIndex = 2;
            this.lblRegneart.Text = "+";
            // 
            // btnErLik
            // 
            this.btnErLik.Location = new System.Drawing.Point(222, 191);
            this.btnErLik.Name = "btnErLik";
            this.btnErLik.Size = new System.Drawing.Size(26, 23);
            this.btnErLik.TabIndex = 3;
            this.btnErLik.Text = "=";
            this.btnErLik.Click += new System.EventHandler(this.BtnErLik_Click);
            // 
            // txtSvar
            // 
            this.txtSvar.Location = new System.Drawing.Point(272, 191);
            this.txtSvar.Name = "txtSvar";
            this.txtSvar.Size = new System.Drawing.Size(175, 23);
            this.txtSvar.TabIndex = 4;
            // 
            // btnVisk
            // 
            this.btnVisk.Location = new System.Drawing.Point(451, 294);
            this.btnVisk.Name = "btnVisk";
            this.btnVisk.Size = new System.Drawing.Size(75, 23);
            this.btnVisk.TabIndex = 5;
            this.btnVisk.Text = "Visk";
            this.btnVisk.Click += new System.EventHandler(this.BtnVisk_Click);
            // 
            // btnAvslutt
            // 
            this.btnAvslutt.Location = new System.Drawing.Point(451, 336);
            this.btnAvslutt.Name = "btnAvslutt";
            this.btnAvslutt.Size = new System.Drawing.Size(75, 23);
            this.btnAvslutt.TabIndex = 6;
            this.btnAvslutt.Text = "Avslutt";
            this.btnAvslutt.Click += new System.EventHandler(this.BtnAvslutt_Click);
            // 
            // frmKalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 389);
            this.Controls.Add(this.btnAvslutt);
            this.Controls.Add(this.btnVisk);
            this.Controls.Add(this.txtSvar);
            this.Controls.Add(this.btnErLik);
            this.Controls.Add(this.lblRegneart);
            this.Controls.Add(this.txtTall2);
            this.Controls.Add(this.txtTall1);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmKalkulator";
            this.Resizable = false;
            this.Text = "Kalkulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmKalkulator_FormClosed);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuModus;
        private System.Windows.Forms.ToolStripMenuItem mnuBasisk;
        private System.Windows.Forms.ToolStripMenuItem mnuAvansert;
        private System.Windows.Forms.ToolStripMenuItem mnuRegneart;
        private System.Windows.Forms.ToolStripMenuItem mnuPluss;
        private System.Windows.Forms.ToolStripMenuItem mnuMinus;
        private System.Windows.Forms.ToolStripMenuItem mnuGange;
        private System.Windows.Forms.ToolStripMenuItem mnuDeling;
        private System.Windows.Forms.ToolStripMenuItem mnuHjelp;
        private MetroFramework.Controls.MetroTextBox txtTall1;
        private MetroFramework.Controls.MetroTextBox txtTall2;
        private System.Windows.Forms.Label lblRegneart;
        private MetroFramework.Controls.MetroButton btnErLik;
        private MetroFramework.Controls.MetroTextBox txtSvar;
        private MetroFramework.Controls.MetroButton btnVisk;
        private MetroFramework.Controls.MetroButton btnAvslutt;
    }
}

