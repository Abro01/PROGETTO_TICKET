namespace ProgettoRDF
{
    partial class FormInterfacciaUtente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInterfacciaUtente));
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlTitolo = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnImpostazioni = new System.Windows.Forms.Button();
            this.btnProfilo = new System.Windows.Forms.Button();
            this.btnCarrello = new System.Windows.Forms.Button();
            this.btnCerca = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDesktop.SuspendLayout();
            this.pnlTitolo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Controls.Add(this.pnlTitolo);
            this.pnlDesktop.Controls.Add(this.pictureBox1);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(220, 0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1258, 744);
            this.pnlDesktop.TabIndex = 4;
            // 
            // pnlTitolo
            // 
            this.pnlTitolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTitolo.Controls.Add(this.btnMinimize);
            this.pnlTitolo.Controls.Add(this.btnMaximize);
            this.pnlTitolo.Controls.Add(this.btnClose);
            this.pnlTitolo.Controls.Add(this.btnCloseChildForm);
            this.pnlTitolo.Controls.Add(this.lblTitolo);
            this.pnlTitolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitolo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitolo.Name = "pnlTitolo";
            this.pnlTitolo.Size = new System.Drawing.Size(1258, 80);
            this.pnlTitolo.TabIndex = 2;
            this.pnlTitolo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitolo_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1120, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(42, 38);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1168, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(42, 41);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1213, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 44);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.pnlMenu.TabIndex = 3;
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
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(220, 80);
            this.pnlLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "AP";
            // 
            // FormInterfacciaUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FormInterfacciaUtente";
            this.Text = "FormInterfacciaUtente";
            this.Load += new System.EventHandler(this.FormInterfacciaUtente_Load);
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            this.pnlTitolo.ResumeLayout(false);
            this.pnlTitolo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Panel pnlTitolo;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnImpostazioni;
        private System.Windows.Forms.Button btnProfilo;
        private System.Windows.Forms.Button btnCarrello;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label label1;
    }
}