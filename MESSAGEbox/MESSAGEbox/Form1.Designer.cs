namespace MESSAGEbox
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCıkıs
            // 
            this.buttonCıkıs.Location = new System.Drawing.Point(292, 132);
            this.buttonCıkıs.Name = "buttonCıkıs";
            this.buttonCıkıs.Size = new System.Drawing.Size(231, 165);
            this.buttonCıkıs.TabIndex = 0;
            this.buttonCıkıs.Text = "cıkıs";
            this.buttonCıkıs.UseVisualStyleBackColor = true;
            this.buttonCıkıs.Click += new System.EventHandler(this.buttonCıkıs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCıkıs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCıkıs;
    }
}

