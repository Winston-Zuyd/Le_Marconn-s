using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Marconnés.Models
{
    public class Reservering
    {
        public int Reservering_id { get; set; }
        public int Reserveringnummer { get; set; }
        public DateTime Incheck_datum { get; set; }
        public DateTime Uitcheck_datum { get; set; }
        public int Aantal_personen { get; set; }
        public int Kamer_id { get; set; }
        public string Opties { get; set; }
        public float Totaal_prijs { get; set; }
        public string Betaal_status { get; set; }

        public Reservering(int reservering_id, int reserveringnummer, DateTime incheck_datum, DateTime uitcheck_datum, int aantal_personen, int kamer_id, string opties, float totaal_prijs, string betaal_status)
        {
            Reservering_id = reservering_id;
            Reserveringnummer = reserveringnummer;
            Incheck_datum = incheck_datum;
            Uitcheck_datum = uitcheck_datum;
            Aantal_personen = aantal_personen;
            Kamer_id = kamer_id;
            Opties = opties;
            Totaal_prijs = totaal_prijs;
            Betaal_status = betaal_status;
        }

        public Reservering()
        {
        }
    }
}
