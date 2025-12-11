using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Marconnés.Models
{
    public class Gast
    {
        public int Gast_id { get; set; }
        public string E_mail { get; set; }
        public string Telefoonnummer { get; set; }
        public int Reservering_id { get; set; }

        public Gast(int gast_id, string e_mail, string telefoonnummer, int reservering_id)
        {
            Gast_id = gast_id;
            E_mail = e_mail;
            Telefoonnummer = telefoonnummer;
            Reservering_id = reservering_id;
        }

        public Gast()
        {
        }
    }
}
