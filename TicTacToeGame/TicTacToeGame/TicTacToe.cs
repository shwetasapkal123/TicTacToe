using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class TicTacToe
    {
        public char[] CreateBoard()
        {
            char[] board = new char[10];
            for(int i=1;i<board.Length;i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        public char ChooseLetter()
        {
            Console.WriteLine("Choose either X or O");
            char playerLetter = Convert.ToChar(Console.ReadLine());
            char computerLetter;
            if (playerLetter == 'X' || playerLetter =='O')
            {
                if(playerLetter =='X')
                {
                    computerLetter = 'O';
                }
                else if(playerLetter =='O')
                {
                    computerLetter = 'X';
                }
            }
            else
            {
                Console.WriteLine("Please choose either X or O");
                ChooseLetter();
            }
            return playerLetter;
        }
    }
}
