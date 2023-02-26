namespace Chat_itis_client
{
    partial class Form2
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
            this.tbx_num = new System.Windows.Forms.TextBox();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_num
            // 
            this.tbx_num.Location = new System.Drawing.Point(85, 220);
            this.tbx_num.Name = "tbx_num";
            this.tbx_num.Size = new System.Drawing.Size(173, 20);
            this.tbx_num.TabIndex = 0;
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(85, 166);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(173, 20);
            this.tbx_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "nome:";
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Location = new System.Drawing.Point(28, 265);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(218, 23);
            this.btn_aggiungi.TabIndex = 4;
            this.btn_aggiungi.Text = "Salva";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chat_itis_client.Properties.Resources.Account_User_PNG_Photo1;
            this.pictureBox1.Location = new System.Drawing.Point(85, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(277, 320);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_aggiungi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.tbx_num);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_num;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}