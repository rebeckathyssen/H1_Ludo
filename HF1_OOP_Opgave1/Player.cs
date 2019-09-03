using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF1_OOP_Opgave1
{
    //Hvad identificerer en spiller?
    //Navn og farve
    class Player
    {
        /** Det følgende objekt er opbygningen af en player. Denne tager 4 parametre: Navn, en farve, 4 startpositioner
         til brikkerne i hvert hjørne, samt en int som angiver det første aktive felt på pladen. */
        public string Name { get; set; }
        public ConsoleColor Color { get; set; }
        public Piece[] Pieces { get; set; }
        public int FirstActiveField { get; set; }
        
        //public int NextActiveField { get; set; }


        public Player(string name, ConsoleColor color, int[] startingPositions, int firstActiveField)
        {
            /** De elementer som kaldes her, er dem som altid bliver kaldt, når der oprettes en ny Player. Pieces
             * er et array der opbygges på baggrund af metoden "buildPieces", som tager de indtastede startpositioner fra 
             parametrene. buildPieces laver således et array med 4 brikker, giver dem hver deres id og hver deres start-
            position. */
            Name = name;
            Color = color;
            FirstActiveField = firstActiveField;
            Pieces = BuildPieces(startingPositions);
            //NextActiveField = GetNextActiveField(dieResult);
        }

        //Privat metode, da det kun er objektet selv, der skal manipulere Pieces arrayet for en spiller
        private Piece[] BuildPieces(int[] startingPositions)
        {
            Piece piece1 = new Piece(Color, "   1  ", startingPositions[0]);
            Piece piece2 = new Piece(Color, "   2  ", startingPositions[1]);
            Piece piece3 = new Piece(Color, "   3  ", startingPositions[2]);
            Piece piece4 = new Piece(Color, "   4  ", startingPositions[3]);

            return new Piece[4] { piece1, piece2, piece3, piece4 };
        }

        //Vi vil gerne have et array af brikker, der ikke kræver en globus at flytte
        public List<Piece> GetPiecesOutsideStartPosition()
        {
            List<Piece> pieces = new List<Piece>();
            foreach (Piece piece in Pieces)
            {
                //Hvis brikken er udenfor startplaceringen, tilføj den til listen over mulige brikker, der let kan flyttes.
                if (piece.LocationRightNow != piece.StartingLocation)
                    pieces.Add(piece);
                
            }
            return pieces;
        }

        public int[] GetCurrentPositions()
        {
            int[] positions = new int[4];
            for (int i = 0; i < 4; i++)
            {
                positions[i] = Pieces[i].LocationRightNow; //LocationRightNow står fra start til at være StartingLocation
            }
            return positions;
        }

        /** Hvis brikkens nuværende lokation er lig med position (som er indexet på brættet), så returner piece, ellers
            returner null */
        public Piece GetPieceByPosition(int position)
        {
            foreach (Piece piece in Pieces)
            {
                if (piece.LocationRightNow == position)
                {
                    return piece;
                }
            }
            return null;
        }

        
        /*public int GetNextActiveField(string dieResult, int startPosition, firstactivefield)
        {          
            if (dieResult == "globus")
            {
                Board board = new Board();
                //Find den næste globus på brættet:
                //Led efter index 71, 33, 21, 80, 109, 147, 100 i arrayet over muligefelter
                //Hvilket felt står du på nu - og hvilket felt i arrayet kommer efter?

                //Udskriv det index du står på LIGE NU. Hold det op 

                //Slå op i ordbogen, hvilket index(int) den globus hører til

                Console.WriteLine(board.PossiblePositions[1]);

                
            }

            //Returner den int
            return 1;


        }*/
    }
}
