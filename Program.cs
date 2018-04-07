using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            var massiiv = new string[10] { "Kaur", "Mati", "Kristel", "Heleri", "Trevor", "Kristjan", "Kelli", "Kevin", "Maarika", "Laura" };

            Console.WriteLine("Sul on sellised tegelased: " + massiiv[0] + ", " + massiiv[1] + ", " + massiiv[2] + ", " + massiiv[3] + ", " + massiiv[4] + ", " + massiiv[5] + ", " + massiiv[6] + ", " + massiiv[7] + ", " + massiiv[8] + ", " + massiiv[9]);
            Console.WriteLine("Sisesta lauseid, kus keegi midagi teeb. Ma kirjutan kõik nimed suure algustähega.");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("viga sisestamisel");
            }
            else
                Console.WriteLine("Sa sisestasid: " + input); // see minule kontrolliks

            //var sõnadlauses = input.Split(new char[] { ' ', '.' }); // saan sisestatud sõnade array?
            var builder = new StringBuilder(input);
            //foreach
            //tahan sisestatud sõnade loetelust leida üles sellised sõnad=nimed, 
            //mis on olemas algses nimede loetelus massiiv
            //(var nimilauses in massiiv)
            //annan nendele nimedele suure algustähe: muudetakse täht indeksiga 0, so esimene täht.
            //teised tähed nimes väikestena 

            // { var nimiSuurTähtedega = char.ToUpper(nimilauses[0]) + nimilauses.ToLower().Substring(1);

            // tahan saada tulemust: nimed suure algustähega }
            builder.Replace("kaur", "Kaur");
            builder.Replace("mati", "Mati");
            builder.Replace("kristel", "Kristel");
            builder.Replace("heleri", "Heleri");
            builder.Replace("trevor", "Trevor");
            builder.AppendLine();
            builder.Replace("kristjan", "Kristjan");
            builder.Replace("kelli", "Kelli");
            builder.Replace("kevin", "Kevin");
            builder.Replace("maarika", "Maarika");
            builder.Replace("laura", "Laura");

            Console.WriteLine(builder);
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
    }
}
