namespace samostalni_projakeat_baze
{
    partial class normativ
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
            this.dgvnormativ = new System.Windows.Forms.DataGridView();
            this.btninsert = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtkolicina = new System.Windows.Forms.TextBox();
            this.txtnaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnormativ)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvnormativ
            // 
            this.dgvnormativ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnormativ.Location = new System.Drawing.Point(59, 27);
            this.dgvnormativ.Name = "dgvnormativ";
            this.dgvnormativ.Size = new System.Drawing.Size(685, 258);
            this.dgvnormativ.TabIndex = 0;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(170, 342);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(157, 45);
            this.btninsert.TabIndex = 1;
            this.btninsert.Text = "insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(333, 342);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(157, 45);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(496, 342);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(157, 45);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtkolicina
            // 
            this.txtkolicina.Location = new System.Drawing.Point(256, 316);
            this.txtkolicina.Name = "txtkolicina";
            this.txtkolicina.Size = new System.Drawing.Size(157, 20);
            this.txtkolicina.TabIndex = 4;
            // 
            // txtnaziv
            // 
            this.txtnaziv.Location = new System.Drawing.Point(419, 316);
            this.txtnaziv.Name = "txtnaziv";
            this.txtnaziv.Size = new System.Drawing.Size(157, 20);
            this.txtnaziv.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "kolicina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "naziv sastojka";
            // 
            // normativ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnaziv);
            this.Controls.Add(this.txtkolicina);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dgvnormativ);
            this.Name = "normativ";
            this.Text = "normativ";
            this.Load += new System.EventHandler(this.normativ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnormativ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvnormativ;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtkolicina;
        private System.Windows.Forms.TextBox txtnaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}