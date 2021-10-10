namespace a_grund_farbfuellung
{
    partial class Farbabfuellung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farbabfuellung));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cb_giftig = new System.Windows.Forms.CheckBox();
            this.cb_feuer = new System.Windows.Forms.CheckBox();
            this.pb_behaelter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_behaelter)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_giftig
            // 
            this.cb_giftig.AutoSize = true;
            this.cb_giftig.Location = new System.Drawing.Point(27, 17);
            this.cb_giftig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_giftig.Name = "cb_giftig";
            this.cb_giftig.Size = new System.Drawing.Size(94, 17);
            this.cb_giftig.TabIndex = 1;
            this.cb_giftig.Text = "Farbe ist giftig!";
            this.cb_giftig.UseVisualStyleBackColor = true;
            this.cb_giftig.CheckedChanged += new System.EventHandler(this.ColorPropertyChanged);
            // 
            // cb_feuer
            // 
            this.cb_feuer.AutoSize = true;
            this.cb_feuer.Location = new System.Drawing.Point(27, 39);
            this.cb_feuer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_feuer.Name = "cb_feuer";
            this.cb_feuer.Size = new System.Drawing.Size(142, 17);
            this.cb_feuer.TabIndex = 2;
            this.cb_feuer.Text = "Farbe ist feuergefährlich!";
            this.cb_feuer.UseVisualStyleBackColor = true;
            this.cb_feuer.CheckedChanged += new System.EventHandler(this.ColorPropertyChanged);
            // 
            // pb_behaelter
            // 
            this.pb_behaelter.BackColor = System.Drawing.SystemColors.Window;
            this.pb_behaelter.ErrorImage = null;
            this.pb_behaelter.Image = ((System.Drawing.Image)(resources.GetObject("pb_behaelter.Image")));
            this.pb_behaelter.InitialImage = null;
            this.pb_behaelter.Location = new System.Drawing.Point(141, 115);
            this.pb_behaelter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_behaelter.Name = "pb_behaelter";
            this.pb_behaelter.Size = new System.Drawing.Size(265, 266);
            this.pb_behaelter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_behaelter.TabIndex = 3;
            this.pb_behaelter.TabStop = false;
            // 
            // Farbabfuellung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 439);
            this.Controls.Add(this.pb_behaelter);
            this.Controls.Add(this.cb_feuer);
            this.Controls.Add(this.cb_giftig);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Farbabfuellung";
            this.Text = "Farbabfüllung";
            ((System.ComponentModel.ISupportInitialize)(this.pb_behaelter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox cb_giftig;
        private System.Windows.Forms.CheckBox cb_feuer;
        private System.Windows.Forms.PictureBox pb_behaelter;
    }
}

