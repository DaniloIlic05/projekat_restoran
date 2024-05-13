namespace samostalni_projakeat_baze
{
    partial class sala
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnpremesti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.txtbroj = new System.Windows.Forms.TextBox();
            this.txtkapacitet = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnpremesti);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.txtbroj);
            this.panel1.Controls.Add(this.txtkapacitet);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 523);
            this.panel1.TabIndex = 0;
            // 
            // btnpremesti
            // 
            this.btnpremesti.Location = new System.Drawing.Point(706, 356);
            this.btnpremesti.Name = "btnpremesti";
            this.btnpremesti.Size = new System.Drawing.Size(81, 70);
            this.btnpremesti.TabIndex = 7;
            this.btnpremesti.Text = "premesti sto";
            this.btnpremesti.UseVisualStyleBackColor = true;
            this.btnpremesti.Click += new System.EventHandler(this.btnpremesti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(703, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Broj stola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kapacitet";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(706, 164);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(81, 70);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "izmeni sto";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(706, 88);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(81, 70);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "obrisi sto";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // txtbroj
            // 
            this.txtbroj.Location = new System.Drawing.Point(706, 310);
            this.txtbroj.Name = "txtbroj";
            this.txtbroj.Size = new System.Drawing.Size(81, 20);
            this.txtbroj.TabIndex = 2;
            // 
            // txtkapacitet
            // 
            this.txtkapacitet.Location = new System.Drawing.Point(706, 269);
            this.txtkapacitet.Name = "txtkapacitet";
            this.txtkapacitet.Size = new System.Drawing.Size(81, 20);
            this.txtkapacitet.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(706, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(81, 70);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "dodaj sto";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 445);
            this.Controls.Add(this.panel1);
            this.Name = "sala";
            this.Text = "sala";
            this.Load += new System.EventHandler(this.sala_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox txtkapacitet;
        private System.Windows.Forms.TextBox txtbroj;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button btnpremesti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}