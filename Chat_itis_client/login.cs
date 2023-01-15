using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Windows.Markup;
using SQLite;


namespace Chat_itis_client
{
    public partial class login : Form
    {
        string direcrtory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public login()
        {
            InitializeComponent();
            try
            {
                SQLiteConnection db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
                var sql = " SELECT * FROM db_utente";
                List<db_utente> mex = db.Query<db_utente>(sql);
                tbx_nome.Text = mex[0].Name;
                tbx_num.Text = mex[0].Num;
                tbx_pass.Text = mex[0].Cod;
                db.Close();
            }
            catch
            {

            }
            StreamReader F = File.OpenText("server_ip.txt");
            server_ip = F.ReadLine();
            F.Close();
        }
        string server_ip;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string query = "?Q=" + "001" + "/-/" + tbx_nome.Text + "/-/" + tbx_num.Text + "/-/" +  tbx_pass.Text;
            WebRequest wrGETURL = WebRequest.Create(server_ip + query);
            Stream objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            string sLine = objReader.ReadLine();
            string[] separatingStrings1 = { "/-/" };
            string[] strings = sLine.Split(separatingStrings1, System.StringSplitOptions.RemoveEmptyEntries);
            if (strings[0] == "si,password corretta")
            {

                db_utente temp = new db_utente(1, tbx_nome.Text, tbx_num.Text,tbx_pass.Text/*,Properties.Resources.Account_User_PNG_Photo1*/);
                var db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
                db.InsertOrReplace(temp);
                db.Close();
                this.Close();
            }
            else if (strings[0] == "si,password sbagliata")
            {
                lbl_titolo.Text = "password sbagliata";
            }
            else if (strings[0] == "no")
            {
                lbl_mex.Visible = true;
                lbl_codice.Visible = true;
                button1.Visible = true;
                lbl_codice.Text = strings[1];
            }
            
        }

        private void lbl_titolo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db_utente temp = new db_utente(1, tbx_nome.Text, tbx_num.Text, tbx_pass.Text/*,Properties.Resources.Account_User_PNG_Photo1*/);
            var db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
            db.InsertOrReplace(temp);
            db.Close();
            this.Close();
        }
    }
}
