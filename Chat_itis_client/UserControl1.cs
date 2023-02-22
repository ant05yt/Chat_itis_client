using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_itis_client
{
    public partial class UserControl1 : UserControl 
    {
        
        public UserControl1()
        {
            InitializeComponent();
        }
        
        #region Properties
        [Category("Custom Props")]
        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; lbl_nome.Text = value; }
        }
        [Category("Custom Props")]
        private string _last_message;
        public string Last_message
        {
            get { return _last_message; }
            set { _last_message = value; lbl_last_m.Text = value; }
        }
        [Category("Custom Props")]
        private string _data;
        public string Data
        {
            get { return _data; }
            set { _data = value; lbl_data.Text = value; }
        }
        [Category("Custom Props")]
        private bool _selected;
        public bool Selected
        {
            get { return _selected; }
            set { 
                _selected = value;
                if (_selected)
                {
                    this.BackgroundImage = Properties.Resources.user_control_img_selected;
                }
                else { this.BackgroundImage = Properties.Resources.user_control_img; }
            }
        }
        [Category("Custom Props")]
        private string _num;
        public string Num
        {
            get { return _num; }
            set { _num = value;}
        }
        [Category("Custom Props")]
        private bool _a;
        public bool a
        {
            get { return _a; }
            set { _a= value; }
        }
        #endregion

        public void contatto_Click(object sender, EventArgs e)
        {       
                if(!a)
                Form1.form1Istance.tbx.Text = lbl_nome.Text;  
                else
                aggiungi_utenti.form1Istance.tbx.Text = lbl_nome.Text;
            this.BackColor= Color.FromArgb(00013797134);
        }

        private void immagine_Click(object sender, EventArgs e)
        {
            modifica_contatto f = new modifica_contatto(this);
            f.Show();
            
        }




    }
}
