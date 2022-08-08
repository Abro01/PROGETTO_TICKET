namespace ProgettoRDF
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.btnProfilo = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartenza = new System.Windows.Forms.TextBox();
            this.btnRicerca = new ProgettoRDF.Elementi.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArrivo = new System.Windows.Forms.TextBox();
            this.dtRisultati = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Partenza da:\r\n";
            // 
            // txtPartenza
            // 
            this.txtPartenza.Location = new System.Drawing.Point(213, 70);
            this.txtPartenza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPartenza.Name = "txtPartenza";
            this.txtPartenza.Size = new System.Drawing.Size(124, 20);
            this.txtPartenza.TabIndex = 8;
            // 
            // btnRicerca
            // 
            this.btnRicerca.BackColor = System.Drawing.Color.White;
            this.btnRicerca.BackgroundColor = System.Drawing.Color.White;
            this.btnRicerca.Colore_bordo = System.Drawing.Color.Red;
            this.btnRicerca.FlatAppearance.BorderSize = 0;
            this.btnRicerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRicerca.ForeColor = System.Drawing.Color.Red;
            this.btnRicerca.Location = new System.Drawing.Point(604, 63);
            this.btnRicerca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Radius_bordo = 40;
            this.btnRicerca.Size = new System.Drawing.Size(110, 34);
            this.btnRicerca.Size_bordo = 2;
            this.btnRicerca.TabIndex = 16;
            this.btnRicerca.Text = "CERCA";
            this.btnRicerca.TextColor = System.Drawing.Color.Red;
            this.btnRicerca.UseVisualStyleBackColor = false;
            this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Arrivo a:\r\n";
            // 
            // txtArrivo
            // 
            this.txtArrivo.Location = new System.Drawing.Point(451, 71);
            this.txtArrivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArrivo.Name = "txtArrivo";
            this.txtArrivo.Size = new System.Drawing.Size(124, 20);
            this.txtArrivo.TabIndex = 18;
            // 
            // dtRisultati
            // 
            this.dtRisultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRisultati.Location = new System.Drawing.Point(89, 127);
            this.dtRisultati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtRisultati.Name = "dtRisultati";
            this.dtRisultati.RowHeadersWidth = 62;
            this.dtRisultati.RowTemplate.Height = 28;
            this.dtRisultati.Size = new System.Drawing.Size(625, 144);
            this.dtRisultati.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Risultati:\r\n";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 419);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtRisultati);
            this.Controls.Add(this.txtArrivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRicerca);
            this.Controls.Add(this.txtPartenza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnProfilo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuForm";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPartenza;
        private Elementi.RJButton btnRicerca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArrivo;
        private System.Windows.Forms.DataGridView dtRisultati;
        private System.Windows.Forms.Label label3;
    }
}