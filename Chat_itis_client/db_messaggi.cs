using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Chat_itis_client
{
    internal class db_messaggi
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Contatto { get; set; }
        public bool I_o { get; set; } // true= ricevuto false= inviato
        public string Data { get; set; }
        public string Mesaggio { get; set; }

        public db_messaggi() { }
        public db_messaggi( string contatto, bool i_o, string data, string mesaggio)
        {
            Contatto = contatto;
            I_o = i_o;
            Data = data;
            Mesaggio = mesaggio;
        }
    }
}
