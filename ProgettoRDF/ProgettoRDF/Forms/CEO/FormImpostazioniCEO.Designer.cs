namespace ProgettoRDF.Forms.CEO
{
    partial class FormImpostazioniCEO
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
            this.btnModifica = new ProgettoRDF.Elementi.RJButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitoloImpo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifica
            // 
            this.btnModifica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifica.BackColor = System.Drawing.Color.White;
            this.btnModifica.BackgroundColor = System.Drawing.Color.White;
            this.btnModifica.Colore_bordo = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnModifica.FlatAppearance.BorderSize = 0;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnModifica.Location = new System.Drawing.Point(551, 430);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Radius_bordo = 40;
            this.btnModifica.Size = new System.Drawing.Size(166, 60);
            this.btnModifica.Size_bordo = 2;
            this.btnModifica.TabIndex = 43;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(637, 329);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 26);
            this.txtEmail.TabIndex = 42;
            // 
            // txtCognome
            // 
            this.txtCognome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCognome.Location = new System.Drawing.Point(637, 268);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(232, 26);
            this.txtCognome.TabIndex = 40;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(637, 211);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 26);
            this.txtNome.TabIndex = 39;
            // 
            // lblCognome
            // 
            this.lblCognome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(424, 260);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(133, 35);
            this.lblCognome.TabIndex = 38;
            this.lblCognome.Text = "Cognome:";
            this.lblCognome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(424, 321);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(88, 35);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(424, 203);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(93, 35);
            this.lblNome.TabIndex = 35;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitoloImpo
            // 
            this.lblTitoloImpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitoloImpo.AutoSize = true;
            this.lblTitoloImpo.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitoloImpo.Location = new System.Drawing.Point(466, 88);
            this.lblTitoloImpo.Name = "lblTitoloImpo";
            this.lblTitoloImpo.Size = new System.Drawing.Size(337, 49);
            this.lblTitoloImpo.TabIndex = 34;
            this.lblTitoloImpo.Text = "Modifica i tuoi dati";
            // 
            // FormImpostazioniCEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 608);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitoloImpo);
            this.Name = "FormImpostazioniCEO";
            this.Text = "Impostazioni";
            this.Load += new System.EventHandler(this.FormImpostazioniCEO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elementi.RJButton btnModifica;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTitoloImpo;
    }
}