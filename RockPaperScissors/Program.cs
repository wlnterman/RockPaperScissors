using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissors
{
    class Program
    {
        static void PrintNierAutomata()
        {
            Console.WriteLine("\n" +
            "⠄⠄⠄⠄⢠⣿⣿⣿⣿⣿⢻⣿⣿⣿⣿⣿⣿⣿⣿⣯⢻⣿⣿⣿⣿⣆⠄⠄⠄\n" +
            "⠄⠄⣼⢀⣿⣿⣿⣿⣏⡏⠄⠹⣿⣿⣿⣿⣿⣿⣿⣿⣧⢻⣿⣿⣿⣿⡆⠄⠄\n" +
            "⠄⠄⡟⣼⣿⣿⣿⣿⣿⠄⠄⠄⠈⠻⣿⣿⣿⣿⣿⣿⣿⣇⢻⣿⣿⣿⣿⠄⠄\n" +
            "⠄⢰⠃⣿⣿⠿⣿⣿⣿⠄⠄⠄⠄⠄⠄⠙⠿⣿⣿⣿⣿⣿⠄⢿⣿⣿⣿⡄⠄\n" +
            "⠄⢸⢠⣿⣿⣧⡙⣿⣿⡆⠄⠄⠄⠄⠄⠄⠄⠈⠛⢿⣿⣿⡇⠸⣿⡿⣸⡇⠄\n" +
            "⠄⠈⡆⣿⣿⣿⣿⣦⡙⠳⠄⠄⠄⠄⠄⠄⢀⣠⣤⣀⣈⠙⠃⠄⠿⢇⣿⡇⠄\n" +
            "⠄⠄⡇⢿⣿⣿⣿⣿⡇⠄⠄⠄⠄⠄⣠⣶⣿⣿⣿⣿⣿⣿⣷⣆⡀⣼⣿⡇⠄\n" +
            "⠄⠄⢹⡘⣿⣿⣿⢿⣷⡀⠄⢀⣴⣾⣟⠉⠉⠉⠉⣽⣿⣿⣿⣿⠇⢹⣿⠃⠄\n" +
            "⠄⠄⠄⢷⡘⢿⣿⣎⢻⣷⠰⣿⣿⣿⣿⣦⣀⣀⣴⣿⣿⣿⠟⢫⡾⢸⡟⠄.\n" +
            "⠄⠄⠄⠄⠻⣦⡙⠿⣧⠙⢷⠙⠻⠿⢿⡿⠿⠿⠛⠋⠉⠄⠂⠘⠁⠞⠄⠄⠄\n" +
            "⠄⠄⠄⠄⠄⠈⠙⠑⣠⣤⣴⡖⠄⠿⣋⣉⣉⡁⠄⢾⣦⠄⠄⠄⠄⠄⠄⠄⠄\n");
        }

        static void PrintPepe()
        {
            Console.WriteLine("\n" +
            "═════════▄▄▄▄▄═════▄▄▄▄▄════════\n" +
            "═════▄▀▀▀░░░░░▀▀▄▀▀░░░▄░▀▄══════\n" +
            "═══▄▀░░▀▄▄▀▀▀▀▄▄░▀▄▄▀▀▀▀▀▀█▄════\n" +
            "══▄▀░░░▀░░░░▄▄▄▄▄██░░░▄▄▄▄▄▄▀▄══\n" +
            "═▄▀░▄░░░▄▄▀▀═══════▀█▀══════▀▀█▄\n" +
            "▀░░░█░░█═══════███══█═════███══█\n" +
            "░░░░░░░▀▄▄═════▀▀▀══█═════▀▀▀═▄█\n" +
            "█░░░░░░░░▀▀▀█▄▄▄▄▄█▀░▀▀▀▀▀▀▀▀█▀═\n" +
            "▀░░░░░░░░░░░▄▄▄▄▀▀░░░▀▄▄▄▄▄▀█═══\n" +
            "░░░░░░░░░░░░░░░░░░░░░░░▀░░░░▀▄══\n" +
            "░░░░░░░▄▄▄▄▄▄▄▄▄░░░░░░░░░░░░░█══\n" +
            "░░░░░░█░▄▄▄▄▄▄▄░▀▀▀▀▀▀▀▀▀▀▀▀▀█══\n" +
            "░░░█░░▀▄▄▄▄▄▄▄░▀▀▀▀▀▀▀▀▀▀▀▀▀█═══\n" +
            "░░░░▀▄░░░░░░░░▀▀▀▀▀▀▀▀▀▀██▀▀════\n" +
            "▄▄▄▄▄░░░░░░░░░░░░░░░░▄▀▀════════\n" +
            "▓▓▓▓▓▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄═════════\n" +
            "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▀\n");
        }

        static void PrintFeelLikeASir()
        {
            Console.WriteLine("\n" +
            "░░░░░░░░▄▄▄███░░░░░░░░░░░░░░░░░░░░\n" +
            "░░░▄▄██████████░░░░░░░░░░░░░░░░░░░\n" +
            "░███████████████░░░░░░░░░░░░░░░░░░\n" +
            "░▀███████████████░░░░░▄▄▄░░░░░░░░░\n" +
            "░░░███████████████▄███▀▀▀░░░░░░░░░\n" +
            "░░░░███████████████▄▄░░░░░░░░░░░░░\n" +
            "░░░░▄████████▀▀▄▄▄▄▄░▀░░░░░░░░░░░░\n" +
            "▄███████▀█▄▀█▄░░█░▀▀▀░█░░▄▄░░░░░░░\n" +
            "▀▀░░░██▄█▄░░▀█░░▄███████▄█▀░░░▄░░░\n" +
            "░░░░░█░█▀▄▄▀▄▀░█▀▀▀█▀▄▄▀░░░░░░▄░▄█\n" +
            "░░░░░█░█░░▀▀▄▄█▀░█▀▀░░█░░░░░░░▀██░\n" +
            "░░░░░▀█▄░░░░░░░░░░░░░▄▀░░░░░░▄██░░\n" +
            "░░░░░░▀█▄▄░░░░░░░░▄▄█░░░░░░▄▀░░█░░\n" +
            "░░░░░░░░░▀███▀▀████▄██▄▄░░▄▀░░░░░░\n" +
            "░░░░░░░░░░░█▄▀██▀██▀▄█▄░▀▀░░░░░░░░\n" +
            "░░░░░░░░░░░██░▀█▄█░█▀░▀▄░░░░░░░░░░\n" +
            "░░░░░░░░░░█░█▄░░▀█▄▄▄░░█░░░░░░░░░░\n" +
            "░░░░░░░░░░█▀██▀▀▀▀░█▄░░░░░░░░░░░░░\n" +
            "░░░░░░░░░░░░▀░░░░░░░░░░░▀░░░░░░░░░\n");
        }

        static bool ValidateArgs(string[] args)
        {
            Boolean validInput = true;
            if (args.Length < 4)
            {
                Console.WriteLine(" (!) number of arguments must be grater than 3\n");
                validInput = false;
            }

            if ((args.Length - 1) % 2 == 0)
            {
                Console.WriteLine(" (!) number of arguments must be odd\n");
                validInput = false;
            }

            var list = new List<string>(args);
            if (list.Count != list.Distinct().Count())
            {
                Console.WriteLine(" (!) all arguments must be unique\n");
                validInput = false;
            }
            return validInput;
        }

        static void EmulateGame(string[] args,int userChoice, int computerChoice)
        {
            Console.WriteLine("Computer move: " + args[computerChoice]);
            
            var calculate = new WinCondition();
            var tmp = calculate.CalculateWinnerArray(args, args[userChoice]);
            if (args[userChoice] == args[computerChoice])
                Console.WriteLine("Draw!");
            else if (Array.IndexOf(tmp, args[computerChoice]) == -1)
            {
                Console.WriteLine("You win!");                                                                                     ///fix
                //PrintNierAutomata();
                PrintFeelLikeASir();
            }
            else
            {
                Console.WriteLine("You lost!");
                PrintPepe();
            }
            
        }
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        static void Main(string[] args)
        {
            Boolean userTurn = true;
            String userMove = "";
            var drawWinnerTable = new DrawTable();
            var rnd = new Random();
            var cryptography = new Cryptography();

            Boolean validInput = ValidateArgs(args);

            if (!validInput)
            {
                Console.WriteLine("------   example_1:dotnet run program.cs 1 2 3 4 5 6 7     ------\n" +
                                  "------   example_2:dotnet run program.cs rock paper spok   ------\n" +
                                  "-----------------------------------------------------------------\n\n");
                return;
            }
                
            Console.WriteLine("Hello there!\n" +
                              "Welcome to Rock Paper Scisors simulator");

            int computerChoice = rnd.Next(1, args.Length - 1);//returns random integers < 10
            Console.WriteLine("computerChoice " + args[computerChoice]);
            byte[] cryptoKey = cryptography.GenerateCryptoKey();
            byte[] HMAC = cryptography.GenerateHMAC(cryptoKey, Encoding.Default.GetBytes(args[computerChoice]));
            Console.WriteLine("HMAC:\n"+ BitConverter.ToString(HMAC).Replace("-", "").ToUpper());

            while (userTurn)
            {
                Console.WriteLine("\nAvailable moves:");
                for (int i = 1; i < args.Length; i++)
                    Console.WriteLine(i + " - " + args[i]);
                Console.WriteLine("0 - exit\n" +
                                  "? - help\n" +
                                  "Enter your move:");

                userMove = Console.ReadLine();
                bool parseResult = int.TryParse(userMove, out var userChoice);
                
                if ((userMove != "?") && (parseResult == false))
                {
                    Console.WriteLine("Incorrect input! Try again!\n\n\n");
                    continue;
                }
                Console.WriteLine("Your move: " + args[userChoice]);

                if (userMove == "0")
                    System.Environment.Exit(0);
                else if (userMove == "?")
                {
                    drawWinnerTable.DrawWinnerTable(args);
                    Console.WriteLine("Press any key to return to menu ");
                    Console.ReadLine();
                }
                else
                {
                    EmulateGame(args, userChoice, computerChoice);
                    Console.WriteLine("HMAK Key:\n" + BitConverter.ToString(cryptoKey).Replace("-", "").ToUpper());
                    userTurn = false;
                }
                
            }
        }
    }
}
