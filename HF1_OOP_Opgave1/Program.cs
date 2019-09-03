using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace HF1_OOP_Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            /** Det følgende Ludo-spil er baseret på GlobusLudo, hvor stjerne og globus indgår i spillet. Indtil videre er der kun
             * mulighed for at spille 4 spillere.*/

            while (true)
            {
                /** Først ønsker vi at starte et nyt spil. Det gør vi ved at kalde en ny instans af objektet Board. 
                 I Board's constructor forefindes alle spillets felter, samt et array over de steder, hvor det er muligt at sætte
                en brik. */
                Board nytSpil = new Board();

                /** Herefter ønsker vi at opstille de 4 spillere. Vi laver et array med de 4 spillere, hvor vi i det array
                 * kalder 4 nye instanser af objektet Player. Player tager 4 parametre: Et navn, en farve, positionerne for
                 de hjørner hvor brikkerne skal starte, samt en startposition for hvor brikken skal starte på pladen, når en
                globus slås.*/
                Player[] players =
                {
                    new Player("Rebecka", ConsoleColor.DarkGreen, new int[]{15,17,43,45}, 71),
                    new Player("Jesper", ConsoleColor.DarkYellow, new int[]{23,25,51,53}, 21),
                    new Player("Ella", ConsoleColor.DarkRed, new int[]{127,129,155,157}, 159),
                    new Player("Mikkel", ConsoleColor.DarkBlue, new int[]{135,137,163,165}, 109)
                };

                /** I vores Board-objekt ligger en metode, RenderBoard, som tager arrayet med spillere som parameter. På denne måde
                 * kan vi kalde brættet og sætte alle spilleres brikker på de rigtige placeringer.*/
                nytSpil.RenderBoard(players);

                /** Spillogik: 
                 ......*/
                foreach (Player player in players)
                {
                    Console.WriteLine(player.Name + "s tur!");

                    //Rul en terning
                    Console.WriteLine("Tryk på en knap for at kaste med terningen!");
                    Console.ReadLine();
                    Die firstThrow = new Die();
                    //string result = firstThrow.ThrowDie();
                    string dieResult = "globus";
                    Console.WriteLine("Du slog en " + dieResult + "!");                  



                    while (dieResult == "globus")
                    {
                        List<Piece> piecesOutsideStart = player.GetPiecesOutsideStartPosition();
                        //Laver en liste over brikker som er aktive på brættet.

                        //Har spilleren brikker udenfor start / aktive brikker på brættet?
                        if (piecesOutsideStart.Count > 0)
                        {
                            //Hvis ja, giv spilleren mulighed for at vælge alle brikker
                            Console.WriteLine("Du kan rykke med " + piecesOutsideStart.Count + " brik(ker).\n" +
                                "Hvilken vil du rykke med?");
                            int pickAPiece = int.Parse(Console.ReadLine());
                            //switch mellem aktive brikker

                            switch (pickAPiece)
                            {
                                case 1:
                                    Console.WriteLine("Du rykker med brik 1");
                                    
                                    //player.Pieces[0].LocationRightNow = player.GetNextActiveField(dieResult);
                                    // ^ player.FirstActiveField skal ændres til indexet på første globus i arrayet med aktive felter
                                    break;

                                case 2:
                                    //ryk 2 hen til globus
                                    break;

                                case 3:
                                    //ryk 3 hen til globus
                                    break;

                                case 4:
                                    //ryk 4 hen til globus
                                    break;

                                default:
                                    Console.WriteLine("Hov, du har ingen brikker at rykke med..");
                                    break;
                            }
                            
                            //Slå igen
                        }
                        else
                        {
                            //Hvis nej, ryk en brik ud fra start
                            Console.WriteLine("Flytter brik");
                            player.Pieces[0].LocationRightNow = player.FirstActiveField;
                            //Print nyt bræt ud
                            nytSpil.RenderBoard(players);
                            //Slå igen
                            Die throwAgain = new Die();
                            //dieResult = throwAgain.ThrowDie();
                            dieResult = "globus";
                            Console.WriteLine("Du må slå igen! Tryk på en knap for at kaste med terningen..");
                            Console.ReadLine();
                            Console.WriteLine("Du slog en " + dieResult + "!");
                        }
                    }


                    //Sålænge der ikke er brikker på brættet og det ikke er en globus, kast tre gange.
                    //Har spilleren brikker der er aktive / kan de flyttes?





                }
                //Afvent terningerul
                //Hvis ingen brikker på brættet, skal terning vise globus, kast med terningen max. 3 gange
                //Hvis mere end 1 brik på brættet, lad brugeren vælge brik
                //Flyt den aktive brik
                //Hvis en anden brik optager feltet, nulstil denne brik.
            }
        }

        /** Følgende metode er opbygningen af én tur. 
         Først skal der kastes en terning, som er af objektet Die. Denne er opbygget af et array med strings, som indeholder
            de forskellige sider i terningen. 
            Når terningen er kastet skal vi tjekke på om spilleren overhovedet har nogle brikker udenfor start-området, som
            man kan rykke med. Vi laver en ny variabel - en liste som vi kalder piecesOutSideStart. Denne sætter vi til at 
            være lig med en metode, som hedder getPiecesOutsideStartPosition. Denne metode tjekker om brikkernes nuværende
            position IKKE er lig med de 4 for hvert starthjørne - for hvis de ikke matcher, så er brikkerne på pladen og til
            at rykke med. Derpå ved man om der skal rykkes med en brik eller om man skal kaste igen. */
        public static void takeTurn(Board board, Player player)
        {
            
            


            
            /*else if (result == "stjerne")
            {
                //Har spilleren brikker udenfor start?
                if (piecesOutsideStart.Count > 0)
                {
                    //Hvis ja, giv spilleren mulighed for at vælge de brikker, der er udenfor start
                }
                else
                {
                    //Hvis nej, gå videre til næste kast eller næste tur.
                }
            }
            else
            {
                //Har spilleren brikker udenfor start?
                if (piecesOutsideStart.Count > 0)
                {
                    //Hvis ja, giv spilleren mulighed for at vælge de brikker, der er udenfor start
                }
                else
                {
                    //Hvis nej, gå videre til næste kast eller næste tur.
                }
            }*/
        }
    }
}
