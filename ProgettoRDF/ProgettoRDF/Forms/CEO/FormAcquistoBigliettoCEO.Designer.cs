namespace ProgettoRDF.Forms.CEO
{
    partial class FormAcquistoBigliettoCEO
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
            this.cbPremium = new System.Windows.Forms.CheckBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lPrezzo = new System.Windows.Forms.Label();
            this.lblScelta = new System.Windows.Forms.Label();
            this.btnAcquista = new ProgettoRDF.Elementi.RJButton();
            this.lblOrganizzazione2 = new System.Windows.Forms.Label();
            this.lblPosti2 = new System.Windows.Forms.Label();
            this.lblDescrizione2 = new System.Windows.Forms.Label();
            this.lblLuogo2 = new System.Windows.Forms.Label();
            this.lblGenere2 = new System.Windows.Forms.Label();
            this.lblOrganizzazione = new System.Windows.Forms.Label();
            this.lblGenere = new System.Windows.Forms.Label();
            this.lblLuogo = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblPosti = new System.Windows.Forms.Label();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.cbNumBig = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbPremium
            // 
            this.cbPremium.AutoSize = true;
            this.cbPremium.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPremium.Location = new System.Drawing.Point(134, 497);
            this.cbPremium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPremium.Name = "cbPremium";
            this.cbPremium.Size = new System.Drawing.Size(262, 28);
            this.cbPremium.TabIndex = 55;
            this.cbPremium.Text = "Premium( +50€  a biglietto)";
            this.cbPremium.UseVisualStyleBackColor = true;
            // 
            // lblCosto
            // 
            this.lblCosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(718, 481);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(139, 24);
            this.lblCosto.TabIndex = 54;
            this.lblCosto.Text = "COSTO TOTALE:";
            // 
            // lPrezzo
            // 
            this.lPrezzo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPrezzo.AutoSize = true;
            this.lPrezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrezzo.Location = new System.Drawing.Point(764, 516);
            this.lPrezzo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPrezzo.Name = "lPrezzo";
            this.lPrezzo.Size = new System.Drawing.Size(34, 25);
            this.lPrezzo.TabIndex = 53;
            this.lPrezzo.Text = "20";
            // 
            // lblScelta
            // 
            this.lblScelta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblScelta.AutoSize = true;
            this.lblScelta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScelta.Location = new System.Drawing.Point(129, 425);
            this.lblScelta.Name = "lblScelta";
            this.lblScelta.Size = new System.Drawing.Size(598, 29);
            this.lblScelta.TabIndex = 52;
            this.lblScelta.Text = "Scegliere il numero di biglietti da acquistare (min: 1, max: 4)";
            this.lblScelta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAcquista
            // 
            this.btnAcquista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAcquista.BackColor = System.Drawing.Color.White;
            this.btnAcquista.BackgroundColor = System.Drawing.Color.White;
            this.btnAcquista.Colore_bordo = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAcquista.FlatAppearance.BorderSize = 0;
            this.btnAcquista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcquista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAcquista.Location = new System.Drawing.Point(941, 481);
            this.btnAcquista.Name = "btnAcquista";
            this.btnAcquista.Radius_bordo = 40;
            this.btnAcquista.Size = new System.Drawing.Size(166, 60);
            this.btnAcquista.Size_bordo = 2;
            this.btnAcquista.TabIndex = 51;
            this.btnAcquista.Text = "ACQUISTA";
            this.btnAcquista.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAcquista.UseVisualStyleBackColor = false;
            this.btnAcquista.Click += new System.EventHandler(this.btnAcquista_Click);
            // 
            // lblOrganizzazione2
            // 
            this.lblOrganizzazione2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrganizzazione2.AutoSize = true;
            this.lblOrganizzazione2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizzazione2.Location = new System.Drawing.Point(333, 353);
            this.lblOrganizzazione2.Name = "lblOrganizzazione2";
            this.lblOrganizzazione2.Size = new System.Drawing.Size(74, 29);
            this.lblOrganizzazione2.TabIndex = 50;
            this.lblOrganizzazione2.Text = "label6";
            // 
            // lblPosti2
            // 
            this.lblPosti2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPosti2.AutoSize = true;
            this.lblPosti2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosti2.Location = new System.Drawing.Point(333, 304);
            this.lblPosti2.Name = "lblPosti2";
            this.lblPosti2.Size = new System.Drawing.Size(74, 29);
            this.lblPosti2.TabIndex = 49;
            this.lblPosti2.Text = "label5";
            // 
            // lblDescrizione2
            // 
            this.lblDescrizione2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescrizione2.AutoSize = true;
            this.lblDescrizione2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrizione2.Location = new System.Drawing.Point(333, 253);
            this.lblDescrizione2.Name = "lblDescrizione2";
            this.lblDescrizione2.Size = new System.Drawing.Size(74, 29);
            this.lblDescrizione2.TabIndex = 48;
            this.lblDescrizione2.Text = "label4";
            // 
            // lblLuogo2
            // 
            this.lblLuogo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLuogo2.AutoSize = true;
            this.lblLuogo2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuogo2.Location = new System.Drawing.Point(333, 204);
            this.lblLuogo2.Name = "lblLuogo2";
            this.lblLuogo2.Size = new System.Drawing.Size(74, 29);
            this.lblLuogo2.TabIndex = 47;
            this.lblLuogo2.Text = "label3";
            // 
            // lblGenere2
            // 
            this.lblGenere2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGenere2.AutoSize = true;
            this.lblGenere2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenere2.Location = new System.Drawing.Point(333, 153);
            this.lblGenere2.Name = "lblGenere2";
            this.lblGenere2.Size = new System.Drawing.Size(74, 29);
            this.lblGenere2.TabIndex = 46;
            this.lblGenere2.Text = "label1";
            // 
            // lblOrganizzazione
            // 
            this.lblOrganizzazione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrganizzazione.AutoSize = true;
            this.lblOrganizzazione.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizzazione.Location = new System.Drawing.Point(129, 353);
            this.lblOrganizzazione.Name = "lblOrganizzazione";
            this.lblOrganizzazione.Size = new System.Drawing.Size(173, 29);
            this.lblOrganizzazione.TabIndex = 45;
            this.lblOrganizzazione.Text = "Organizzazione:";
            // 
            // lblGenere
            // 
            this.lblGenere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGenere.AutoSize = true;
            this.lblGenere.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenere.Location = new System.Drawing.Point(129, 153);
            this.lblGenere.Name = "lblGenere";
            this.lblGenere.Size = new System.Drawing.Size(93, 29);
            this.lblGenere.TabIndex = 44;
            this.lblGenere.Text = "Genere:";
            // 
            // lblLuogo
            // 
            this.lblLuogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLuogo.AutoSize = true;
            this.lblLuogo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuogo.Location = new System.Drawing.Point(129, 204);
            this.lblLuogo.Name = "lblLuogo";
            this.lblLuogo.Size = new System.Drawing.Size(80, 29);
            this.lblLuogo.TabIndex = 43;
            this.lblLuogo.Text = "Luogo:";
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrizione.Location = new System.Drawing.Point(129, 253);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(136, 29);
            this.lblDescrizione.TabIndex = 42;
            this.lblDescrizione.Text = "Descrizione:";
            // 
            // lblPosti
            // 
            this.lblPosti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPosti.AutoSize = true;
            this.lblPosti.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosti.Location = new System.Drawing.Point(129, 304);
            this.lblPosti.Name = "lblPosti";
            this.lblPosti.Size = new System.Drawing.Size(158, 29);
            this.lblPosti.TabIndex = 41;
            this.lblPosti.Text = "Numero posti:";
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.Location = new System.Drawing.Point(519, 72);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(221, 44);
            this.lblNomeEvento.TabIndex = 40;
            this.lblNomeEvento.Text = "Nome evento";
            // 
            // cbNumBig
            // 
            this.cbNumBig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNumBig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumBig.FormattingEnabled = true;
            this.cbNumBig.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbNumBig.Location = new System.Drawing.Point(466, 498);
            this.cbNumBig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNumBig.Name = "cbNumBig";
            this.cbNumBig.Size = new System.Drawing.Size(180, 28);
            this.cbNumBig.TabIndex = 56;
            this.cbNumBig.SelectedIndexChanged += new System.EventHandler(this.cbNumBig_SelectedIndexChanged);
            // 
            // FormAcquistoBigliettoCEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 608);
            this.Controls.Add(this.cbNumBig);
            this.Controls.Add(this.cbPremium);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lPrezzo);
            this.Controls.Add(this.lblScelta);
            this.Controls.Add(this.btnAcquista);
            this.Controls.Add(this.lblOrganizzazione2);
            this.Controls.Add(this.lblPosti2);
            this.Controls.Add(this.lblDescrizione2);
            this.Controls.Add(this.lblLuogo2);
            this.Controls.Add(this.lblGenere2);
            this.Controls.Add(this.lblOrganizzazione);
            this.Controls.Add(this.lblGenere);
            this.Controls.Add(this.lblLuogo);
            this.Controls.Add(this.lblDescrizione);
            this.Controls.Add(this.lblPosti);
            this.Controls.Add(this.lblNomeEvento);
            this.Name = "FormAcquistoBigliettoCEO";
            this.Text = "FormAcquistoBigliettoCEO";
            this.Load += new System.EventHandler(this.FormAcquistoBigliettoCEO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbPremium;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lPrezzo;
        private System.Windows.Forms.Label lblScelta;
        private Elementi.RJButton btnAcquista;
        private System.Windows.Forms.Label lblOrganizzazione2;
        private System.Windows.Forms.Label lblPosti2;
        private System.Windows.Forms.Label lblDescrizione2;
        private System.Windows.Forms.Label lblLuogo2;
        private System.Windows.Forms.Label lblGenere2;
        private System.Windows.Forms.Label lblOrganizzazione;
        private System.Windows.Forms.Label lblGenere;
        private System.Windows.Forms.Label lblLuogo;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.Label lblPosti;
        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.ComboBox cbNumBig;
    }
}