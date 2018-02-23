namespace Copper
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttnSnipes = new MetroFramework.Controls.MetroButton();
            this.bttnkickz = new MetroFramework.Controls.MetroButton();
            this.bttnalllike = new MetroFramework.Controls.MetroButton();
            this.bttnadidas = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // bttnSnipes
            // 
            this.bttnSnipes.Highlight = true;
            this.bttnSnipes.Location = new System.Drawing.Point(24, 64);
            this.bttnSnipes.Name = "bttnSnipes";
            this.bttnSnipes.Size = new System.Drawing.Size(119, 39);
            this.bttnSnipes.Style = MetroFramework.MetroColorStyle.Red;
            this.bttnSnipes.TabIndex = 0;
            this.bttnSnipes.Text = "Snipes";
            this.bttnSnipes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bttnSnipes.Click += new System.EventHandler(this.bttnSnipes_Click);
            // 
            // bttnkickz
            // 
            this.bttnkickz.Highlight = true;
            this.bttnkickz.Location = new System.Drawing.Point(233, 64);
            this.bttnkickz.Name = "bttnkickz";
            this.bttnkickz.Size = new System.Drawing.Size(119, 39);
            this.bttnkickz.Style = MetroFramework.MetroColorStyle.Red;
            this.bttnkickz.TabIndex = 1;
            this.bttnkickz.Text = "Kickz";
            this.bttnkickz.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bttnkickz.Click += new System.EventHandler(this.bttnkickz_Click);
            // 
            // bttnalllike
            // 
            this.bttnalllike.Highlight = true;
            this.bttnalllike.Location = new System.Drawing.Point(24, 144);
            this.bttnalllike.Name = "bttnalllike";
            this.bttnalllike.Size = new System.Drawing.Size(119, 39);
            this.bttnalllike.Style = MetroFramework.MetroColorStyle.Red;
            this.bttnalllike.TabIndex = 2;
            this.bttnalllike.Text = "AllLike";
            this.bttnalllike.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bttnalllike.Click += new System.EventHandler(this.bttnalllike_Click);
            // 
            // bttnadidas
            // 
            this.bttnadidas.Highlight = true;
            this.bttnadidas.Location = new System.Drawing.Point(233, 144);
            this.bttnadidas.Name = "bttnadidas";
            this.bttnadidas.Size = new System.Drawing.Size(119, 39);
            this.bttnadidas.Style = MetroFramework.MetroColorStyle.Red;
            this.bttnadidas.TabIndex = 3;
            this.bttnadidas.Text = "Adidas";
            this.bttnadidas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bttnadidas.Click += new System.EventHandler(this.bttnadidas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 207);
            this.Controls.Add(this.bttnadidas);
            this.Controls.Add(this.bttnalllike);
            this.Controls.Add(this.bttnkickz);
            this.Controls.Add(this.bttnSnipes);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Start Screen";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton bttnSnipes;
        private MetroFramework.Controls.MetroButton bttnkickz;
        private MetroFramework.Controls.MetroButton bttnalllike;
        private MetroFramework.Controls.MetroButton bttnadidas;
    }
}

