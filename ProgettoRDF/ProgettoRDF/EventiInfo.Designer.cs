
namespace ProgettoRDF
{
    partial class EventiInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventiInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lDescrizione = new System.Windows.Forms.Label();
            this.lTitolo = new System.Windows.Forms.Label();
            this.lPrezzo = new System.Windows.Forms.Label();
            this.cbNumBiglietti = new System.Windows.Forms.ComboBox();
            this.lLuogo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProfilo = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.btnAcquista = new ProgettoRDF.Elementi.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INFO EVENTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "SELEZIONA IL NUMERO DI BIGLIETTI DA ACQUiSTARE:\r\n(MAX 4 BIGLIETTI PER ACCOUNT)\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PREZZO TOTALE:";
            // 
            // lDescrizione
            // 
            this.lDescrizione.AutoSize = true;
            this.lDescrizione.Location = new System.Drawing.Point(316, 147);
            this.lDescrizione.Name = "lDescrizione";
            this.lDescrizione.Size = new System.Drawing.Size(0, 13);
            this.lDescrizione.TabIndex = 3;
            // 
            // lTitolo
            // 
            this.lTitolo.AutoSize = true;
            this.lTitolo.Location = new System.Drawing.Point(107, 86);
            this.lTitolo.Name = "lTitolo";
            this.lTitolo.Size = new System.Drawing.Size(29, 13);
            this.lTitolo.TabIndex = 4;
            this.lTitolo.Text = "titolo";
            // 
            // lPrezzo
            // 
            this.lPrezzo.AutoSize = true;
            this.lPrezzo.Location = new System.Drawing.Point(660, 341);
            this.lPrezzo.Name = "lPrezzo";
            this.lPrezzo.Size = new System.Drawing.Size(38, 13);
            this.lPrezzo.TabIndex = 5;
            this.lPrezzo.Text = "prezzo";
            // 
            // cbNumBiglietti
            // 
            this.cbNumBiglietti.FormattingEnabled = true;
            this.cbNumBiglietti.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbNumBiglietti.Location = new System.Drawing.Point(374, 338);
            this.cbNumBiglietti.Name = "cbNumBiglietti";
            this.cbNumBiglietti.Size = new System.Drawing.Size(121, 21);
            this.cbNumBiglietti.TabIndex = 6;
            this.cbNumBiglietti.SelectedIndexChanged += new System.EventHandler(this.cbNumBiglietti_SelectedIndexChanged);
            // 
            // lLuogo
            // 
            this.lLuogo.AutoSize = true;
            this.lLuogo.Location = new System.Drawing.Point(655, 86);
            this.lLuogo.Name = "lLuogo";
            this.lLuogo.Size = new System.Drawing.Size(37, 13);
            this.lLuogo.TabIndex = 7;
            this.lLuogo.Text = "Luogo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dove:";
            // 
            // btnProfilo
            // 
            this.btnProfilo.Image = ((System.Drawing.Image)(resources.GetObject("btnProfilo.Image")));
            this.btnProfilo.Location = new System.Drawing.Point(41, 11);
            this.btnProfilo.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfilo.Name = "btnProfilo";
            this.btnProfilo.Size = new System.Drawing.Size(34, 32);
            this.btnProfilo.TabIndex = 24;
            this.btnProfilo.TabStop = false;
            this.btnProfilo.Click += new System.EventHandler(this.btnProfilo_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(3, 11);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(34, 32);
            this.btnHome.TabIndex = 23;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(761, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(28, 32);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAcquista
            // 
            this.btnAcquista.BackColor = System.Drawing.Color.White;
            this.btnAcquista.BackgroundColor = System.Drawing.Color.White;
            this.btnAcquista.Colore_bordo = System.Drawing.Color.Red;
            this.btnAcquista.FlatAppearance.BorderSize = 0;
            this.btnAcquista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcquista.ForeColor = System.Drawing.Color.Red;
            this.btnAcquista.Location = new System.Drawing.Point(601, 413);
            this.btnAcquista.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcquista.Name = "btnAcquista";
            this.btnAcquista.Radius_bordo = 40;
            this.btnAcquista.Size = new System.Drawing.Size(111, 39);
            this.btnAcquista.Size_bordo = 2;
            this.btnAcquista.TabIndex = 25;
            this.btnAcquista.Text = "ACQUISTA";
            this.btnAcquista.TextColor = System.Drawing.Color.Red;
            this.btnAcquista.UseVisualStyleBackColor = false;
            this.btnAcquista.Click += new System.EventHandler(this.btnAcquista_Click);
            // 
            // EventiInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 502);
            this.Controls.Add(this.btnAcquista);
            this.Controls.Add(this.btnProfilo);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lLuogo);
            this.Controls.Add(this.cbNumBiglietti);
            this.Controls.Add(this.lPrezzo);
            this.Controls.Add(this.lTitolo);
            this.Controls.Add(this.lDescrizione);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EventiInfo";
            this.Text = "\\";
            this.Load += new System.EventHandler(this.EventiInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnProfilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lDescrizione;
        private System.Windows.Forms.Label lTitolo;
        private System.Windows.Forms.Label lPrezzo;
        private System.Windows.Forms.ComboBox cbNumBiglietti;
        private System.Windows.Forms.Label lLuogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnProfilo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnLogout;
        private Elementi.RJButton btnAcquista;
    }
}