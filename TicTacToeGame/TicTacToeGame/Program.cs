using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come to TicTacToe");

            TicTacToe game=new TicTacToe();
            game.CreateBoard();
            
            Console.ReadLine();
        }
    }
}
