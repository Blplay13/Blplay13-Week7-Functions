using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
             //programm kusib kasutajal sisestada eesnimi;
            //programm kusib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab 1, siis kuvatakse kasutaja eesnime tagurpidi;
            //kui kasutaja sisestab 2, siis kuvatakse kasutaja eesnime esimest tahte;
            //kui kasutaja valib 3, siis kuvatakse kasitaja eesnime pikkust;

            Console.WriteLine("Palun sisestage oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Palun sisestage number 1 kuni 3:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)

            {
                case 1:
                    Reverse(userName);
                    break;
                case 2:
                    FirstLetter(userName);
                    break;
                case 3:
                    nameLength(userName);
                    break;
                default:
                    Console.WriteLine("Kena paeva!");
                    break;

            }
        }

        public static void Reverse(string userName)
        {
            for(int i = userName.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(userName[i]);
            }
        }

        public static void FirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu nime esimene taht on {userInput[0]}");
        }
        public static void nameLength(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sumbolit pikk");
        }
        
    }
}
