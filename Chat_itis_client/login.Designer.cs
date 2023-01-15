namespace Chat_itis_client
{
    partial class login
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
            this.lbl_numero = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_pass = new System.Windows.Forms.TextBox();
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_codice = new System.Windows.Forms.Label();
            this.lbl_mex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_num
            // 
            this.tbx_num.Location = new System.Drawing.Point(208, 160);
            this.tbx_num.Name = "tbx_num";
            this.tbx_num.Size = new System.Drawing.Size(210, 20);
            this.tbx_num.TabIndex = 1;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(145, 166);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(42, 13);
            this.lbl_numero.TabIndex = 3;
            this.lbl_numero.Text = "numero";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(148, 245);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(270, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "accedi";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "password";
            // 
            // tbx_pass
            // 
            this.tbx_pass.Location = new System.Drawing.Point(208, 196);
            this.tbx_pass.Name = "tbx_pass";
            this.tbx_pass.Size = new System.Drawing.Size(210, 20);
            this.tbx_pass.TabIndex = 6;
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_titolo.Location = new System.Drawing.Point(26, 30);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(90, 39);
            this.lbl_titolo.TabIndex = 9;
            this.lbl_titolo.Text = "login";
            this.lbl_titolo.Click += new System.EventHandler(this.lbl_titolo_Click);
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(208, 122);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(210, 20);
            this.tbx_nome.TabIndex = 0;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(145, 122);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(33, 13);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "nome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "torna alla schermata iniziale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_codice
            // 
            this.lbl_codice.AutoSize = true;
            this.lbl_codice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_codice.Location = new System.Drawing.Point(205, 306);
            this.lbl_codice.Name = "lbl_codice";
            this.lbl_codice.Size = new System.Drawing.Size(46, 17);
            this.lbl_codice.TabIndex = 11;
            this.lbl_codice.Text = "label2";
            this.lbl_codice.Visible = false;
            // 
            // lbl_mex
            // 
            this.lbl_mex.AutoSize = true;
            this.lbl_mex.Location = new System.Drawing.Point(111, 285);
            this.lbl_mex.Name = "lbl_mex";
            this.lbl_mex.Size = new System.Drawing.Size(401, 13);
            this.lbl_mex.TabIndex = 12;
            this.lbl_mex.Text = "questa è la tua password se la perderai non potrai accedere al tuo account in fut" +
    "uro";
            this.lbl_mex.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 336);
            this.Controls.Add(this.lbl_mex);
            this.Controls.Add(this.lbl_codice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_titolo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_pass);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.tbx_num);
            this.Controls.Add(this.tbx_nome);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_num;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_pass;
        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_codice;
        private System.Windows.Forms.Label lbl_mex;
    }
}