using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_itis_client
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string direcrtory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            int controllo = controlla_esistenza();
            if (controllo == 2)
            {
                var db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
                db_contatti temp = new db_contatti(tbx_nome.Text,tbx_num.Text,"0"/*,Properties.Resources.Account_User_PNG_Photo1*/);
                db.Insert(temp);
                db.Close();
                this.Close();
            }
            else if(controllo == 1)
            {
                MessageBox.Show("esiste già un contatto con questo nome");
            }
            else
            {
                MessageBox.Show("il contatto già esiste");
            }


            //chiedi immagine contatto a server
            
        }

        private int controlla_esistenza()
        {
            var db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
            var sql = " SELECT * FROM db_contatti ";
            List<db_contatti> mex = db.Query<db_contatti>(sql);
            db_contatti temp = new db_contatti(tbx_nome.Text, tbx_num.Text,"0"/*,Properties.Resources.Account_User_PNG_Photo1*/);
            for (int k = 0; k < mex.Count; k++)
            {
                if(mex[k].Name == temp.Name) { return 1; }
                if (mex[k].Num == temp.Num) { return 0; }
            }
            return 2;
        }
    }
}
