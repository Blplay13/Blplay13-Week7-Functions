using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
             //programm kusib kasutajal sesestada oma eesnime;
            //programm kuvab kasutaja eesnime pikkust;
            //programm kuvab kasutaja eesnime esimest tahte;
            //programm kuvab kasutaja eesnime tagurpidi;
            //main meetodis ei tohi olla rohkem kui kolm rida koodi

            Console.WriteLine("Palun sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            GetUserNameData(userName);
        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sumbolit pikk");
            Console.WriteLine($"Sinu nime esimene taht on {userInput[0]}");

            for(int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(userInput[i]);
            }
            
        }
    }
}
