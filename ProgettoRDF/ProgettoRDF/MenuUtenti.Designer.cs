namespace ProgettoRDF
{
    partial class MenuUtenti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtenti));
            this.btnProfilo = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.dtRisultati = new System.Windows.Forms.DataGridView();
            this.txtNomeEvento = new System.Windows.Forms.TextBox();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCerca = new ProgettoRDF.Elementi.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnProfilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRisultati)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProfilo
            // 
            this.btnProfilo.Image = ((System.Drawing.Image)(resources.GetObject("btnProfilo.Image")));
            this.btnProfilo.Location = new System.Drawing.Point(46, 8);
            this.btnProfilo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfilo.Name = "btnProfilo";
            this.btnProfilo.Size = new System.Drawing.Size(33, 32);
            this.btnProfilo.TabIndex = 2;
            this.btnProfilo.TabStop = false;
            this.btnProfilo.Click += new System.EventHandler(this.btnProfilo_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(8, 8);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(34, 32);
            this.btnHome.TabIndex = 3;
            this.btnHome.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.Location = new System.Drawing.Point(816, 8);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(28, 32);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dtRisultati
            // 
            this.dtRisultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRisultati.Location = new System.Drawing.Point(3, 100);
            this.dtRisultati.Name = "dtRisultati";
            this.dtRisultati.RowHeadersWidth = 62;
            this.dtRisultati.Size = new System.Drawing.Size(841, 226);
            this.dtRisultati.TabIndex = 5;
            this.dtRisultati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRisultati_CellContentClick);
            // 
            // txtNomeEvento
            // 
            this.txtNomeEvento.Location = new System.Drawing.Point(347, 51);
            this.txtNomeEvento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeEvento.Name = "txtNomeEvento";
            this.txtNomeEvento.Size = new System.Drawing.Size(143, 20);
            this.txtNomeEvento.TabIndex = 6;
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Location = new System.Drawing.Point(255, 53);
            this.lblNomeEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(75, 13);
            this.lblNomeEvento.TabIndex = 7;
            this.lblNomeEvento.Text = "Nome Evento:";
            // 
            // btnCerca
            // 
            this.btnCerca.BackColor = System.Drawing.Color.White;
            this.btnCerca.BackgroundColor = System.Drawing.Color.White;
            this.btnCerca.Colore_bordo = System.Drawing.Color.Red;
            this.btnCerca.FlatAppearance.BorderSize = 0;
            this.btnCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerca.ForeColor = System.Drawing.Color.Red;
            this.btnCerca.Location = new System.Drawing.Point(517, 45);
            this.btnCerca.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Radius_bordo = 40;
            this.btnCerca.Size = new System.Drawing.Size(99, 29);
            this.btnCerca.Size_bordo = 2;
            this.btnCerca.TabIndex = 17;
            this.btnCerca.Text = "CERCA";
            this.btnCerca.TextColor = System.Drawing.Color.Red;
            this.btnCerca.UseVisualStyleBackColor = false;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // MenuUtenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 419);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.lblNomeEvento);
            this.Controls.Add(this.txtNomeEvento);
            this.Controls.Add(this.dtRisultati);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnProfilo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuUtenti";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnProfilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtRisultati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnProfilo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.DataGridView dtRisultati;
        private System.Windows.Forms.TextBox txtNomeEvento;
        private System.Windows.Forms.Label lblNomeEvento;
        private Elementi.RJButton btnCerca;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}