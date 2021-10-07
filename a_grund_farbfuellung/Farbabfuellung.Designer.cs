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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cb_giftig = new System.Windows.Forms.CheckBox();
            this.cb_feuer = new System.Windows.Forms.CheckBox();
            this.pb_behaelter = new System.Windows.Forms.PictureBox();
            this.pb_behaelter_2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_behaelter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_behaelter_2)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_giftig
            // 
            this.cb_giftig.AutoSize = true;
            this.cb_giftig.Location = new System.Drawing.Point(36, 21);
            this.cb_giftig.Name = "cb_giftig";
            this.cb_giftig.Size = new System.Drawing.Size(122, 21);
            this.cb_giftig.TabIndex = 1;
            this.cb_giftig.Text = "Farbe ist giftig!";
            this.cb_giftig.UseVisualStyleBackColor = true;
            this.cb_giftig.CheckedChanged += new System.EventHandler(this.ColorPropertyChanged);
            // 
            // cb_feuer
            // 
            this.cb_feuer.AutoSize = true;
            this.cb_feuer.Location = new System.Drawing.Point(36, 48);
            this.cb_feuer.Name = "cb_feuer";
            this.cb_feuer.Size = new System.Drawing.Size(187, 21);
            this.cb_feuer.TabIndex = 2;
            this.cb_feuer.Text = "Farbe ist feuergefährlich!";
            this.cb_feuer.UseVisualStyleBackColor = true;
            this.cb_feuer.CheckedChanged += new System.EventHandler(this.ColorPropertyChanged);
            // 
            // pb_behaelter
            // 
            this.pb_behaelter.Location = new System.Drawing.Point(80, 113);
            this.pb_behaelter.Name = "pb_behaelter";
            this.pb_behaelter.Size = new System.Drawing.Size(320, 320);
            this.pb_behaelter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_behaelter.TabIndex = 3;
            this.pb_behaelter.TabStop = false;
            // 
            // pb_behaelter_2
            // 
            this.pb_behaelter_2.Location = new System.Drawing.Point(406, 113);
            this.pb_behaelter_2.Name = "pb_behaelter_2";
            this.pb_behaelter_2.Size = new System.Drawing.Size(320, 320);
            this.pb_behaelter_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_behaelter_2.TabIndex = 4;
            this.pb_behaelter_2.TabStop = false;
            // 
            // Farbabfuellung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 540);
            this.Controls.Add(this.pb_behaelter_2);
            this.Controls.Add(this.pb_behaelter);
            this.Controls.Add(this.cb_feuer);
            this.Controls.Add(this.cb_giftig);
            this.Name = "Farbabfuellung";
            this.Text = "Farbabfüllung";
            ((System.ComponentModel.ISupportInitialize)(this.pb_behaelter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_behaelter_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox cb_giftig;
        private System.Windows.Forms.CheckBox cb_feuer;
        private System.Windows.Forms.PictureBox pb_behaelter;
        private System.Windows.Forms.PictureBox pb_behaelter_2;
    }
}

