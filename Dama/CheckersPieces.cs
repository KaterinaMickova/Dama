using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dama
{
    public class CheckersPieces
    {
        public string symbol;
        public int[] position;
        public string tag;

        public CheckersPieces(string tag, int[] position)
        {
            string pieceId;

            if (tag == "hashtag")
            {
                pieceId = "#";
                Tag = "hashtag";
            }
            else
            {
                pieceId = "O";
                Tag = "zero";
            }
            this.Symbol = pieceId;
            this.Position = position;
        }

        public string Symbol
        {
            get;
            set;
        }

        public int[] Position
        {
            get;
            set;
        }

        public string Tag
        {
            get;
            set;
        }
    }
}

