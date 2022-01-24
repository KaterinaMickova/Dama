using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dama
{
    public class Game
    {
        public Game()
        {
            ChessBoard board = new ChessBoard();
            board.GenerateCheckersPieces();
            board.DrawChessBoard();
            Console.WriteLine();
            do
            {
                Console.WriteLine("Napiš řádek, z kterého přesouváš tvoji figurku:");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("Napiš sloupec:");
                int column = int.Parse(Console.ReadLine());
                if (board.SelectCheckersPiece (row, column) != null)
                {
                    CheckersPieces checker = board.SelectCheckersPiece(row, column);
                    Console.WriteLine("Přesun na řádek: ");
                    int newRow = int.Parse(Console.ReadLine());
                    Console.WriteLine("Přesun na sloupec: ");
                    int newColumn = int.Parse(Console.ReadLine());
                    checker.Position = new int[] { newRow, newColumn };
                    board.DrawChessBoard();
                    Console.WriteLine(); 
                }
                else
                {
                    Console.WriteLine("Špatně zadaný, napiš správný řádek a sloupec");
                }
            }
            while (board.CheckForWin() != true);
        }
    }
}          
