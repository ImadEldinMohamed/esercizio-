using esercizio_preparanzo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_preparanzo
{
    internal  class Menu
    {
        public static double Totale { get; set; }

       


        public static List<string> BevandeList { get; set; } = new List<string>();
        public static void MostrailMenu()
        {
            Console.WriteLine("=======menu========");
            Console.WriteLine("1 coca-cola 5.5£");
            Console.WriteLine("2 panino   10£");
            Console.WriteLine("3 patatine 25£");
            Console.WriteLine("4 the 5$");
            Console.WriteLine(" 5 scontrino");

            int scelta=int.Parse(Console.ReadLine());

            if (scelta == 1) { 
            BevandeList.Add("1 coca-cola 5.5£");
                Totale += 5.5;
                MostrailMenu();
            
            }

            if (scelta == 2) {
                BevandeList.Add("2 panino   10£");
                Totale += 10;
                MostrailMenu();
            }

            if (scelta == 3)
            {
                BevandeList.Add("\"3 patatine 25£\"");
                Totale += 10;
                MostrailMenu();
            }

            if (scelta == 4)
            {
                BevandeList.Add("4 the 5$  ");
                Totale += 5;
                MostrailMenu();
            }



            if (scelta == 5)
            {
                scontrino();
                lista();
                Console.ReadKey();
            }


        }

    public static void scontrino()
        {

            Console.Clear();
            Console.WriteLine($"totale {Totale}");
            
        }


        public static void lista()
        {
            Console.WriteLine("lista spesa");

            foreach(string el in BevandeList)
            {
                Console.WriteLine(el);
            }
        }

        
    }
}


      