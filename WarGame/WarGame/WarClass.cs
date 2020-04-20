  using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using WarGame;

namespace WarGame
{
    class WarClass
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public List<card> Deck { get; set; }

        public WarClass()
        {
            Deck = new List<card>
            {

                //Spades
                new card()
                {
                    suit = Suit.Spades,
                    num = Number.Ace
                },
                new card()
                {
                    suit = Suit.Spades,
                    num = Number.King
                },
                new card()
                {
                    suit = Suit.Spades,
                    num = Number.Queen
                },
                new card()
                {
                    suit = Suit.Spades,
                    num = Number.Jack
                },
                new card()
                {
                    suit = Suit.Spades,
                    num = Number.Ten
                },
                new card()
                {
                    suit = Suit.Spades,
                    num = Number.Nine
                },
                new card()
                {
                    suit = Suit.Spades,
                    num = Number.Eight
                },
                new card()
                {
                    suit = Suit.Spades,
                    num = Number.Seven
                },
                new card()
                {
                    suit = Suit.Spades,
                    num = Number.Six
                },
                new card()
                {
                    suit = Suit.Spades,
                    num = Number.Five
                },
                new card()
                {
                    suit = Suit.Spades,
                    num = Number.Four
                },
                new card()
                {
                    suit = Suit.Spades,
                    num = Number.Three
                },
                new card()
                {
                    suit = Suit.Spades,
                    num = Number.Two
                },

                //Clubs
                new card()
                {
                    suit = Suit.Clubs,
                    num = Number.Ace
                },
                new card()
                {
                    suit = Suit.Clubs,
                    num = Number.King
                },
                new card()
                {
                    suit = Suit.Clubs,
                    num = Number.Queen
                },
                new card()
                {
                    suit = Suit.Clubs,
                    num = Number.Jack
                },
                new card()
                {
                    suit = Suit.Clubs,
                    num = Number.Ten
                },
                new card()
                {
                    suit = Suit.Clubs,
                    num = Number.Nine
                },
                new card()
                {
                    suit = Suit.Clubs,
                    num = Number.Eight
                },
                new card()
                {
                    suit = Suit.Clubs,
                    num = Number.Seven
                },
                new card()
                {
                    suit = Suit.Clubs,
                    num = Number.Six
                },
                new card()
                {
                    suit = Suit.Clubs,
                    num = Number.Five
                },
                new card()
                {
                    suit = Suit.Clubs,
                    num = Number.Four
                },
                new card()
                {
                    suit = Suit.Clubs,
                    num = Number.Three
                },
                new card()
                {
                    suit = Suit.Clubs,
                    num = Number.Two
                },

                //Diamonds
                new card()
                {
                    suit = Suit.Diamonds,
                    num = Number.Ace
                },
                new card()
                {
                    suit = Suit.Diamonds,
                    num = Number.King
                },
                new card()
                {
                    suit = Suit.Diamonds,
                    num = Number.Queen
                },
                new card()
                {
                    suit = Suit.Diamonds,
                    num = Number.Jack
                },
                new card()
                {
                    suit = Suit.Diamonds,
                    num = Number.Ten
                },
                new card()
                {
                    suit = Suit.Diamonds,
                    num = Number.Nine
                },
                new card()
                {
                    suit = Suit.Diamonds,
                    num = Number.Eight
                },
                new card()
                {
                    suit = Suit.Diamonds,
                    num = Number.Seven
                },
                new card()
                {
                    suit = Suit.Diamonds,
                    num = Number.Six
                },
                new card()
                {
                    suit = Suit.Diamonds,
                    num = Number.Five
                },
                new card()
                {
                    suit = Suit.Diamonds,
                    num = Number.Four
                },
                new card()
                {
                    suit = Suit.Diamonds,
                    num = Number.Three
                },
                new card()
                {
                    suit = Suit.Diamonds,
                    num = Number.Two
                },

                //hearts
                new card()
                {
                    suit = Suit.Hearts,
                    num = Number.Ace
                },
                new card()
                {
                    suit = Suit.Hearts,
                    num = Number.King
                },
                new card()
                {
                    suit = Suit.Hearts,
                    num = Number.Queen
                },
                new card()
                {
                    suit = Suit.Hearts,
                    num = Number.Jack
                },
                new card()
                {
                    suit = Suit.Hearts,
                    num = Number.Ten
                },
                new card()
                {
                    suit = Suit.Hearts,
                    num = Number.Nine
                },
                new card()
                {
                    suit = Suit.Hearts,
                    num = Number.Eight
                },
                new card()
                {
                    suit = Suit.Hearts,
                    num = Number.Seven
                },
                new card()
                {
                    suit = Suit.Hearts,
                    num = Number.Six
                },
                new card()
                {
                    suit = Suit.Hearts,
                    num = Number.Five
                },
                new card()
                {
                    suit = Suit.Hearts,
                    num = Number.Four
                },
                new card()
                {
                    suit = Suit.Hearts,
                    num = Number.Three
                },
                new card()
                {
                    suit = Suit.Hearts,
                    num = Number.Two
                }
            };

        }
        public string Convert(string card)
        {
            string cardName = string.Empty;
            int cardValue = 0;
            card c = new card();


            //Spades
            if (card == "Ace of Spades")
            {
                cardName = "A♠";
                cardValue = 14;
            }
            else if (card == "King of Spades")
            {
                cardName = "K♠";
                cardValue = 13;
            }
            else if (card == "Queen of Spades")
            {
                cardName = "Q♠";
                cardValue = 12;
            }
            else if (card == "Jack of Spades")
            {
                cardName = "J♠";
                cardValue = 11;
            }
            else if (card == "Ten of Spades")
            {
                cardName = "10♠";
                cardValue = 10;
            }
            else if (card == "Nine of Spades")
            {
                cardName = "9♠";
                cardValue = 9;
            }
            else if (card == "Eight of Spades")
            {
                cardName = "8♠";
                cardValue = 8;
            }
            else if (card == "Seven of Spades")
            {
                cardName = "7♠";
                cardValue = 7;
            }
            else if (card == "Six of Spades")
            {
                cardName = "6♠";
                cardValue = 6;
            }
            else if (card == "Five of Spades")
            {
                cardName = "5♠";
                cardValue = 5;
            }
            else if (card == "Four of Spades")
            {
                cardName = "4♠";
                cardValue = 4;
            }
            else if (card == "Three of Spades")
            {
                cardName = "3♠";
                cardValue = 3;
            }
            else if (card == "Two of Spades")
            {
                cardName = "2♠";
                cardValue = 2;
            }

            //Clubs
            else if (card == "Ace of Clubs")
            {
                cardName = "A♣";
                cardValue = 14;
            }
            else if (card == "King of Clubs")
            {
                cardName = "K♣";
                cardValue = 13;
            }
            else if (card == "Queen of Clubs")
            {
                cardName = "Q♣";
                cardValue = 12;
            }

            else if (card == "Jack of Clubs")
            {
                cardName = "J♣";
                cardValue = 11;
            }

            else if (card == "Ten of Clubs")
            {
                cardName = "10♣";
                cardValue = 10;
            }

            else if (card == "Nine of Clubs")
            {
                cardName = "9♣";
                cardValue = 9;
            }

            else if (card == "Eight of Clubs")
            {
                cardName = "8♣";
                cardValue = 8;
            }

            else if (card == "Seven of Clubs")
            {
                cardName = "7♣";
                cardValue = 7;
            }

            else if (card == "Six of Clubs")
            {
                cardName = "6♣";
                cardValue = 6;
            }

            else if (card == "Five of Clubs")
            {
                cardName = "5♣";
                cardValue = 5;
            }

            else if (card == "Four of Clubs")
            {
                cardName = "4♣";
                cardValue = 4;
            }

            else if (card == "Three of Clubs")
            {
                cardName = "3♣";
                cardValue = 3;
            }

            else if (card == "Two of Clubs")
            {
                cardName = "2♣";
                cardValue = 2;
            }

            //Hearts
            else if (card == "Ace of Hearts")
            {
                cardName = "A♥";
                cardValue = 14;
            }
            else if (card == "King of Hearts")
            {
                cardName = "K♥";
                cardValue = 13;
            }
            else if (card == "Queen of Hearts")
            {
                cardName = "Q♥";
                cardValue = 12;
            }
            else if (card == "Jack of Hearts")
            {
                cardName = "J♥";
                cardValue = 11;
            }
            else if (card == "Ten of Hearts")
            {
                cardName = "10♥";
                cardValue = 10;
            }
            else if (card == "Nine of Hearts")
            {
                cardName = "9♥";
                cardValue = 9;
            }
            else if (card == "Eight of Hearts")
            {
                cardName = "8♥";
                cardValue = 8;
            }
            else if (card == "Seven of Hearts")
            {
                cardName = "7♥";
                cardValue = 7;
            }
            else if (card == "Six of Hearts")
            {
                cardName = "6♥";
                cardValue = 6;
            }
            else if (card == "Five of Hearts")
            {
                cardName = "5♥";
                cardValue = 5;
            }
            else if (card == "Four of Hearts")
            {
                cardName = "4♥";
                cardValue = 4;
            }
            else if (card == "Three of Hearts")
            {
                cardName = "3♥";
                cardValue = 3;
            }
            else if (card == "Two of Hearts")
            {
                cardName = "2♥";
                cardValue = 2;
            }

            //Diamonds
            else if (card == "Ace of Diamonds")
            {
                cardName = "A♦";
                cardValue = 14;
            }
            else if (card == "King of Diamonds")
            {
                cardName = "K♦";
                cardValue = 13;
            }
            else if (card == "Queen of Diamonds")
            {
                cardName = "Q♦";
                cardValue = 12;
            }
            else if (card == "Jack of Diamonds")
            {
                cardName = "J♦";
                cardValue = 11;
            }
            else if (card == "Ten of Diamonds")
            {
                cardName = "10♦";
                cardValue = 10;
            }
            else if (card == "Nine of Diamonds")
            {
                cardName = "9♦";
                cardValue = 9;
            }
            else if (card == "Eight of Diamonds")
            {
                cardName = "8♦";
                cardValue = 8;
            }
            else if (card == "Seven of Diamonds")
            {
                cardName = "7♦";
                cardValue = 7;
            }
            else if (card == "Six of Diamonds")
            {
                cardName = "6♦";
                cardValue = 6;
            }
            else if (card == "Five of Diamonds")
            {
                cardName = "5♦";
                cardValue = 5;
            }
            else if (card == "Four of Diamonds")
            {
                cardName = "4♦";
                cardValue = 4;
            }
            else if (card == "Three of Diamonds")
            {
                cardName = "3♦";
                cardValue = 3;
            }
            else if (card == "Two of Diamonds")
            {
                cardName = "2♦";
                cardValue = 2;
            }



            return $"{cardName}";
        }
        public int ConvertNum(string card)
        {
            string cardName = string.Empty;
            int cardValue = 0;
            card c = new card();


            //Spades
            if (card == "Ace of Spades")
            {
                cardName = "A♠";
                cardValue = 14;
            }
            else if (card == "King of Spades")
            {
                cardName = "K♠";
                cardValue = 13;
            }
            else if (card == "Queen of Spades")
            {
                cardName = "Q♠";
                cardValue = 12;
            }
            else if (card == "Jack of Spades")
            {
                cardName = "J♠";
                cardValue = 11;
            }
            else if (card == "Ten of Spades")
            {
                cardName = "10♠";
                cardValue = 10;
            }
            else if (card == "Nine of Spades")
            {
                cardName = "9♠";
                cardValue = 9;
            }
            else if (card == "Eight of Spades")
            {
                cardName = "8♠";
                cardValue = 8;
            }
            else if (card == "Seven of Spades")
            {
                cardName = "7♠";
                cardValue = 7;
            }
            else if (card == "Six of Spades")
            {
                cardName = "6♠";
                cardValue = 6;
            }
            else if (card == "Five of Spades")
            {
                cardName = "5♠";
                cardValue = 5;
            }
            else if (card == "Four of Spades")
            {
                cardName = "4♠";
                cardValue = 4;
            }
            else if (card == "Three of Spades")
            {
                cardName = "3♠";
                cardValue = 3;
            }
            else if (card == "Two of Spades")
            {
                cardName = "2♠";
                cardValue = 2;
            }

            //Clubs
            else if (card == "Ace of Clubs")
            {
                cardName = "A♣";
                cardValue = 14;
            }
            else if (card == "King of Clubs")
            {
                cardName = "K♣";
                cardValue = 13;
            }
            else if (card == "Queen of Clubs")
            {
                cardName = "Q♣";
                cardValue = 12;
            }

            else if (card == "Jack of Clubs")
            {
                cardName = "J♣";
                cardValue = 11;
            }

            else if (card == "Ten of Clubs")
            {
                cardName = "10♣";
                cardValue = 10;
            }

            else if (card == "Nine of Clubs")
            {
                cardName = "9♣";
                cardValue = 9;
            }

            else if (card == "Eight of Clubs")
            {
                cardName = "8♣";
                cardValue = 8;
            }

            else if (card == "Seven of Clubs")
            {
                cardName = "7♣";
                cardValue = 7;
            }

            else if (card == "Six of Clubs")
            {
                cardName = "6♣";
                cardValue = 6;
            }

            else if (card == "Five of Clubs")
            {
                cardName = "5♣";
                cardValue = 5;
            }

            else if (card == "Four of Clubs")
            {
                cardName = "4♣";
                cardValue = 4;
            }

            else if (card == "Three of Clubs")
            {
                cardName = "3♣";
                cardValue = 3;
            }

            else if (card == "Two of Clubs")
            {
                cardName = "2♣";
                cardValue = 2;
            }

            //Hearts
            else if (card == "Ace of Hearts")
            {
                cardName = "A♥";
                cardValue = 14;
            }
            else if (card == "King of Hearts")
            {
                cardName = "K♥";
                cardValue = 13;
            }
            else if (card == "Queen of Hearts")
            {
                cardName = "Q♥";
                cardValue = 12;
            }
            else if (card == "Jack of Hearts")
            {
                cardName = "J♥";
                cardValue = 11;
            }
            else if (card == "Ten of Hearts")
            {
                cardName = "10♥";
                cardValue = 10;
            }
            else if (card == "Nine of Hearts")
            {
                cardName = "9♥";
                cardValue = 9;
            }
            else if (card == "Eight of Hearts")
            {
                cardName = "8♥";
                cardValue = 8;
            }
            else if (card == "Seven of Hearts")
            {
                cardName = "7♥";
                cardValue = 7;
            }
            else if (card == "Six of Hearts")
            {
                cardName = "6♥";
                cardValue = 6;
            }
            else if (card == "Five of Hearts")
            {
                cardName = "5♥";
                cardValue = 5;
            }
            else if (card == "Four of Hearts")
            {
                cardName = "4♥";
                cardValue = 4;
            }
            else if (card == "Three of Hearts")
            {
                cardName = "3♥";
                cardValue = 3;
            }
            else if (card == "Two of Hearts")
            {
                cardName = "2♥";
                cardValue = 2;
            }

            //Diamonds
            else if (card == "Ace of Diamonds")
            {
                cardName = "A♦";
                cardValue = 14;
            }
            else if (card == "King of Diamonds")
            {
                cardName = "K♦";
                cardValue = 13;
            }
            else if (card == "Queen of Diamonds")
            {
                cardName = "Q♦";
                cardValue = 12;
            }
            else if (card == "Jack of Diamonds")
            {
                cardName = "J♦";
                cardValue = 11;
            }
            else if (card == "Ten of Diamonds")
            {
                cardName = "10♦";
                cardValue = 10;
            }
            else if (card == "Nine of Diamonds")
            {
                cardName = "9♦";
                cardValue = 9;
            }
            else if (card == "Eight of Diamonds")
            {
                cardName = "8♦";
                cardValue = 8;
            }
            else if (card == "Seven of Diamonds")
            {
                cardName = "7♦";
                cardValue = 7;
            }
            else if (card == "Six of Diamonds")
            {
                cardName = "6♦";
                cardValue = 6;
            }
            else if (card == "Five of Diamonds")
            {
                cardName = "5♦";
                cardValue = 5;
            }
            else if (card == "Four of Diamonds")
            {
                cardName = "4♦";
                cardValue = 4;
            }
            else if (card == "Three of Diamonds")
            {
                cardName = "3♦";
                cardValue = 3;
            }
            else if (card == "Two of Diamonds")
            {
                cardName = "2♦";
                cardValue = 2;
            }



            return cardValue;
        }
    }

    public class card
    {
        public Suit suit { get; set; }
        public Number num { get; set; }


        public bool Greater(card C)
        {
            bool result = true;
            if (num > C.num)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }
    public enum Number
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace,
    }

    
}
public class PG
{
    public List<string> Player1 { get; set; }
    public List<string> Player2 { get; set; }


    public PG()
    {
        Player1 = new List<string>();
        Player2 = new List<string>();
    }
}


