using SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chat_itis_client
{
    public partial class aggiungi_utenti : Form
    {
        public aggiungi_utenti(string gruppo, string s_i, string p_n, string c_n)
        {
            InitializeComponent();
            Gruppo = gruppo;
            Server_ip = s_i;
            form1Istance = this;
            tbx = textBox2;
            profilo_numero = p_n;
            codice_numero = c_n;
        }
        public static aggiungi_utenti form1Istance;
        public System.Windows.Forms.TextBox tbx;
        string Gruppo = "";
        string Server_ip = "";
        public SQLiteConnection db;
        string profilo_numero;
        string codice_numero;
        string direcrtory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        IDictionary<string, string> dict = new Dictionary<string, string>();
        List<string> utenti_selezionati = new List<string>();
        List<UserControl2> userControl2 = new List<UserControl2>();
        private void aggiungi_utenti_Load(object sender, EventArgs e)
        {
            aggiorna_listbox();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int k = 0; k < utenti_selezionati.Count; k++)
            {
                string query = "?Q=021/-/"+profilo_numero+"/-/"+codice_numero+"/-/"+ Gruppo +"/-/" + utenti_selezionati[k] ;
                WebRequest wrGETURL = WebRequest.Create(Server_ip + query);
                Stream objStream = wrGETURL.GetResponse().GetResponseStream();
                StreamReader objReader = new StreamReader(objStream);
                string sLine = objReader.ReadLine();
                if(sLine == "esistente")
                {
                    MessageBox.Show("il contatto " + dict[utenti_selezionati[k]] + " appartenva al gruppo precedentemente");
                }
                else if(sLine == "error")
                {
                    MessageBox.Show("non è stato possibile aggiungere il contatto" + dict[utenti_selezionati[k]] + " al gruppo");
                }
            }
        }

        private void UserC_click()
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                    userControl2[i].Selected = false;
            }
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                if (utenti_selezionati.Contains(userControl2[i].Num))
                {
                    userControl2[i].Selected = true;
                }
            }
            aggiorna_listbox();
        }

        private void aggiorna_listbox()
        {
            dict.Clear();
            flowLayoutPanel1.Controls.Clear();
            db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
            List<db_contatti> mex = db.Query<db_contatti>("SELECT * FROM db_contatti WHERE gruppo = 0");
            for (int k = 0; k < mex.Count; k++)
            {
                userControl2.Add(new UserControl2(Server_ip));
                userControl2[k].Username = mex[k].Name;
                userControl2[k].Num = mex[k].Num;

                dict.Add(mex[k].Name, mex[k].Num);
                flowLayoutPanel1.Controls.Add(userControl2[k]);
            }
            db.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!utenti_selezionati.Contains(textBox2.Text))
            {
                utenti_selezionati.Add(textBox2.Text);
            }
             else 
            {
                utenti_selezionati.Remove(textBox2.Text);
            }
            UserC_click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < utenti_selezionati.Count; k++)
            {
                string query = "?Q=022/-/" + profilo_numero + "/-/" + codice_numero + "/-/" + Gruppo + "/-/" + utenti_selezionati[k];
                WebRequest wrGETURL = WebRequest.Create(Server_ip + query);
                Stream objStream = wrGETURL.GetResponse().GetResponseStream();
                StreamReader objReader = new StreamReader(objStream);
                string sLine = objReader.ReadLine();
                if (sLine == "esistente")
                {
                    MessageBox.Show("il contatto " + dict[utenti_selezionati[k]] + " non appartenva al gruppo precedentemente");
                }
                else if (sLine == "error")
                {
                    MessageBox.Show("non è stato possibile eliminare il contatto" + dict[utenti_selezionati[k]] + " al gruppo");
                }
            }
        }
    }
    
}
