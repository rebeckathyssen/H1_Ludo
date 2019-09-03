using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF1_OOP_Opgave1
{
    class Field
    {
        /** Denne class har til formål at fremstille et felt. Feltet tager 2 parametre: En baggrundsfarve og et symbol.
         Baggrundsfarve tages som parameter, fordi baggrundsfarven på felterne varierer, hvorimod tekstfarven altid
            vil være den samme. Symbolet skal visualisere om vi har med et blankt felt, en stjerne eller en globus at gøre.*/

        public ConsoleColor Color { get; set; }
        public string Symbol { get; set; }

        public Field(ConsoleColor color, string symbol)
        {
            Color = color;
            Symbol = symbol;
        }

        public void RenderField()
        {
            Console.BackgroundColor = Color;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(Symbol);            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
