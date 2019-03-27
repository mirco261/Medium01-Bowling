using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            Random hod = new Random();
            int vysledok1;
            string vysledok1string;
            int vysledok2;
            string vysledok2string;

            StringBuilder sb1 = new StringBuilder();

            Console.WriteLine("***Bowling***");
            Console.ReadLine();

            //10kôl
            for (int i = 0; i < 10; i++)
            {

                //1. hod
                vysledok1 = hod.Next(0,10);

                switch (vysledok1)
                {
                    case 0:
                        {
                            vysledok1string = "-";
                            break;
                        }
                    case 10:
                        {
                            vysledok1string = "X";
                            break;
                        }
                    default:
                        {
                            vysledok1string = vysledok1.ToString();
                        }
                        break;
                }
                sb1.Append(vysledok1string);
                Console.WriteLine($"{vysledok1string}\n---\n {vysledok1}");
                Console.ReadLine();

                //2. hod
                if (vysledok1 == 10)  //ak je prvý spare, neriešim dalej
                {
                    break;
                }
                else
                {
                    vysledok2 = hod.Next(0, 10 - vysledok1); //vypočítavam iba rozdiel 10 - vysledok1

                    switch (vysledok2)
                    {
                        case 0:
                            {
                                vysledok2string = "-";
                                break;
                            }
                        case 10:
                            {
                                vysledok2string = "X";
                                break;
                            }
                        default:
                            {
                                vysledok2string = vysledok1.ToString();
                            }
                            break;
                    }

                    Console.WriteLine($"{vysledok1} {vysledok2}\n---\n {vysledok1+vysledok2}");
                }
                Console.ReadLine();
            }
        }
    }
}
