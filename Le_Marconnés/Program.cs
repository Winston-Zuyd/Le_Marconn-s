using Le_Marconnés.Models;

namespace Le_Marconnés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DAL dal = new DAL();

            Gast gast = new Gast
            {
                Gast_id = 1,
                E_mail = "winstondang77@gmail.com",
                Telefoonnummer = "0685361827",
                Reservering_id = 1
            };

            dal.AddGast(gast);

            Reservering reservering = new Reservering
            {
                Reservering_id = 1,
                Incheck_datum = DateTime.Parse("2025-07-01"),
                Uitcheck_datum = DateTime.Parse("2025-07-10"),
                Kamer_id = 101
            }; 

            /*  
            Console.WriteLine("Gast id: ");
            int gast_id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("E-mail: ");
            string e_mail = Console.ReadLine();
            Console.WriteLine("Telefoonnummer: ");
            string telefoonnummer = Console.ReadLine();
            Console.WriteLine("Reservering ID: ");
            int reservering_id = Int32.Parse(Console.ReadLine());

            Gast nieuweGast = new Gast(gast_id, e_mail, telefoonnummer, reservering_id);
            dal.AddGast(nieuweGast);
            Console.WriteLine("Nieuwe gast toegevoegd.");

            var gasten = dal.Gasten();

            foreach (var gast in gasten)
            {
                Console.WriteLine($"Gast ID: {gast.Gast_id}, E-mail: {gast.E_mail}, Telefoonnummer: {gast.Telefoonnummer}, Reservering ID: {gast.Reservering_id}");
            }
            */
        }
    }
}
