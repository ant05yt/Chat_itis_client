namespace Chat_itis_client
{
    partial class impostazioni
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
            this.btn_Copia = new System.Windows.Forms.Button();
            this.btn_Elimina = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Annulla = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Copia
            // 
            this.btn_Copia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Copia.Location = new System.Drawing.Point(3, 3);
            this.btn_Copia.Name = "btn_Copia";
            this.btn_Copia.Size = new System.Drawing.Size(114, 29);
            this.btn_Copia.TabIndex = 0;
            this.btn_Copia.Text = "Copia";
            this.btn_Copia.UseVisualStyleBackColor = true;
            this.btn_Copia.Click += new System.EventHandler(this.btn_Copia_Click);
            // 
            // btn_Elimina
            // 
            this.btn_Elimina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Elimina.Location = new System.Drawing.Point(3, 38);
            this.btn_Elimina.Name = "btn_Elimina";
            this.btn_Elimina.Size = new System.Drawing.Size(114, 29);
            this.btn_Elimina.TabIndex = 1;
            this.btn_Elimina.Text = "Elimina";
            this.btn_Elimina.UseVisualStyleBackColor = true;
            this.btn_Elimina.Click += new System.EventHandler(this.btn_Elimina_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Annulla, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Copia, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Elimina, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(120, 108);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_Annulla
            // 
            this.btn_Annulla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Annulla.Location = new System.Drawing.Point(3, 73);
            this.btn_Annulla.Name = "btn_Annulla";
            this.btn_Annulla.Size = new System.Drawing.Size(114, 32);
            this.btn_Annulla.TabIndex = 3;
            this.btn_Annulla.Text = "Annulla";
            this.btn_Annulla.UseVisualStyleBackColor = true;
            this.btn_Annulla.Click += new System.EventHandler(this.btn_Annulla_Click);
            // 
            // impostazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 108);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "impostazioni";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Copia;
        private System.Windows.Forms.Button btn_Elimina;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Annulla;
    }
}