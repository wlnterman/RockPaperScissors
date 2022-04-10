using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class DrawTable
    {
        public void DrawWinnerTable(string[] args)
        {
            Console.WriteLine("\n\n");
            DrawSegment(args);

            var calc = new WinCondition();
            bool skipFirst = true;
            foreach(string item in args)
            {
                if (skipFirst)
                {
                    skipFirst = false;
                    continue;
                }
                var nextLine = new string[args.Length];
                var winners = calc.CalculateWinnerArray(args, item);
                nextLine[0] = item;
                Array.Copy(winners, 0, nextLine, 1, winners.Length);
                DrawSegment(nextLine);
            }
        }
        
        private void DrawSegment(string[] args)
        {
            string column = " |";
            string resultStr = "";
            string spaces = "";
            
            foreach (string item in args)
            {
                spaces = "";
                for (int j = 0;j< (10 - item.Length);j++)
                {
                    spaces = spaces + " ";
                }
                resultStr = resultStr + spaces + item + column;
            }
            Console.WriteLine(resultStr);
            DrawLine(args);
        }

        private void DrawLine(string[] args)
        {
            string horisontal = "-----------+";
            string resultStr = "";
            for (int i = 0; i < args.Length; i++)
            {
                resultStr = resultStr + horisontal;
            }
            Console.WriteLine(resultStr);
        }
    }

    
}
