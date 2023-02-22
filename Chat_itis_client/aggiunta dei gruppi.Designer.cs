namespace Chat_itis_client
{
    partial class aggiunta_dei_gruppi
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
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.tbx_descrizione = new System.Windows.Forms.TextBox();
            this.btn_crea = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(340, 109);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(100, 20);
            this.tbx_nome.TabIndex = 0;
            // 
            // tbx_descrizione
            // 
            this.tbx_descrizione.Location = new System.Drawing.Point(340, 149);
            this.tbx_descrizione.Name = "tbx_descrizione";
            this.tbx_descrizione.Size = new System.Drawing.Size(100, 20);
            this.tbx_descrizione.TabIndex = 1;
            // 
            // btn_crea
            // 
            this.btn_crea.Location = new System.Drawing.Point(340, 196);
            this.btn_crea.Name = "btn_crea";
            this.btn_crea.Size = new System.Drawing.Size(100, 23);
            this.btn_crea.TabIndex = 3;
            this.btn_crea.Text = "crea";
            this.btn_crea.UseVisualStyleBackColor = true;
            this.btn_crea.Click += new System.EventHandler(this.btn_crea_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(340, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 77);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // aggiunta_dei_gruppi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_crea);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbx_descrizione);
            this.Controls.Add(this.tbx_nome);
            this.Name = "aggiunta_dei_gruppi";
            this.Text = "aggiunta_dei_gruppi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.TextBox tbx_descrizione;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_crea;
    }
}