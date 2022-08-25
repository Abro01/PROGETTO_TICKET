namespace DesignProject
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnImpostazioni = new System.Windows.Forms.Button();
            this.btnProfilo = new System.Windows.Forms.Button();
            this.btnCarrello = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlTitolo = new System.Windows.Forms.Panel();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.pnlTitolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnImpostazioni);
            this.pnlMenu.Controls.Add(this.btnProfilo);
            this.pnlMenu.Controls.Add(this.btnCarrello);
            this.pnlMenu.Controls.Add(this.btnCerca);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 744);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 380);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 60);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnImpostazioni
            // 
            this.btnImpostazioni.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImpostazioni.FlatAppearance.BorderSize = 0;
            this.btnImpostazioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpostazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpostazioni.ForeColor = System.Drawing.Color.White;
            this.btnImpostazioni.Image = ((System.Drawing.Image)(resources.GetObject("btnImpostazioni.Image")));
            this.btnImpostazioni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpostazioni.Location = new System.Drawing.Point(0, 320);
            this.btnImpostazioni.Name = "btnImpostazioni";
            this.btnImpostazioni.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnImpostazioni.Size = new System.Drawing.Size(220, 60);
            this.btnImpostazioni.TabIndex = 5;
            this.btnImpostazioni.Text = "  Impostazioni";
            this.btnImpostazioni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpostazioni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImpostazioni.UseVisualStyleBackColor = true;
            this.btnImpostazioni.Click += new System.EventHandler(this.btnImpostazioni_Click);
            // 
            // btnProfilo
            // 
            this.btnProfilo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfilo.FlatAppearance.BorderSize = 0;
            this.btnProfilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilo.ForeColor = System.Drawing.Color.White;
            this.btnProfilo.Image = ((System.Drawing.Image)(resources.GetObject("btnProfilo.Image")));
            this.btnProfilo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfilo.Location = new System.Drawing.Point(0, 260);
            this.btnProfilo.Name = "btnProfilo";
            this.btnProfilo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProfilo.Size = new System.Drawing.Size(220, 60);
            this.btnProfilo.TabIndex = 4;
            this.btnProfilo.Text = "  Il mio account";
            this.btnProfilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfilo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfilo.UseVisualStyleBackColor = true;
            this.btnProfilo.Click += new System.EventHandler(this.btnProfilo_Click);
            // 
            // btnCarrello
            // 
            this.btnCarrello.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCarrello.FlatAppearance.BorderSize = 0;
            this.btnCarrello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrello.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrello.ForeColor = System.Drawing.Color.White;
            this.btnCarrello.Image = ((System.Drawing.Image)(resources.GetObject("btnCarrello.Image")));
            this.btnCarrello.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrello.Location = new System.Drawing.Point(0, 200);
            this.btnCarrello.Name = "btnCarrello";
            this.btnCarrello.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCarrello.Size = new System.Drawing.Size(220, 60);
            this.btnCarrello.TabIndex = 3;
            this.btnCarrello.Text = "  Carrello";
            this.btnCarrello.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrello.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarrello.UseVisualStyleBackColor = true;
            this.btnCarrello.Click += new System.EventHandler(this.btnCarrello_Click);
            // 
            // btnCerca
            // 
            this.btnCerca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerca.FlatAppearance.BorderSize = 0;
            this.btnCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerca.ForeColor = System.Drawing.Color.White;
            this.btnCerca.Image = ((System.Drawing.Image)(resources.GetObject("btnCerca.Image")));
            this.btnCerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerca.Location = new System.Drawing.Point(0, 140);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCerca.Size = new System.Drawing.Size(220, 60);
            this.btnCerca.TabIndex = 2;
            this.btnCerca.Text = "  Cerca";
            this.btnCerca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 80);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 80);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlTitolo
            // 
            this.pnlTitolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTitolo.Controls.Add(this.lblTitolo);
            this.pnlTitolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitolo.Location = new System.Drawing.Point(220, 0);
            this.pnlTitolo.Name = "pnlTitolo";
            this.pnlTitolo.Size = new System.Drawing.Size(1258, 80);
            this.pnlTitolo.TabIndex = 1;
            // 
            // lblTitolo
            // 
            this.lblTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.ForeColor = System.Drawing.Color.White;
            this.lblTitolo.Location = new System.Drawing.Point(579, 19);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(116, 37);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "HOME";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.pnlTitolo);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitolo.ResumeLayout(false);
            this.pnlTitolo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnImpostazioni;
        private System.Windows.Forms.Button btnProfilo;
        private System.Windows.Forms.Button btnCarrello;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTitolo;
        private System.Windows.Forms.Label lblTitolo;
    }
}

