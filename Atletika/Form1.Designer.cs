namespace Atletika
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kereses = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nevlab = new System.Windows.Forms.Label();
            this.eredmnylab = new System.Windows.Forms.Label();
            this.nemzetlab = new System.Windows.Forms.Label();
            this.aranyosnemzetek = new System.Windows.Forms.ListBox();
            this.Versenyszámok = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranyérmet szerzett nemzetek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Válasz ki versenyszámot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Válaszd ki az érmés helyezést";
            // 
            // kereses
            // 
            this.kereses.Location = new System.Drawing.Point(603, 259);
            this.kereses.Name = "kereses";
            this.kereses.Size = new System.Drawing.Size(173, 32);
            this.kereses.TabIndex = 3;
            this.kereses.Text = "Keresés";
            this.kereses.UseVisualStyleBackColor = false;
            this.kereses.Click += new System.EventHandler(this.kereses_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Aranyos-nemzetek";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.aranyos);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(568, 206);
            this.num.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(38, 27);
            this.num.TabIndex = 5;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Neve:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Eredmeny:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nemzete:";
            // 
            // nevlab
            // 
            this.nevlab.AutoSize = true;
            this.nevlab.Location = new System.Drawing.Point(702, 351);
            this.nevlab.Name = "nevlab";
            this.nevlab.Size = new System.Drawing.Size(0, 18);
            this.nevlab.TabIndex = 9;
            // 
            // eredmnylab
            // 
            this.eredmnylab.AutoSize = true;
            this.eredmnylab.Location = new System.Drawing.Point(702, 390);
            this.eredmnylab.Name = "eredmnylab";
            this.eredmnylab.Size = new System.Drawing.Size(0, 18);
            this.eredmnylab.TabIndex = 10;
            // 
            // nemzetlab
            // 
            this.nemzetlab.AutoSize = true;
            this.nemzetlab.Location = new System.Drawing.Point(702, 441);
            this.nemzetlab.Name = "nemzetlab";
            this.nemzetlab.Size = new System.Drawing.Size(0, 18);
            this.nemzetlab.TabIndex = 11;
            // 
            // aranyosnemzetek
            // 
            this.aranyosnemzetek.FormattingEnabled = true;
            this.aranyosnemzetek.ItemHeight = 18;
            this.aranyosnemzetek.Location = new System.Drawing.Point(40, 57);
            this.aranyosnemzetek.Name = "aranyosnemzetek";
            this.aranyosnemzetek.Size = new System.Drawing.Size(304, 418);
            this.aranyosnemzetek.TabIndex = 12;
            // 
            // Versenyszámok
            // 
            this.Versenyszámok.FormattingEnabled = true;
            this.Versenyszámok.ItemHeight = 18;
            this.Versenyszámok.Location = new System.Drawing.Point(568, 57);
            this.Versenyszámok.Name = "Versenyszámok";
            this.Versenyszámok.Size = new System.Drawing.Size(244, 58);
            this.Versenyszámok.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1640, 915);
            this.Controls.Add(this.Versenyszámok);
            this.Controls.Add(this.aranyosnemzetek);
            this.Controls.Add(this.nemzetlab);
            this.Controls.Add(this.eredmnylab);
            this.Controls.Add(this.nevlab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kereses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Ferfi Atleikavb 2017";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kereses;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nevlab;
        private System.Windows.Forms.Label eredmnylab;
        private System.Windows.Forms.Label nemzetlab;
        private System.Windows.Forms.ListBox aranyosnemzetek;
        private System.Windows.Forms.ListBox Versenyszámok;
    }
}

