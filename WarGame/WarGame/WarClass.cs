  using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WarGame
{
    class WarClass
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public List<card> Deck { get; set; }

        public WarClass()
        {
      
            //Dictionary<string, int> Deck = new Dictionary<string, int>();
            List<card> deck = new List<card>();

            deck.Add(new card(){
              suit=  Suit.Spades,
                num = Number.Ace
            });
            deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ace
            });
            ////Spades
            //deck.Add("A♠", 14);
            //Deck.Add("K♠", 13);
            //Deck.Add("Q♠", 12);
            //Deck.Add("J♠", 11);
            //Deck.Add("10♠", 10);
            //Deck.Add("9♠", 9);
            //Deck.Add("8♠", 8);
            //Deck.Add("7♠", 7);
            //Deck.Add("6♠", 6);
            //Deck.Add("5♠", 5);
            //Deck.Add("4♠", 4);
            //Deck.Add("3♠", 3);
            //Deck.Add("2♠", 2);

            ////Clubs
            //Deck.Add("A♣", 14);
            //Deck.Add("K♣", 13);
            //Deck.Add("Q♣", 12);
            //Deck.Add("J♣", 11);
            //Deck.Add("10♣", 10);
            //Deck.Add("9♣", 9);
            //Deck.Add("8♣", 8);
            //Deck.Add("7♣", 7);
            //Deck.Add("6♣", 6);
            //Deck.Add("5♣", 5);
            //Deck.Add("4♣", 4);
            //Deck.Add("3♣", 3);
            //Deck.Add("2♣", 2);


            ////Hearts
            //Deck.Add("A♥", 14);
            //Deck.Add("K♥", 13);
            //Deck.Add("Q♥", 12);
            //Deck.Add("J♥", 11);
            //Deck.Add("10♥", 10);
            //Deck.Add("9♥", 9);
            //Deck.Add("8♥", 8);
            //Deck.Add("7♥", 7);
            //Deck.Add("6♥", 6);
            //Deck.Add("5♥", 5);
            //Deck.Add("4♥", 4);
            //Deck.Add("3♥", 3);
            //Deck.Add("2♥", 2);

            ////Diamonds
            //Deck.Add("A♦", 14);
            //Deck.Add("K♦", 13);
            //Deck.Add("Q♦", 12);
            //Deck.Add("J♦", 11);
            //Deck.Add("10♦", 10);
            //Deck.Add("9♦", 9);
            //Deck.Add("8♦", 8);
            //Deck.Add("7♦", 7);
            //Deck.Add("6♦", 6);
            //Deck.Add("5♦", 5);
            //Deck.Add("4♦", 4);
            //Deck.Add("3♦", 3);
            //Deck.Add("2♦", 2);
        }

        /// <summary>
        /// This will shuffle the cards once the person clicks new game by randomizing the order of cards and storing it to a new deck
        /// </summary>
        /// <param name="cardsShuffle"></param>
        /// <returns>Shuffled set of cards</returns>
        public Dictionary<string, int> ShuffledDeck(Dictionary<string,int> cardsShuffle)
        {
            //Dictionary<string, int> ShuffledDeck = new Dictionary<string, int>(cardsShuffle);
            List<card> ShuffleDeck = new List<card>();
            Random Shuffle = new Random();
            for (int i = 0; i < 53; i++)
            {
                 int selection = Shuffle.Next(1, 53);
                ShuffleDeck = Deck.OrderBy(X => Shuffle.Next).ToList();
            }
          
                
                return string.Empty;
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
        Ace,
        King,
        Queen,
        Jack,
        Ten,
        Nine,
        Eight,
        Seven,
        Six,
        Five, 
        Four,
        Three,
        Two
    }

}
