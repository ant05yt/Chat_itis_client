using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Chat_itis_client
{
    internal class db_utente
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Num { get; set; }
        public string Cod { get; set; }
        //public Bitmap Img { get; set; }

        public db_utente() { }

        public db_utente( int id, string name, string num, string cod /*,Bitmap img*/)
        {
            Name = name;
            Num = num;
            Cod = cod;
            ID = id;
            // Img = img;
        }
    }
}
