using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class WinCondition
    {
        public string[] CalculateWinnerArray(string[] args, string userMove)
        {
            var copiedArray = new string[args.Length-1];
            Array.Copy(args, 1, copiedArray, 0, args.Length-1);

            int moveIndexInArr = Array.IndexOf(copiedArray, userMove);

            bool needShift = false;
            if ((moveIndexInArr + (copiedArray.Length - 1) / 2) > copiedArray.Length)
                needShift = true;
            int startShift = (moveIndexInArr + (copiedArray.Length-1)/2)% copiedArray.Length;

            if (needShift)
            {
                for (int i = moveIndexInArr; i < copiedArray.Length; i++)
                {
                    copiedArray[i] = userMove;
                }

                for (int i = 0; i <= startShift; i++)
                {
                    copiedArray[i] = userMove;
                }
            }
            else
            {
                for (int i = moveIndexInArr; i <= startShift; i++)
                {
                    copiedArray[i] = userMove;
                }
            }
            copiedArray[moveIndexInArr] = "Draw";
            return copiedArray;
        }
    }
}
