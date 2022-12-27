namespace hangmanV3._0
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
            this.btnUret = new System.Windows.Forms.Button();
            this.btnKelime = new System.Windows.Forms.Button();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.lbTahmin = new System.Windows.Forms.Label();
            this.lbAdam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(62, 50);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(196, 61);
            this.btnUret.TabIndex = 0;
            this.btnUret.Text = "kelime üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // btnKelime
            // 
            this.btnKelime.Location = new System.Drawing.Point(62, 239);
            this.btnKelime.Name = "btnKelime";
            this.btnKelime.Size = new System.Drawing.Size(196, 61);
            this.btnKelime.TabIndex = 1;
            this.btnKelime.Text = "deneme";
            this.btnKelime.UseVisualStyleBackColor = true;
            this.btnKelime.Click += new System.EventHandler(this.btnKelime_Click);
            // 
            // txtHarf
            // 
            this.txtHarf.Location = new System.Drawing.Point(425, 184);
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(100, 20);
            this.txtHarf.TabIndex = 2;
            // 
            // lbTahmin
            // 
            this.lbTahmin.AutoSize = true;
            this.lbTahmin.Location = new System.Drawing.Point(101, 147);
            this.lbTahmin.Name = "lbTahmin";
            this.lbTahmin.Size = new System.Drawing.Size(35, 13);
            this.lbTahmin.TabIndex = 3;
            this.lbTahmin.Text = "label1";
            // 
            // lbAdam
            // 
            this.lbAdam.AutoSize = true;
            this.lbAdam.Location = new System.Drawing.Point(422, 263);
            this.lbAdam.Name = "lbAdam";
            this.lbAdam.Size = new System.Drawing.Size(35, 13);
            this.lbAdam.TabIndex = 4;
            this.lbAdam.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAdam);
            this.Controls.Add(this.lbTahmin);
            this.Controls.Add(this.txtHarf);
            this.Controls.Add(this.btnKelime);
            this.Controls.Add(this.btnUret);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Button btnKelime;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Label lbTahmin;
        private System.Windows.Forms.Label lbAdam;
    }
}

