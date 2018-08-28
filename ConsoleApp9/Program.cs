using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary4;
using static System.Console;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            bool Judge1 = true;
            int flush = 0;
            Card[] newCards = new Card[50];
            for ( int i = 0; i < 50; i++)
            {
                newCards[i] = myDeck.GetCard(i);
            }
            for(int hand = 0; hand < 10; hand++)
            {
                bool Judge = true;
                Judge1 = true;
                Suit  newSuit= newCards[hand * 5].suit;
                for(int i = 0; i < 5; i++)
                {
                    if(newSuit!=newCards[hand * 5 + i].suit)
                    {
                        Judge = false;
                        Judge1 = false;
                    }
                }
                if (Judge)
                {
                    flush = hand * 5;
                    break;
                }
            }
            if (Judge1)
            {
                WriteLine("flush");
                for(int card = 0; card < 5; card++)
                {
                    Write(newCards[flush + card].suit);
                    Write(newCards[flush + card].rank);
                    WriteLine();
                }
            }
            else
            {
                WriteLine("no flush");
            }
            Console.ReadKey();
        }
    }
}
