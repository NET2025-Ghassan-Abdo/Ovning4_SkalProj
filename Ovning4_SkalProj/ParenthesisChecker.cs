using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    public static class ParenthesisChecker
    {
        /// <summary>
        /// Checks if a string contains correctly matched parentheses
        /// </summary>
        public static void CheckParenthesis()
        {
            Console.Write("Skriv en sträng att kontrollera: ");
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            bool balanced = true;

            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        balanced = false;
                        break;
                    }

                    char open = stack.Pop();
                    if (!IsMatchingPair(open, c))
                    {
                        balanced = false;
                        break;
                    }
                }
            }

            if (stack.Count > 0)
            {
                balanced = false;
            }

            Console.WriteLine(balanced ? "Strängen är VÄLFORMAD ✅" : "Strängen är FELFORMAD ❌");
        }

        public static bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
    }
}
