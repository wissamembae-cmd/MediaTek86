namespace MediaTek86.Vue
{
    partial class FrmModifAbsence
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
            this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMotif = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDateFin
            // 
            this.dtpDateFin.Location = new System.Drawing.Point(45, 108);
            this.dtpDateFin.Name = "dtpDateFin";
            this.dtpDateFin.Size = new System.Drawing.Size(200, 22);
            this.dtpDateFin.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Date de fin :";
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Location = new System.Drawing.Point(45, 50);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(200, 22);
            this.dtpDateDebut.TabIndex = 33;
            this.dtpDateDebut.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Date début :";
            // 
            // cbMotif
            // 
            this.cbMotif.FormattingEnabled = true;
            this.cbMotif.Location = new System.Drawing.Point(45, 168);
            this.cbMotif.Name = "cbMotif";
            this.cbMotif.Size = new System.Drawing.Size(142, 24);
            this.cbMotif.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Motif :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 29;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 28;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btValider_Click);
            // 
            // FrmModifAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 288);
            this.Controls.Add(this.dtpDateFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMotif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmModifAbsence";
            this.Text = "Modifier une absence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMotif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}