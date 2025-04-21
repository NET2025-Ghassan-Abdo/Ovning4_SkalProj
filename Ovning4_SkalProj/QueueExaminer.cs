using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    public class QueueExaminer
    {
        public static void ExamineQueue()
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                Console.Write("Skriv +namn för att lägga till, - för att ta bort, eller 'exit' för att avsluta: ");
                string input = Console.ReadLine();

                if (input == "exit")
                    break;

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                char nav = input[0];
                string value = input.Length > 1 ? input.Substring(1) : "";

                switch (nav)
                {
                    case '+':
                        queue.Enqueue(value);
                        Console.WriteLine($"Lade till \"{value}\" i kön");
                        break;

                    case '-':
                        if (queue.Count > 0)
                        {
                            string removed = queue.Dequeue();
                            Console.WriteLine($"Tog bort \"{removed}\" från kön");
                        }
                        else
                        {
                            Console.WriteLine("Kön är tom.");
                        }
                        break;

                    default:
                        Console.WriteLine("Använd +namn för att lägga till eller - för att ta bort.");
                        break;
                }

                // Visa innehållet i kön
                Console.WriteLine("Nuvarande kö: " + string.Join(", ", queue));
            }

            // ---------------------
            // Svar på fråga om kö (Queue) och FIFO
            // ---------------------

            // En Queue använder FIFO-principen: First In, First Out.
            // Det innebär att det objekt som läggs till först är det som tas bort först.
            // Det är därför bra att använda köer i system som hanterar turordning,
            // t.ex. kö i butik, utskriftskö eller nätverkspaket.
        }
    }

    

}
