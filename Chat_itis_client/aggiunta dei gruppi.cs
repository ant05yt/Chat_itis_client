using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Markup;

namespace Chat_itis_client
{
    public partial class aggiunta_dei_gruppi : Form
    {
        public aggiunta_dei_gruppi(string num, string cod, string s_i)
        {
            InitializeComponent();
            server_ip= s_i;
            codice = cod;
            numero = num;   
        }
        private string server_ip = "";
        private string numero = "";
        private string codice = "";
        private void btn_crea_Click(object sender, EventArgs e)
        {
            string query = "?Q=" + "002" + "/-/" + numero + "/-/" + codice + "/-/" + tbx_nome.Text + "/-/" + tbx_descrizione.Text;
            WebRequest wrGETURL = WebRequest.Create(server_ip + query);
            Stream objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            string sLine = objReader.ReadLine();
            string[] separatingStrings1 = { "/-/" };
            string[] strings = sLine.Split(separatingStrings1, System.StringSplitOptions.RemoveEmptyEntries);
            if (strings[0] == "si")
            {
                aggiungi_utenti A = new aggiungi_utenti(strings[1], server_ip);
                A.Show();
            }
            else 
            {
                MessageBox.Show("errore");
            }
        }

       
    }
}
