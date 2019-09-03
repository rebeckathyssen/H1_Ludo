using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF1_OOP_Opgave1
{
    class Piece
    {
        public ConsoleColor PieceColor { get; set; }
        public string PieceId { get; set; }
        public int LocationRightNow { get; set; }
        public int StartingLocation { get; set; }
        

        public Piece(ConsoleColor color, string id, int startingLocation)
        {
            PieceColor = color;
            PieceId = id;
            StartingLocation = startingLocation;
            LocationRightNow = startingLocation;
        }

        public void RenderPiece()
        {
            Console.BackgroundColor = PieceColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(PieceId);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
