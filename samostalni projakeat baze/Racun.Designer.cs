namespace samostalni_projakeat_baze
{
    partial class Racun
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
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.btnhrana = new System.Windows.Forms.Button();
            this.btnpice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.lblSto = new System.Windows.Forms.Label();
            this.btnnaplati = new System.Windows.Forms.Button();
            this.btnpresek = new System.Windows.Forms.Button();
            this.btnkraj = new System.Windows.Forms.Button();
            this.dgvstanje = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstanje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRacun
            // 
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Location = new System.Drawing.Point(0, 0);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.Size = new System.Drawing.Size(255, 524);
            this.dgvRacun.TabIndex = 0;
            this.dgvRacun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRacun_CellContentClick);
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(575, 0);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(274, 524);
            this.dgvArtikli.TabIndex = 1;
            this.dgvArtikli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtikli_CellContentClick);
            // 
            // btnhrana
            // 
            this.btnhrana.Location = new System.Drawing.Point(296, 61);
            this.btnhrana.Name = "btnhrana";
            this.btnhrana.Size = new System.Drawing.Size(118, 51);
            this.btnhrana.TabIndex = 2;
            this.btnhrana.Text = "jelovnik";
            this.btnhrana.UseVisualStyleBackColor = true;
            this.btnhrana.Click += new System.EventHandler(this.btnhrana_Click);
            // 
            // btnpice
            // 
            this.btnpice.Location = new System.Drawing.Point(420, 61);
            this.btnpice.Name = "btnpice";
            this.btnpice.Size = new System.Drawing.Size(118, 51);
            this.btnpice.TabIndex = 3;
            this.btnpice.Text = "karta pica";
            this.btnpice.UseVisualStyleBackColor = true;
            this.btnpice.Click += new System.EventHandler(this.btnpice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ukupno";
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(261, 477);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(0, 13);
            this.lblUkupno.TabIndex = 5;
            // 
            // lblSto
            // 
            this.lblSto.AutoSize = true;
            this.lblSto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSto.Location = new System.Drawing.Point(387, 16);
            this.lblSto.Name = "lblSto";
            this.lblSto.Size = new System.Drawing.Size(59, 16);
            this.lblSto.TabIndex = 6;
            this.lblSto.Text = "Sto broj: ";
            // 
            // btnnaplati
            // 
            this.btnnaplati.Location = new System.Drawing.Point(420, 422);
            this.btnnaplati.Name = "btnnaplati";
            this.btnnaplati.Size = new System.Drawing.Size(118, 51);
            this.btnnaplati.TabIndex = 8;
            this.btnnaplati.Text = "naplati";
            this.btnnaplati.UseVisualStyleBackColor = true;
            this.btnnaplati.Click += new System.EventHandler(this.btnnaplati_Click);
            // 
            // btnpresek
            // 
            this.btnpresek.Location = new System.Drawing.Point(296, 247);
            this.btnpresek.Name = "btnpresek";
            this.btnpresek.Size = new System.Drawing.Size(118, 51);
            this.btnpresek.TabIndex = 9;
            this.btnpresek.Text = "presek stanja";
            this.btnpresek.UseVisualStyleBackColor = true;
            this.btnpresek.Click += new System.EventHandler(this.btnpresek_Click);
            // 
            // btnkraj
            // 
            this.btnkraj.Location = new System.Drawing.Point(420, 247);
            this.btnkraj.Name = "btnkraj";
            this.btnkraj.Size = new System.Drawing.Size(118, 51);
            this.btnkraj.TabIndex = 10;
            this.btnkraj.Text = "kraj dana";
            this.btnkraj.UseVisualStyleBackColor = true;
            this.btnkraj.Click += new System.EventHandler(this.btnkraj_Click);
            // 
            // dgvstanje
            // 
            this.dgvstanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstanje.Location = new System.Drawing.Point(0, 0);
            this.dgvstanje.Name = "dgvstanje";
            this.dgvstanje.Size = new System.Drawing.Size(838, 524);
            this.dgvstanje.TabIndex = 11;
            // 
            // Racun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 524);
            this.Controls.Add(this.dgvRacun);
            this.Controls.Add(this.btnkraj);
            this.Controls.Add(this.btnpresek);
            this.Controls.Add(this.btnnaplati);
            this.Controls.Add(this.lblSto);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpice);
            this.Controls.Add(this.btnhrana);
            this.Controls.Add(this.dgvArtikli);
            this.Controls.Add(this.dgvstanje);
            this.Name = "Racun";
            this.Text = "Racun";
            this.Load += new System.EventHandler(this.Racun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.Button btnhrana;
        private System.Windows.Forms.Button btnpice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label lblSto;
        private System.Windows.Forms.Button btnnaplati;
        private System.Windows.Forms.Button btnpresek;
        private System.Windows.Forms.Button btnkraj;
        private System.Windows.Forms.DataGridView dgvstanje;
    }
}