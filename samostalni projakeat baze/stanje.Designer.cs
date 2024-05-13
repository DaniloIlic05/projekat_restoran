namespace samostalni_projakeat_baze
{
    partial class stanje
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
            this.dgvstanje = new System.Windows.Forms.DataGridView();
            this.btndodaj = new System.Windows.Forms.Button();
            this.btnotpis = new System.Windows.Forms.Button();
            this.txtunos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstanje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstanje
            // 
            this.dgvstanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstanje.Location = new System.Drawing.Point(66, 23);
            this.dgvstanje.Name = "dgvstanje";
            this.dgvstanje.Size = new System.Drawing.Size(671, 290);
            this.dgvstanje.TabIndex = 0;
            // 
            // btndodaj
            // 
            this.btndodaj.Location = new System.Drawing.Point(212, 390);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(185, 54);
            this.btndodaj.TabIndex = 1;
            this.btndodaj.Text = "dodaj na stanje";
            this.btndodaj.UseVisualStyleBackColor = true;
            this.btndodaj.Click += new System.EventHandler(this.btndodaj_Click);
            // 
            // btnotpis
            // 
            this.btnotpis.Location = new System.Drawing.Point(403, 390);
            this.btnotpis.Name = "btnotpis";
            this.btnotpis.Size = new System.Drawing.Size(185, 54);
            this.btnotpis.TabIndex = 2;
            this.btnotpis.Text = "otpis";
            this.btnotpis.UseVisualStyleBackColor = true;
            this.btnotpis.Click += new System.EventHandler(this.btnotpis_Click);
            // 
            // txtunos
            // 
            this.txtunos.Location = new System.Drawing.Point(306, 354);
            this.txtunos.Name = "txtunos";
            this.txtunos.Size = new System.Drawing.Size(184, 20);
            this.txtunos.TabIndex = 3;
            // 
            // stanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.txtunos);
            this.Controls.Add(this.btnotpis);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.dgvstanje);
            this.Name = "stanje";
            this.Text = "stanje";
            this.Load += new System.EventHandler(this.stanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstanje;
        private System.Windows.Forms.Button btndodaj;
        private System.Windows.Forms.Button btnotpis;
        private System.Windows.Forms.TextBox txtunos;
    }
}