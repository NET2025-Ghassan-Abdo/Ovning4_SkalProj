
using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application"
                    + "\n5. Reverse Text using Stack")
;
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ListExaminer.ExamineList();
                        break;
                    case '2':
                        QueueExaminer.ExamineQueue();
                        break;
                    case '3':
                        StackExaminer.ExamineStack();
                        break;
                    case '4':
                        ParenthesisChecker.CheckParenthesis();
                        break;
                    case '5':
                        StackExaminer.ReverseText();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;

                    /*
                * Extend the menu to include the recursive 
                * and iterative exercises.
                */
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        
        
        
        

        

    }
}