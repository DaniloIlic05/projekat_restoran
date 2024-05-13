namespace samostalni_projakeat_baze
{
    partial class kuhinja
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
            this.dgvkuhinja = new System.Windows.Forms.DataGridView();
            this.btninsert = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtnaziv = new System.Windows.Forms.TextBox();
            this.txtcena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnormativ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkuhinja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvkuhinja
            // 
            this.dgvkuhinja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkuhinja.Location = new System.Drawing.Point(65, 39);
            this.dgvkuhinja.Name = "dgvkuhinja";
            this.dgvkuhinja.Size = new System.Drawing.Size(666, 251);
            this.dgvkuhinja.TabIndex = 0;
            this.dgvkuhinja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkuhinja_CellClick);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(64, 382);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(160, 51);
            this.btninsert.TabIndex = 1;
            this.btninsert.Text = "insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(230, 382);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(160, 51);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(396, 382);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(160, 51);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtnaziv
            // 
            this.txtnaziv.Location = new System.Drawing.Point(64, 356);
            this.txtnaziv.Name = "txtnaziv";
            this.txtnaziv.Size = new System.Drawing.Size(160, 20);
            this.txtnaziv.TabIndex = 4;
            // 
            // txtcena
            // 
            this.txtcena.Location = new System.Drawing.Point(230, 356);
            this.txtcena.Name = "txtcena";
            this.txtcena.Size = new System.Drawing.Size(160, 20);
            this.txtcena.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "cena";
            // 
            // btnnormativ
            // 
            this.btnnormativ.Location = new System.Drawing.Point(562, 382);
            this.btnnormativ.Name = "btnnormativ";
            this.btnnormativ.Size = new System.Drawing.Size(160, 51);
            this.btnnormativ.TabIndex = 10;
            this.btnnormativ.Text = "uredi normativ";
            this.btnnormativ.UseVisualStyleBackColor = true;
            this.btnnormativ.Click += new System.EventHandler(this.btnnormativ_Click);
            // 
            // kuhinja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnnormativ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcena);
            this.Controls.Add(this.txtnaziv);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dgvkuhinja);
            this.Name = "kuhinja";
            this.Text = "kuhinja";
            this.Load += new System.EventHandler(this.kuhinja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkuhinja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvkuhinja;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtnaziv;
        private System.Windows.Forms.TextBox txtcena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnormativ;
    }
}