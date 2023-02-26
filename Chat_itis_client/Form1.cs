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
using System.CodeDom.Compiler;
using System.Net;
using System.Collections;
using System.Reflection.Emit;
using SQLite;
using System.Data.SqlClient;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Xml.Linq;
using System.Windows.Interop;
using Image = System.Drawing.Image;
using System.Drawing.Imaging;

namespace Chat_itis_client
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            { 
                form1Istance = this; 
                tbx = textBox2;
                 
                if (System.IO.File.Exists(direcrtory+@"\ChatItisUser.db3")) 
                {
                    
                }
                else 
                {  
                    db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3"); 
                    db.CreateTable<db_contatti>(); 
                    db.CreateTable<db_messaggi>(); 
                    db.CreateTable<db_utente>();
                    db.Close(); 
                    login login = new login();
                    this.Enabled = false;
                    login.ShowDialog();
                    this.Enabled = true;
                }
                db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
                var sql = " SELECT * FROM db_utente";
                List<db_utente> mex = db.Query<db_utente>(sql);
                profilo_numero = mex[0].Num;
                codice_numero = mex[0].Cod;
                lbl_nome.Text = "numero=" + profilo_numero+"    codice="+ codice_numero;
                db.Close();
                textBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                tmr.Start();
                flowLayoutPanel2.AutoScroll = false;
                flowLayoutPanel2.HorizontalScroll.Maximum = 0;

            }
            // prende l'ip
            /*
            WebRequest wrGETURL = WebRequest.Create("http://danielesirangelo.altervista.org/mioIP.html");
            Stream objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);
            server_ip =  objReader.ReadLine();   */                
            popola_listbox();
        }

        #region variabili_globali
            IDictionary<string, string> dict = new Dictionary<string, string>();
            List<UserControl1> userControl1 = new List<UserControl1>();
            List<messaggio> messaggi_contatto_selezionato = new List<messaggio>();
            string profilo_numero;
            string codice_numero;
            string contatto_numero;
            public static Form1 form1Istance;
            public System.Windows.Forms.TextBox tbx;
            public SQLiteConnection db;
            string direcrtory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string server_ip= Properties.Resources.server_ip;
        #endregion
        #region gestione_oggetti_front_end
        //genera contatti
        public void popola_listbox()
        {   
          //  try
            {
            dict.Clear();
            flowLayoutPanel1.Controls.Clear();
            db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
            List<db_contatti> mex = db.Query<db_contatti>("SELECT * FROM db_contatti");
            for(int k = 0; k < mex.Count; k++)
            {                
                userControl1.Add(new UserControl1(server_ip,profilo_numero,codice_numero));
                userControl1[k].Username = mex[k].Name;
                userControl1[k].Num = mex[k].Num;
                    if (mex[k].Gruppo == "1")                    
                        userControl1[k].gruppo = true;
                    else
                        userControl1[k].gruppo = false;

                    dict.Add(mex[k].Name, mex[k].Num); 
                flowLayoutPanel1.Controls.Add(userControl1[k]);
            }
            db.Close ();
            }
            /*
            catch (Exception e)
            {
                
                if (e ==)
                {

                }
            }*/

        }
        //genera messaggi
        public bool controllo_gruppo()
        {
            try 
            { 
            db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
            var sql1 = "SELECT * FROM db_contatti WHERE Num = '" + contatto_numero+"'";
            List<db_contatti> temp = db.Query<db_contatti>(sql1);
                for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i].Gruppo == "1")
                    return true;
                }
            }
            catch (Exception e)
            {
                if (e is SQLiteException)
                {
                    
                }
            }
             
            return false;
        }
        public void aggiorna_listbox()
        {            
            db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
            var sql = "";
            //controlla se contatto_numero sia un gruppo o 
            try
            {                             
                if (controllo_gruppo())
                {
                    //gruppo
                    sql = " SELECT * FROM db_messaggi WHERE gruppo = '" + contatto_numero+"'";

                }
                else
                {
                    //contatto
                    sql = " SELECT * FROM db_messaggi WHERE Contatto = '" + contatto_numero + "' AND gruppo IS NULL";
                }
            }
            catch (Exception e)
            {
                if (e is SQLiteException)
                {

                }
            }
            List<db_messaggi> mex;
            flowLayoutPanel2.Controls.Clear();
            messaggi_contatto_selezionato.Clear();
            try
            {
                 mex = db.Query<db_messaggi>(sql);
                for (int i = 0; i < mex.Count; i++)
                {            
                    if (mex[i].I_o)
                    {
                        messaggi_contatto_selezionato.Add(new messaggio());
                        if (mex[i].Mesaggio.StartsWith("img///"))
                        {
                            messaggi_contatto_selezionato[i].i_t = true;
                            messaggi_contatto_selezionato[i].Img = visualizza_immagine(mex[i].Mesaggio.Substring(6));
                        }
                        else
                        {
                            messaggi_contatto_selezionato[i].i_t = false;
                            messaggi_contatto_selezionato[i].Messaggio = mex[i].Mesaggio;
                        }
                        messaggi_contatto_selezionato[i].Data = mex[i].Data.ToString();
                        messaggi_contatto_selezionato[i].Contatto = mex[i].Contatto;
                        messaggi_contatto_selezionato[i].Ancora = System.Windows.Forms.DockStyle.Left;
                        messaggi_contatto_selezionato[i].Colore = Color.FromArgb(255,14,14,14);                        
                        messaggi_contatto_selezionato[i].Width = flowLayoutPanel2.Width-20;
                        flowLayoutPanel2.Controls.Add(messaggi_contatto_selezionato[i]);                        
                    }
                    else
                    {
                        messaggi_contatto_selezionato.Add(new messaggio());
                        if (mex[i].Mesaggio.StartsWith("img///"))
                        {
                            messaggi_contatto_selezionato[i].i_t = true;
                            messaggi_contatto_selezionato[i].Img = visualizza_immagine(mex[i].Mesaggio.Substring(6));
                        }
                        else
                        {
                            messaggi_contatto_selezionato[i].i_t = false;
                            messaggi_contatto_selezionato[i].Messaggio = mex[i].Mesaggio;
                        }
                        messaggi_contatto_selezionato[i].Data = mex[i].Data.ToString();
                        messaggi_contatto_selezionato[i].Contatto = mex[i].Contatto;
                        messaggi_contatto_selezionato[i].Ancora = System.Windows.Forms.DockStyle.Right;
                        messaggi_contatto_selezionato[i].Colore = Color.FromArgb(255,137,97,134);
                        messaggi_contatto_selezionato[i].Width = flowLayoutPanel2.Width-20;
                        flowLayoutPanel2.Controls.Add(messaggi_contatto_selezionato[i]);                 
                    }
                }
                flowLayoutPanel2.AutoScroll = true;
                flowLayoutPanel2.AutoScrollPosition = new Point(0, flowLayoutPanel2.Height*mex.Count);
            }
            catch (Exception e)
            {
                if (e is SQLiteException)
                {

                }
            }

            textBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox4.Visible = true;
        }
        #endregion   
        #region comunicazione 
        private void invia_messaggio(string testo)
        {
            try
            {
                DateTime data = DateTime.Now;               
              //crea un oggetto WebRequest
                WebRequest request = WebRequest.Create(server_ip);
                request.Method = "POST";
                //imposta il contenuto della richiesta come un oggetto JSON
                string jsonData;
                bool controllo = controllo_gruppo();
                if (controllo)
                {
                    jsonData = Newtonsoft.Json.JsonConvert.SerializeObject("020" + "/-/" + contatto_numero + "/-/" + profilo_numero + "/-/" + codice_numero + "/-/"  + data.ToString() + "/-/" + testo);
                }
                else
                {
                     jsonData = Newtonsoft.Json.JsonConvert.SerializeObject("010" + "/-/" + contatto_numero + "/-/" + profilo_numero + "/-/" + codice_numero + "/-/"  + data.ToString() + "/-/" + testo);
                }
                
                byte[] byteArray = Encoding.UTF8.GetBytes(jsonData);
                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length; 
                //invia i dati della richiesta
                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }
                //ottieni risposta
                Stream objStream = request.GetResponse().GetResponseStream();
                StreamReader objReader = new StreamReader(objStream);
                string sLine = objReader.ReadLine();
                if(sLine != "Error")
                {
                    db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
                    db_messaggi temp;
                    if(controllo)
                        temp = new db_messaggi(profilo_numero, false, data.ToString(), testo,contatto_numero );
                    else
                        temp = new db_messaggi(contatto_numero, false, data.ToString(), testo, null);
                    db.Insert(temp);
                    db.Close();
                    aggiorna_listbox();
                    textBox1.Text = "";
                }
            }
            catch{}
        }
        private void richiesta_nuovi_messaggi()
        {
            try
            {
                string query = "?Q=" + "100" + "/-/" + profilo_numero + "/-/" + codice_numero+" ";
                WebRequest wrGETURL = WebRequest.Create(server_ip + query);
                Stream objStream = wrGETURL.GetResponse().GetResponseStream();
                StreamReader objReader = new StreamReader(objStream);
                string sLine = objReader.ReadLine();
                if (sLine != "")
                {
                    if (sLine != "Error")
                    {
                        string[] separatingStrings = { "--///--" };
                        string[] separatingStrings1 = { "/-/" };
                        string[] strings = sLine.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                        var db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
                        for (int i = 0; i < strings.Length; i++)
                        {
                            string[] messaggio = strings[i].Split(separatingStrings1, System.StringSplitOptions.RemoveEmptyEntries);
                            db_messaggi temp;
                            if (messaggio.Length == 3)
                            {
                                temp = new db_messaggi(messaggio[0], true, messaggio[1], messaggio[2],null);
                                db.Insert(temp);
                                if (!dict.Values.Contains(messaggio[0]))
                                {
                                    db_contatti temp1 = new db_contatti(messaggio[0], messaggio[0],"0");
                                    db.Insert(temp1);
                                    popola_listbox();
                                }
                            }
                            else
                            {
                                temp = new db_messaggi(messaggio[0], true, messaggio[1], messaggio[2], messaggio[3]);
                                db.Insert(temp);
                                if (!dict.Values.Contains(messaggio[3]))
                                {
                                    db_contatti temp1 = new db_contatti(messaggio[3], messaggio[3], "1");
                                    db.Insert(temp1);
                                    popola_listbox();
                                }
                            }                                                             
                        }
                        db.Close();
                        aggiorna_listbox();
                    }
                    else
                    {
                        MessageBox.Show("controlla il tuo account");
                    }
                }
                
            }
            catch(Exception e) 
            {
                if(e.Message== "Impossibile effettuare la connessione al server remoto.")
                {
                    tmr.Enabled = false;
                    tmr1_riavvia_tmr.Enabled = true;
                    MessageBox.Show(e.Message);
                }

            }
        }

        #endregion
        #region gestione_oggetti_form

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://danielesirangelo.altervista.org/TEAMSviluppatoriITIS/index.htm");
        }
        private void UserC_click(string temp)
        {        
            contatto_numero = dict[temp];
            aggiorna_listbox();
            for (int i = 0; i < userControl1.Count; i++)
            {
                if (userControl1[i].Num == contatto_numero)
                {
                    userControl1[i].Selected = true;
                }
                else
                {
                    userControl1[i].Selected = false;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            invia_messaggio(textBox1.Text);
        }
        private void btn_add_contatto_Click(object sender, EventArgs e)
        {           
            Form2 R = new Form2();
            this.Enabled = false;
            R.ShowDialog();
            popola_listbox();
            this.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Enabled = false;
            login.Show();
            this.Enabled = true;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UserC_click(textBox2.Text);
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            aggiorna_listbox();
        }
        #endregion
        #region timer
        private void tmr_Tick(object sender, EventArgs e)
        {
            /// <summary>
            /// ogni 1 sec fa una richiesta al server
            /// </summary>
            richiesta_nuovi_messaggi();

        }
        private void tmr1_riavvia_tmr_Tick(object sender, EventArgs e)
        {
            tmr.Start();
            tmr1_riavvia_tmr.Enabled = false;
        }
        #endregion

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region gestione immagini
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string immagine = "img///";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = File.ReadAllText(filename);
            Bitmap Imaging = (Bitmap)Image.FromFile(filename);
            using (MemoryStream ms = new MemoryStream())
            {
                //salva l'immagine in formato binario nel MemoryStream
                Imaging.Save(ms, ImageFormat.Bmp);

                //converte i dati binari in una stringa base64
                string base64String = Convert.ToBase64String(ms.ToArray());

                immagine += base64String;
            }
            invia_messaggio(immagine);
        }
        private Bitmap visualizza_immagine(string base64String) {
            
            //converte la stringa base64 in un array di byte
            byte[] imageBytes = Convert.FromBase64String(base64String);
            //crea un oggetto MemoryStream per memorizzare i dati dell'immagine
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                //crea un'immagine bitmap dai dati dell'immagine
                ms.Write(imageBytes, 0, imageBytes.Length);
                return (Bitmap) Image.FromStream(ms, true);

            }
        }
        #endregion

        private void btn_crea_gruppo_Click(object sender, EventArgs e)
        {
            aggiunta_dei_gruppi f = new aggiunta_dei_gruppi(profilo_numero,codice_numero, server_ip);
            f.Show();
        }
    }
}
