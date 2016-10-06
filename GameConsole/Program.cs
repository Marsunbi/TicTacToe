using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Services;

namespace GameConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }
        public void Run()
        {
            bool running = true;
            char choice;

            do
            {
                GameBoardLayout();
                choice = GetUsersChoice();
                Console.WriteLine();
                switch (choice)
                {
                    case '1': Console.WriteLine(""); break;
                    case '2': Console.WriteLine(""); break;
                    case '3': Console.WriteLine(""); break;
                    case '4': Console.WriteLine(""); break;
                    case '5': Console.WriteLine(""); break;
                    case '6': Console.WriteLine(""); break;
                    case '7': Console.WriteLine(""); break;
                    case '8': Console.WriteLine(""); break;
                    case '9': Console.WriteLine(""); break;
                    default: ShowSelectionError(); break;
                }
                Console.WriteLine("Your choice");
                Console.ReadKey();
            } while (running);
        }

        private void ShowSelectionError()
        {
            Console.WriteLine("You stupid");
        }

        private void GameBoardLayout()
        {
            string b = ("|_" + "|_|_|" + Environment.NewLine + "|_|_|_|" + Environment.NewLine + "|_|_|_|");

            Console.WriteLine(b);
        }

        private char GetUsersChoice()
        {
            Console.WriteLine("Pick a square from 1 - 9");
            return Console.ReadKey().KeyChar;
        }
    }
}

