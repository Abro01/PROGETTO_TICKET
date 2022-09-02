namespace ProgettoRDF.Forms.CEO
{
    partial class FormInfoEventi
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
            this.dtUtenti = new System.Windows.Forms.DataGridView();
            this.lblTitolo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtUtenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dtUtenti
            // 
            this.dtUtenti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUtenti.Location = new System.Drawing.Point(161, 100);
            this.dtUtenti.Name = "dtUtenti";
            this.dtUtenti.RowHeadersWidth = 62;
            this.dtUtenti.RowTemplate.Height = 28;
            this.dtUtenti.Size = new System.Drawing.Size(937, 456);
            this.dtUtenti.TabIndex = 0;
            // 
            // lblTitolo
            // 
            this.lblTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(476, 36);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(307, 35);
            this.lblTitolo.TabIndex = 1;
            this.lblTitolo.Text = "BIGLIETTI ACQUISTATI DA\r\n";
            // 
            // FormInfoEventi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 608);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.dtUtenti);
            this.Name = "FormInfoEventi";
            this.Text = "FormInfoEventi";
            this.Load += new System.EventHandler(this.FormInfoEventi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtUtenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtUtenti;
        private System.Windows.Forms.Label lblTitolo;
    }
}