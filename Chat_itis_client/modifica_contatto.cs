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
    public partial class modifica_contatto : Form
    {
        private UserControl1 Uc = null;
        public modifica_contatto(UserControl1 _uc)
        {
            InitializeComponent();
            Uc = _uc;   
            textBox1.Text = _uc.Username;
            textBox2.Text = _uc.Num;
           // pictureBox1.Image=
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Uc.Num;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string direcrtory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private void button1_Click(object sender, EventArgs e)
        {
            
            SQLiteConnection db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
            var sql = " SELECT * FROM db_contatti WHERE Num = " + Uc.Num;
            List<db_contatti> mex = db.Query<db_contatti>(sql);
            db_contatti temp = new db_contatti(mex[0].Id,textBox1.Text, textBox2.Text/*,Properties.Resources.Account_User_PNG_Photo1*/);           
            db.InsertOrReplace(temp);
            db.Close();
            Form1.form1Istance.popola_listbox();
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SQLiteConnection db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
            var sql = " DELETE FROM db_messaggi WHERE Contatto = " + Uc.Num;
            db.Query<db_contatti>(sql);
            var sql1 = " DELETE FROM db_contatti WHERE Num = " + Uc.Num;
            db.Query<db_contatti>(sql1);
            db.Close();
            MessageBox.Show("contatto_cancellato");
            Form1.form1Istance.popola_listbox();
            this.Close();

        }
    }
}
