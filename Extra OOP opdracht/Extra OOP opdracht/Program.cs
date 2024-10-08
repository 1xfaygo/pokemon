using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Xml.Linq;


namespace NFL;
class Program
{
    static void Main()
    {
        while (true)
        {
            //lijst met complete spelers
            List<Players> names = new List<Players>();
            Console.WriteLine("Enter 6 names:");

            //bedoeld om de spelersnaam tijdelijk op te slaan
            string playerName = "";

            //bedoeld om de jerseynr tijdelijk op te slaan
            string jersey;

            // een loop voor om de naam jersernr aan te vullen
            for (int i = 0; i < 3; i++)
            {
                //hier vraag ik de naam op van de player en sla ik het op 
                Console.Write($"Enter name player #{i + 1}: ");
                playerName = Console.ReadLine() ?? "";

                // hier vraag ik de jerseynr op van de player en sla ik het op 
                Console.Write($"Enter jerseynumber player #{i + 1}: ");
                jersey = Console.ReadLine() ?? "";
                int jerseynumber = int.Parse(jersey);

                //hier vraag ik de positie op van de player en sla ik het op 
                Console.Write($"Enter position of player #{i + 1} (QB/Offence/Defence): ");
                string position = Console.ReadLine() ?? "";
                string postion_lower = position.ToLower();


                // ik check ik als de postion het zelfde is als de class waar hij in moet 
                if (postion_lower == "offence")
                {
                    //hier voeg ik player toe aan een class offence met naam jerseynr en value voor atributen
                    Players player = new Offence(playerName, jerseynumber, postion_lower, 80, 70, 85);

                    // hier voeg ik de player die de class defence heeft met naam ect toe aan de lijst names
                    names.Add(player);
                }

                else if (postion_lower == "defence")
                {
                    //hier voeg ik player toe aan een class defence met naam jerseynr en value voor atributen
                    Players playersd = new Defence(playerName, jerseynumber, postion_lower, 90, 69, 59);

                    // hier voeg ik de player die de class defence heeft met naam ect toe aan de lijst names
                    names.Add(playersd);
                }


                else
                {
                    Players playerqb = new Quarterback(playerName, jerseynumber, postion_lower, 85, 85, 85);

                    // hier voeg ik de player die de class defence heeft met naam ect toe aan de lijst names
                    names.Add(playerqb);
                }
            }


            // hier loop ik door de lijst heen ik kijk ik naar de welke item in lijst de class offence heeft
            Console.WriteLine("Offence: ");
            foreach (Players n in names.OfType<Offence>())
            {
                Console.WriteLine(n.Name);
            }

            // dit is een lege lijn voor overzicht in de terminal zo dat ik niet in de war raakt 
            Console.WriteLine("    ");

            // hier loop ik door de lijst heen ik kijk ik naar de welke item in lijst de class defence heeft
            Console.WriteLine("Defence");
            foreach (Players n in names.OfType<Defence>())
            {
                Console.WriteLine(n.Name);
            }

            // dit is een lege lijn voor overzicht in de terminal zo dat ik niet in de war raakt 
            Console.WriteLine("    ");

            // hier loop ik door de lijst heen ik kijk ik naar de welke item in lijst de class defence heeft
            Console.WriteLine("QB");
            foreach (Players n in names.OfType<Quarterback>())
            {
                Console.WriteLine(n.Name);
            }

            // dit is een lege lijn voor overzicht in de terminal
            Console.WriteLine("    ");

            // Zoek de eerste Quarterback in de lijst en stopt hem in de variable qb
            Quarterback qb = names.OfType<Quarterback>().FirstOrDefault();

            //hier check ik of de qb null is want dat kan dus als dat zo is zeg ik dat de spel niet kan beginnen als er wel een qb is dan begint het spel wel.
            if (qb != null)
            {
                Console.WriteLine($"{qb.Name} staat klaar om de spel te beginnen.");
            }
            else
            {
                Console.WriteLine("er is geen quarteback om het spel te beginnen");
                break;
            }



            // Zoek de eerste Offence speler in de lijst
            Offence offence = names.OfType<Offence>().FirstOrDefault();
            //hier check ik of de aanvaller null is want dat kan dus als dat zo is zeg ik dat de spel niet kan beginnen als er wel een aanvaller is dan begint het spel wel.
            if (offence != null)
            {
                Console.WriteLine($"{offence.Name} staat klaar om de spel te beginnen.");
            }
            else
            {
                Console.WriteLine("er is geen aanvaller om het spel te beginnen");
                break;
            }

            // Zoek de eerste Defence speler in de lijst
            Defence defence = names.OfType<Defence>().FirstOrDefault();

            //hier check ik of de defence null is want dat kan dus als dat zo is zeg ik dat de spel niet kan beginnen als er wel een defender is dan begint het spel wel.
            if (defence != null)
            {
                Console.WriteLine($"{defence.Name} staat klaar om de spel te beginnen.");
            }
            else
            {
                Console.WriteLine("er is geen defender om het spel te beginnen");
                break;
            }


            Console.WriteLine("Spel begint");
            Console.WriteLine($"Offence: {offence.Name} staat klaar om aan te vallen");
            Console.WriteLine($"QB:{qb.Name}krijgt de bal gesnapt");
            Console.WriteLine($"Gaat de QB: {qb.Name} de bal gooien naar de receiver (1) of gaat hij rennen naar 1st Down (2)?");

            var play1 = Console.ReadLine();


            if (play1 == "1")
            {
                Console.WriteLine($"{qb.Name} besluit te gooien naar de receiver.");
                Console.WriteLine($" receiver {offence.Name} heeft de ball gevagnen en rent en scoort 50 yard TD");
                break;
            }
            else if (play1 == "2")
            {
                Console.WriteLine($"{qb.Name} besluit te rennen naar de 1st end maar word onderweg getackelt door {defence.Name}");
                Console.WriteLine($"en fumbeld de ball en {defence.Name} pakt de ball rent naar de endzone en maakt een TD.");
                break;
            }
            else
            {
                Console.WriteLine("Ongeldige invoer.");
            }
            break;
        }
    }
}