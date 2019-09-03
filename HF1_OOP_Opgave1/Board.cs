using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF1_OOP_Opgave1
{
    class Board
    {
        public Field[] BoardArray { get; set; }
        private Field Linebreak = new Field(ConsoleColor.Black, "");
        //Dictionary<string, Field> Dictionary { get; set; }
        //public int[] PossiblePositions { get; set; }
        //public Dictionary<int, Field> Dictionary { get; set; }



        public Board()
        {          
            //Inaktive felter
            Field inactiveGreen = new Field(ConsoleColor.Green, "      ");
            //Inaktivt gult felt
            Field inactiveYellow = new Field(ConsoleColor.Yellow, "      ");
            //Inaktivt rødt felt
            Field inactiveRed = new Field(ConsoleColor.Red, "      ");
            //Inaktivt blåt felt
            Field inactiveBlue = new Field(ConsoleColor.Blue, "      ");

            //Aktive felter
            Field blankGreen = new Field(ConsoleColor.Green, "[    ]");
            Field blankYellow = new Field(ConsoleColor.Yellow, "[    ]");
            Field blankRed = new Field(ConsoleColor.Red, "[    ]");
            Field blankBlue = new Field(ConsoleColor.Blue, "[    ]");
            Field blankWhite = new Field(ConsoleColor.White, "[    ]");

            //Stjerne
            Field starField = new Field(ConsoleColor.White, "[  ¤ ]");

            //Globus
            Field globeWhite = new Field(ConsoleColor.White, "[  @ ]");

            //Globusfelt med hver af spillernes farver
            Field globeGreen = new Field(ConsoleColor.Green, "[  @ ]");
            Field globeYellow = new Field(ConsoleColor.Yellow, "[  @ ]");
            Field globeRed = new Field(ConsoleColor.Red, "[  @ ]");
            Field globeBlue = new Field(ConsoleColor.Blue, "[  @ ]");

            //Vinderfelt
            Field winnerField = new Field(ConsoleColor.Cyan, "      ");

            //ARRAY SOM HOLDER HELE BRÆTTET UDEN BRIKKER
            BoardArray = new Field[182] {
            /*Felt 0 - 13*/
            inactiveGreen, inactiveGreen, inactiveGreen, inactiveGreen, inactiveGreen, blankWhite, starField, blankWhite,
            inactiveYellow, inactiveYellow, inactiveYellow, inactiveYellow, inactiveYellow, Linebreak, 
            /*Felt 14 - 27*/
             inactiveGreen, blankWhite, inactiveGreen, blankWhite, inactiveGreen, blankWhite, blankYellow, globeYellow,
            inactiveYellow, blankWhite, inactiveYellow, blankWhite, inactiveYellow, Linebreak, 
            /* Felt 28 - 41*/
            inactiveGreen, inactiveGreen, inactiveGreen, inactiveGreen, inactiveGreen, globeWhite, blankYellow, blankWhite,
            inactiveYellow, inactiveYellow, inactiveYellow, inactiveYellow, inactiveYellow, Linebreak, 
            /*Felt 42 - 55*/
            inactiveGreen, blankWhite, inactiveGreen, blankWhite, inactiveGreen, blankWhite, blankYellow, blankWhite,
            inactiveYellow, blankWhite, inactiveYellow, blankWhite, inactiveYellow, Linebreak, 
            /*Felt 56 - 69*/
            inactiveGreen, inactiveGreen, inactiveGreen, inactiveGreen, inactiveGreen, blankWhite, blankYellow, blankWhite,
            inactiveYellow, inactiveYellow, inactiveYellow, inactiveYellow, inactiveYellow, Linebreak, 
            /* Felt 70 - 83*/
            blankWhite, globeGreen, blankWhite, blankWhite, blankWhite, starField, blankYellow, starField, blankWhite,
            blankWhite, globeWhite, blankWhite, blankWhite, Linebreak, 
            /* Felt 84 - 97*/
            starField, blankGreen, blankGreen, blankGreen, blankGreen, blankGreen, winnerField, blankBlue, blankBlue,
            blankBlue, blankBlue, blankBlue, starField, Linebreak, 
            /* Felt 98 - 111*/
            blankWhite, blankWhite, globeWhite, blankWhite, blankWhite, starField, blankRed, starField, blankWhite,
            blankWhite, blankWhite, globeBlue, blankWhite, Linebreak, 
            /* Felt 112 - 125*/
            inactiveRed, inactiveRed, inactiveRed, inactiveRed, inactiveRed, blankWhite, blankRed, blankWhite, inactiveBlue, inactiveBlue,
            inactiveBlue, inactiveBlue, inactiveBlue, Linebreak, 
            /* Felt 126 - 139*/
            inactiveRed, blankWhite, inactiveRed, blankWhite, inactiveRed, blankWhite, inactiveRed, blankWhite, inactiveBlue, blankWhite,
            inactiveBlue, blankWhite, inactiveBlue, Linebreak, 
            /*Felt 140 - 153*/
            inactiveRed, inactiveRed, inactiveRed, inactiveRed, inactiveRed, blankWhite, blankRed, globeWhite, inactiveBlue, inactiveBlue,
            inactiveBlue, inactiveBlue, inactiveBlue, Linebreak, 
            /*Felt 154 - 167*/
            inactiveRed, blankWhite, inactiveRed, blankWhite, inactiveRed, globeRed, blankRed, blankWhite, inactiveBlue, blankWhite,
            inactiveBlue, blankWhite, inactiveBlue, Linebreak, 
             /*Felt 168 - 181*/
            inactiveRed, inactiveRed, inactiveRed, inactiveRed, inactiveRed, blankWhite, starField, blankWhite, inactiveBlue, inactiveBlue,
            inactiveBlue, inactiveBlue, inactiveBlue, Linebreak,
            };

            // Array med aktive felter
            /*PossiblePositions = new int[] { 70, 71, 72, 73, 74, 75, 61, 47, 33, 19, 5, 6, 7,
            21, 35, 49, 63, 77, 78, 79, 80, 81, 82, 96, 110, 109, 108, 107, 106, 105, 119, 133, 147, 161, 175, 174,
            173, 159, 145, 131, 117, 103, 102, 101, 100, 99, 98, 84};*/

            /*Dictionary = new Dictionary<int, Field>();

            Dictionary.Add(70, blankWhite);
            Dictionary.Add(71, globeGreen);
            Dictionary.Add(72, blankWhite);*/

            

        }

        

        /** Følgende metode har til formål at opstille selve brættet. Den tager et Player-array som parameter - i program er det i dette
         tilfælde vores 4 players, Rebecka, Jesper, etc. 
            Vi starter med at lave en variabel som kaldes index. Denne skal løbe arrayets index-numre igennem. For hver gang vi
            tjekker på ét index (altså ét felt i brættet), skal indexet på spillernes nuværende positioner sammenligne med
            dette index. Se beskrivelse nedenfor. Dette fordi vi ikke kan sammenligne et "Field" med en integer, og vi vil jo
            gerne finde ud af om der skal stå en brik på feltet eller ej.*/
        public void RenderBoard(Player[] allPlayers)
        {
            //For hvert felt
            for (int index = BoardArray.GetLowerBound(0); index <= BoardArray.GetUpperBound(0); index++)
            {
                //Find ud af om en spiller burde have en brik på feltet

                /** Vi henter alle spilleres brikkers placeringer. Hvis det aktive felts index er iblandt disse, skal der stå en brik.
                IndexOf returnerer indexet hvorpå den søgte værdi findes i arrayet. Hvis ikke det findes, returneres laveste index - 1 
                (svarende til false).
                Hvis feltets index findes i arrayet af spillernes aktive placeringer, er IndexOf altid over -1.
                Vi har et activePiece som er tomt. Hvis blot én spiller bør have en brik på et felt, sættes den pågældende brik til aktiv. 
                Herved ved vi efterfølgende at denne brik skal renderes, hvis ingen brikker er fundet, renderes feltet.*/
                Piece activePiece = null;
                foreach (Player player in allPlayers)
                {
                    if (Array.IndexOf(player.GetCurrentPositions(), index) > -1)
                    {
                        //Hvis spilleren har en brik på placeringen, hent denne, så den kan renderes senere.
                        activePiece = player.GetPieceByPosition(index);
                    }
                }
                if (activePiece != null)
                {
                    //Render den brik, der bør stå på feltet
                    activePiece.RenderPiece();
                }
                else
                {
                    //Render det aktive felt
                    Field field = BoardArray[index];
                    field.RenderField();
                    //Linebreak er sat som property, da vi ellers ikke vil kunne "nå" den fra denne metode.
                    if (field == Linebreak)
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }

       
    }
}
