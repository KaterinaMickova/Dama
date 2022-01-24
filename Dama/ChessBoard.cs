using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dama
{
    public class ChessBoard
    {
        public string[][] grid;
        public List<CheckersPieces> checkersPieces;
        public ChessBoard()
        {
            this.CheckersPiece = new List<CheckersPieces>();
            this.CreateChessBoard();
            return;
        }
        public string[][] Grid
        {
            get;
            set;
        }
        public List<CheckersPieces> CheckersPiece
        {
            get;
            set;
        }
        public void CreateChessBoard()
        {
            this.Grid = new string[][]
            {
          new string[] {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
          new string[] {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
          new string[] {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
          new string[] {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
          new string[] {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
          new string[] {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
          new string[] {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
          new string[] {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
          new string[] {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
          new string[] {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "},
            };
            return;
        }
        public void GenerateCheckersPieces()
        {
            int[][] hashtagPositions = new int[][]
           {
          new int[] { 0, 1 }, new int[] { 0, 3 }, new int[] { 0,  5 }, new int[] { 0, 7 }, new int[] { 0, 9 },
          new int[] { 1, 0 }, new int[] { 1, 2 }, new int[] { 1,  4 }, new int[] { 1,  6 },new int[]{ 1,  8 },
          new int[] { 2, 1 }, new int [] { 2, 3 }, new int[] { 2,  5 }, new int[] { 2, 7}, new int[] { 2, 9}
           };
            int[][] zeroPositions = new int[][]
            {
          new int[] { 7, 0 }, new int[] { 7, 2 }, new int[] { 7, 4 }, new int[] { 7, 6 },new int[] { 7, 8 },
          new int[] { 8, 1 }, new int[] { 8, 3 }, new int[] { 8, 5 }, new int[] { 8, 7 },new int[]{ 8,  9 },
          new int[] { 9, 0 }, new int[] { 9, 2 }, new int [] { 9, 4 }, new int[] { 9, 6 }, new int[] { 9, 8}
            };
            for (int i = 0; i < 15; i++)
            {
                CheckersPieces hashtag = new CheckersPieces ("hashtag", hashtagPositions[i]);
                CheckersPieces zero = new CheckersPieces("black", zeroPositions[i]);
                CheckersPiece.Add(hashtag);
                CheckersPiece.Add(zero);
            }
            return;
        }
        public void PlaceCheckersPieces()
        {
            foreach (var checker in CheckersPiece)
            {
                this.Grid[checker.Position[0]][checker.Position[1]] = checker.Symbol;
            }
            return;
        }
        public void DrawChessBoard()
        {
            CreateChessBoard();
            PlaceCheckersPieces();
            Console.WriteLine("  0  1  2  3  4  5  6  7  8  9 ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " " + String.Join("  ", this.Grid[i]));
            }
            return;
        }
        public CheckersPieces SelectCheckersPiece(int row, int column)
        {
            return CheckersPiece.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }
        public void RemoveCheckersPiece(CheckersPieces checker)
        {
            CheckersPiece.Remove(checker);
            return;
        }
        public bool CheckForWin()
        {
            return CheckersPiece.All(x => x.Tag == "hashtag") || !CheckersPiece.Exists(x => x.Tag == "hashtag");
        }
    }
}
