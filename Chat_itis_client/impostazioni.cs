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
    public partial class impostazioni : Form
    {
        private messaggio Mex;
        public impostazioni(messaggio _mex)
        {
            InitializeComponent();
            Mex = _mex;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = Cursor.Position;
        }

        private void btn_Copia_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(Mex.Messaggio);
            this.Close();
        }
        string direcrtory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        private void btn_Elimina_Click(object sender, EventArgs e)
        {
            SQLiteConnection db = new SQLiteConnection(direcrtory + @"\ChatItisUser.db3");
            var sql = "DELETE FROM db_messaggi WHERE Contatto = '"+ Mex.Contatto+"' AND Data = '"+Mex.Data+"'";// +"' AND Mesaggio = '"+Mex.Messaggio
            List<db_messaggi> mex = db.Query<db_messaggi>(sql);
            db.Close();
            Form1.form1Istance.aggiorna_listbox();
            this.Close();
        }
        private void btn_Annulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
