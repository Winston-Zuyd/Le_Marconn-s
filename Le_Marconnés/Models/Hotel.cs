using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Marconnés.Models
{
    //[Table("Hotels")]
    public class Hotel
    {
        //[Key]
        public int Hotel_id { get; set; }
        public int Aantal_kamers { get; set; }
        public int Aantal_medewerkers { get; set; }
        public string Eigenaar { get; set; }
        public int Aantal_reserveringen { get; set; }
        public int Aantal_gasten { get; set; }

        public Hotel(int hotel_id, int aantal_kamers, int aantal_medewerkers, string eigenaar, int aantal_reserveringen, int aantal_gasten)
        {
            Hotel_id = hotel_id;
            Aantal_kamers = aantal_kamers;
            Aantal_medewerkers = aantal_medewerkers;
            Eigenaar = eigenaar;
            Aantal_reserveringen = aantal_reserveringen;
            Aantal_gasten = aantal_gasten;
        }
        public Hotel()
        {
        }
    }
}
