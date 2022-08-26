namespace ProgettoRDF.Forms.Utente
{
    partial class FormRicercaUtente
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
            this.btnCerca = new ProgettoRDF.Elementi.RJButton();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.txtNomeEvento = new System.Windows.Forms.TextBox();
            this.dtRisultati = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtRisultati)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerca
            // 
            this.btnCerca.BackColor = System.Drawing.Color.White;
            this.btnCerca.BackgroundColor = System.Drawing.Color.White;
            this.btnCerca.Colore_bordo = System.Drawing.Color.Red;
            this.btnCerca.FlatAppearance.BorderSize = 0;
            this.btnCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerca.ForeColor = System.Drawing.Color.Red;
            this.btnCerca.Location = new System.Drawing.Point(884, 88);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Radius_bordo = 40;
            this.btnCerca.Size = new System.Drawing.Size(148, 45);
            this.btnCerca.Size_bordo = 2;
            this.btnCerca.TabIndex = 21;
            this.btnCerca.Text = "CERCA";
            this.btnCerca.TextColor = System.Drawing.Color.Red;
            this.btnCerca.UseVisualStyleBackColor = false;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.Location = new System.Drawing.Point(241, 88);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(177, 35);
            this.lblNomeEvento.TabIndex = 20;
            this.lblNomeEvento.Text = "Nome Evento:";
            // 
            // txtNomeEvento
            // 
            this.txtNomeEvento.Location = new System.Drawing.Point(448, 97);
            this.txtNomeEvento.Name = "txtNomeEvento";
            this.txtNomeEvento.Size = new System.Drawing.Size(404, 26);
            this.txtNomeEvento.TabIndex = 19;
            // 
            // dtRisultati
            // 
            this.dtRisultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRisultati.Location = new System.Drawing.Point(138, 188);
            this.dtRisultati.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtRisultati.Name = "dtRisultati";
            this.dtRisultati.RowHeadersWidth = 62;
            this.dtRisultati.Size = new System.Drawing.Size(1000, 348);
            this.dtRisultati.TabIndex = 18;
            this.dtRisultati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRisultati_CellContentClick);
            // 
            // FormRicercaUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 608);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.lblNomeEvento);
            this.Controls.Add(this.txtNomeEvento);
            this.Controls.Add(this.dtRisultati);
            this.Name = "FormRicercaUtente";
            this.Text = "FormRicercaUtente";
            this.Load += new System.EventHandler(this.FormRicercaUtente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRisultati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elementi.RJButton btnCerca;
        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.TextBox txtNomeEvento;
        private System.Windows.Forms.DataGridView dtRisultati;
    }
}