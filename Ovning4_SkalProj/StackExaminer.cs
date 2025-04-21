using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    public static class StackExaminer
    {
        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        public static void ExamineStack()
        {
            Stack<string> stack = new Stack<string>();

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
                        stack.Push(value);
                        Console.WriteLine($"Lade till \"{value}\" i stacken");
                        break;

                    case '-':
                        if (stack.Count > 0)
                        {
                            string removed = stack.Pop();
                            Console.WriteLine($"Tog bort \"{removed}\" från stacken");
                        }
                        else
                        {
                            Console.WriteLine("Stacken är tom.");
                        }
                        break;

                    default:
                        Console.WriteLine("Använd +namn eller -.");
                        break;
                }

                // Visa innehållet i stacken
                Console.WriteLine("Nuvarande stack: " + string.Join(", ", stack));
            }

            // ---------------------
            // Svar: Varför är det inte smart att använda stack i ICA-kön?
            // ---------------------
            // En stack använder FILO: First In, Last Out.
            // Det innebär att den som kom sist i kön blir betjänad först!
            // Det är orättvist och funkar inte i kö-situationer.

            /*         Skriv + namn för att lägga till, -för att ta bort, eller 'exit' för att avsluta: +Kalle
         Lade till "Kalle" i stacken
         Nuvarande stack: Kalle
         Skriv + namn för att lägga till, -för att ta bort, eller 'exit' för att avsluta: +greta
         Lade till "greta" i stacken
         Nuvarande stack: greta, Kalle
         Skriv + namn för att lägga till, -för att ta bort, eller 'exit' för att avsluta: -Kalle
         Tog bort "greta" från stacken ❌ 
         Nuvarande stack: Kalle*/
        }

        /// <summary>
        /// Reverses a string using a Stack
        /// </summary>
        public static void ReverseText()
        {
            Console.Write("Skriv en text att vända: ");
            string input = Console.ReadLine();

            Stack<char> charStack = new Stack<char>();

            foreach (char c in input)
            {
                charStack.Push(c);
            }

            Console.Write("Omvänd text: ");
            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }

            Console.WriteLine(); 
        }

    }
}
