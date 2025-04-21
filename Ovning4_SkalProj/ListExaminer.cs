using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    public class ListExaminer
    {
        public static void ExamineList()
        {
            
                List<string> theList = new List<string>();

                while (true)
                {
                    Console.Write("Skriv +namn för att lägga till eller -namn för att ta bort (eller 'exit' för att avsluta): ");
                    string input = Console.ReadLine();

                    if (input == "exit")
                        break;

                    if (string.IsNullOrWhiteSpace(input) || input.Length < 2)
                    {
                        Console.WriteLine("Skriv minst ett tecken efter + eller -.");
                        continue;
                    }

                    char nav = input[0];
                    string value = input.Substring(1);

                    switch (nav)
                    {
                        case '+':
                            theList.Add(value);
                            Console.WriteLine($"Lade till \"{value}\"");
                            break;

                        case '-':
                            if (theList.Remove(value))
                                Console.WriteLine($"Tog bort \"{value}\"");
                            else
                                Console.WriteLine($"\"{value}\" hittades inte i listan");
                            break;

                        default:
                            Console.WriteLine("Använd endast +namn eller -namn.");
                            break;
                    }

                    // 🧠 Observera Count och Capacity
                    Console.WriteLine($"Count: {theList.Count}, Capacity: {theList.Capacity}");
                }
            }
        }
    }


// Fråga 2: När ökar listans kapacitet?
//  När antalet element överskrider nuvarande kapacitet.

// Fråga 3: Med hur mycket ökar kapaciteten?
//  Den fördubblas i allmänhet (4 → 8 → 16 → 32...).

// Fråga 4: Varför ökar inte kapaciteten i samma takt som element läggs till?
//  För att undvika många små minnesallokeringar.

// Fråga 5: Minskar kapaciteten när element tas bort?
//  Nej, kapaciteten är konstant .

// Fråga 6: När är det fördelaktigt att använda en array istället för en lista?
//  När storleken är känd i förväg, prestanda är kritisk, eller man jobbar nära hårdvaran.




