namespace samostalni_projakeat_baze
{
    partial class sank
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
            this.btnnormativ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkategorija = new System.Windows.Forms.TextBox();
            this.txtcena = new System.Windows.Forms.TextBox();
            this.txtnaziv = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.dgvsank = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsank)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnormativ
            // 
            this.btnnormativ.Location = new System.Drawing.Point(566, 371);
            this.btnnormativ.Name = "btnnormativ";
            this.btnnormativ.Size = new System.Drawing.Size(160, 51);
            this.btnnormativ.TabIndex = 21;
            this.btnnormativ.Text = "uredi normativ";
            this.btnnormativ.UseVisualStyleBackColor = true;
            this.btnnormativ.Click += new System.EventHandler(this.btnnormativ_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "kategorija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "cena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "naziv";
            // 
            // txtkategorija
            // 
            this.txtkategorija.Location = new System.Drawing.Point(400, 345);
            this.txtkategorija.Name = "txtkategorija";
            this.txtkategorija.Size = new System.Drawing.Size(160, 20);
            this.txtkategorija.TabIndex = 17;
            // 
            // txtcena
            // 
            this.txtcena.Location = new System.Drawing.Point(234, 345);
            this.txtcena.Name = "txtcena";
            this.txtcena.Size = new System.Drawing.Size(160, 20);
            this.txtcena.TabIndex = 16;
            // 
            // txtnaziv
            // 
            this.txtnaziv.Location = new System.Drawing.Point(68, 345);
            this.txtnaziv.Name = "txtnaziv";
            this.txtnaziv.Size = new System.Drawing.Size(160, 20);
            this.txtnaziv.TabIndex = 15;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(400, 371);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(160, 51);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(234, 371);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(160, 51);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(68, 371);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(160, 51);
            this.btninsert.TabIndex = 12;
            this.btninsert.Text = "insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click_1);
            // 
            // dgvsank
            // 
            this.dgvsank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsank.Location = new System.Drawing.Point(69, 28);
            this.dgvsank.Name = "dgvsank";
            this.dgvsank.Size = new System.Drawing.Size(666, 251);
            this.dgvsank.TabIndex = 11;
            // 
            // sank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnnormativ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkategorija);
            this.Controls.Add(this.txtcena);
            this.Controls.Add(this.txtnaziv);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dgvsank);
            this.Name = "sank";
            this.Text = "sank";
            this.Load += new System.EventHandler(this.sank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnormativ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkategorija;
        private System.Windows.Forms.TextBox txtcena;
        private System.Windows.Forms.TextBox txtnaziv;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.DataGridView dgvsank;
    }
}