using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Le_Marconnés.Models
{
    public class Kamer
    {
        public int Kamer_id { get; set; }
        public string Kamer_type { get; set; }
        public double Prijs_per_nacht { get; set; }
        public string Status { get; set; }
        public float Btw_percentage { get; set; }
        public string Faciliteiten { get; set; }

        public Kamer(int kamer_id, string kamer_type, double prijs_per_nacht, string status, float btw_percentage, string faciliteiten)
        {
            Kamer_id = kamer_id;
            Kamer_type = kamer_type;
            Prijs_per_nacht = prijs_per_nacht;
            Status = status;
            Btw_percentage = btw_percentage;
            Faciliteiten = faciliteiten;
        }
        public Kamer()
        {
        }
    }
}
