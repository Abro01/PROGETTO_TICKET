
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lDescrizione = new System.Windows.Forms.Label();
            this.lTitolo = new System.Windows.Forms.Label();
            this.lPrezzo = new System.Windows.Forms.Label();
            this.cbNumBiglietti = new System.Windows.Forms.ComboBox();
            this.lLuogo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 74);
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
            this.lDescrizione.Location = new System.Drawing.Point(304, 74);
            this.lDescrizione.Name = "lDescrizione";
            this.lDescrizione.Size = new System.Drawing.Size(0, 13);
            this.lDescrizione.TabIndex = 3;
            // 
            // lTitolo
            // 
            this.lTitolo.AutoSize = true;
            this.lTitolo.Location = new System.Drawing.Point(95, 13);
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
            this.cbNumBiglietti.Location = new System.Drawing.Point(374, 338);
            this.cbNumBiglietti.Name = "cbNumBiglietti";
            this.cbNumBiglietti.Size = new System.Drawing.Size(121, 21);
            this.cbNumBiglietti.TabIndex = 6;
            // 
            // lLuogo
            // 
            this.lLuogo.AutoSize = true;
            this.lLuogo.Location = new System.Drawing.Point(643, 13);
            this.lLuogo.Name = "lLuogo";
            this.lLuogo.Size = new System.Drawing.Size(37, 13);
            this.lLuogo.TabIndex = 7;
            this.lLuogo.Text = "Luogo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dove:";
            // 
            // EventiInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}