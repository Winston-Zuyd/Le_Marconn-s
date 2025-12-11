using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Marconnés.Models
{
    public class DAL
    {
        private readonly string ConnectionString = "Data Source=localhost;Initial Catalog=LeMarconnés_DB;Integrated Security=True;Trust Server Certificate=True";

        public List <Hotel> Hotel = new List<Hotel>();
        public List <Kamer> Kamers = new List<Kamer>();
        public List <Reservering> Reserveringen= new List<Reservering>();
        public List <Gast> Gasten = new List<Gast>();

        public DAL()
        {
            //FillListFromDb();
            FillListFromCode();
        }
        /*
        public List<Gast> Gasten()
        {
            var gasten = new List<Gast>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT gast_id, mail, telefoonnummer, reserveringnummer FROM GastTbl";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var gast = new Gast
                            {
                                Gast_id = reader.GetInt32(0),
                                E_mail = reader.GetString(1),
                                Telefoonnummer = reader.GetString(2),
                                Reservering_id = reader.GetInt32(3)
                            };
                            gasten.Add(gast);
                        }
                    }
                }
            }
            return gasten;
        } 
        public void AddGast(Gast gast)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "INSERT INTO GastTbl (gast_id, mail, telefoonnummer, reserveringnummer) VALUES (@gast_id, @mail, @telefoonnummer, @reserveringnummer)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@gast_id", gast.Gast_id);
                    command.Parameters.AddWithValue("@mail", gast.E_mail);
                    command.Parameters.AddWithValue("@telefoonnummer", gast.Telefoonnummer);
                    command.Parameters.AddWithValue("@reserveringnummer", gast.Reservering_id);

                    command.ExecuteNonQuery();
                }
            }
        }
        */
    }
}
