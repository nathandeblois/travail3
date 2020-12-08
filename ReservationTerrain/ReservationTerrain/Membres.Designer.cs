namespace ReservationTerrain
{
    partial class Membres
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_numMembre = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_heure = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(270, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 24);
            this.textBox1.TabIndex = 0;
            // 
            // lbl_numMembre
            // 
            this.lbl_numMembre.AutoSize = true;
            this.lbl_numMembre.Location = new System.Drawing.Point(26, 69);
            this.lbl_numMembre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numMembre.Name = "lbl_numMembre";
            this.lbl_numMembre.Size = new System.Drawing.Size(121, 18);
            this.lbl_numMembre.TabIndex = 1;
            this.lbl_numMembre.Text = "Numéro Membre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 24);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(26, 122);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(136, 18);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Date de réservation";
            // 
            // lbl_heure
            // 
            this.lbl_heure.AutoSize = true;
            this.lbl_heure.Location = new System.Drawing.Point(26, 162);
            this.lbl_heure.Name = "lbl_heure";
            this.lbl_heure.Size = new System.Drawing.Size(48, 18);
            this.lbl_heure.TabIndex = 4;
            this.lbl_heure.Text = "Heure";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(270, 157);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 24);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // Membres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 476);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lbl_heure);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_numMembre);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Membres";
            this.Text = "Membre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_numMembre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_heure;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}