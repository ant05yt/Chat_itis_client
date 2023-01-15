using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Chat_itis_client
{
    internal class db_contatti
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Num { get; set; }
        //public Bitmap Img { get; set; }

        public db_contatti() { }

        public db_contatti( string name, string num /*,Bitmap img*/)
        {
            Name = name;
            Num = num;
           // Img = img;
        }
        public db_contatti(int id,string name, string num /*,Bitmap img*/)
        {
            Id = id;
            Name = name;
            Num = num;
            // Img = img;
        }
    }
}
