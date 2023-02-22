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
        public aggiungi_utenti(string gruppo, string s_i)
        {
            InitializeComponent();
            Gruppo = gruppo;
            Server_ip = s_i;
            form1Istance = this;
            tbx = textBox2;
        }
        public static aggiungi_utenti form1Istance;
        public System.Windows.Forms.TextBox tbx;
        string Gruppo = "";
        string Server_ip = "";
        public SQLiteConnection db;
        string direcrtory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        IDictionary<string, string> dict = new Dictionary<string, string>();
        List<string> utenti_selezionati = new List<string>();
        List<UserControl1> userControl1;
        private void aggiungi_utenti_Load(object sender, EventArgs e)
        {
            aggiorna_listbox();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int k = 0; k < utenti_selezionati.Count; k++)
            {
                string query = "?Q=022/-/349/-/349349/-/"+ Gruppo +"/-/" + dict[utenti_selezionati[k]] ;
                WebRequest wrGETURL = WebRequest.Create(Server_ip + query);
                Stream objStream = wrGETURL.GetResponse().GetResponseStream();
                StreamReader objReader = new StreamReader(objStream);
                string sLine = objReader.ReadLine();
            }
        }

        public void UserC_click(string temp)
        {            
            for (int i = 0; i < flowLayoutPanel1.Controls.Count-1; i++)
            {
                if ( utenti_selezionati.Contains(temp))
                {
                    userControl1[i].Selected = true;
                }
            }
            aggiorna_listbox();
        }

        private void aggiorna_listbox()
        {
            dict.Clear();
            List<UserControl1> userControl1 = new List<UserControl1>();
            flowLayoutPanel1.Controls.Clear();
            db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
            List<db_contatti> mex = db.Query<db_contatti>("SELECT * FROM db_contatti");
            for (int k = 0; k < mex.Count; k++)
            {
                userControl1.Add(new UserControl1());
                userControl1[k].Username = mex[k].Name;
                userControl1[k].Num = mex[k].Num;
                userControl1[k].a = true;
                dict.Add(mex[k].Name, mex[k].Num);
                flowLayoutPanel1.Controls.Add(userControl1[k]);
            }
            db.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            utenti_selezionati.Add(dict[textBox2.Text]);
            UserC_click(textBox2.Text);
        }
    }
    
}
