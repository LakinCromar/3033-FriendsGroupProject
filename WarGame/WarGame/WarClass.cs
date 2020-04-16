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

            //Spades
            deck.Add(new card(){
                suit=  Suit.Spades,
                num = Number.Ace});
            deck.Add(new card()
            {suit = Suit.Spades,
                num = Number.King
            }); 
            deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Queen
            }); 
            deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Jack
            }); 
            deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Ten
            }); 
            deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Nine
            }); 
            deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Eight
            }); 
            deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Seven
            }); 
            deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Six
            }); 
            deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Five}); 
            deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Four
            }); 
            deck.Add(new card()
            {
                suit = Suit.Spades,
                num = Number.Three
            }); 
            deck.Add(new card()
            {suit = Suit.Spades,
             num = Number.Two
            }); 

            //Clubs
            deck.Add(new card()
            {
                suit = Suit.Clubs,
                num = Number.Ace
            }); deck.Add(new card()
            {
                suit = Suit.Clubs,
                num = Number.King
            }); 
            deck.Add(new card()
            {
                suit = Suit.Clubs,
                num = Number.Queen
            }); 
            deck.Add(new card()
            {
                suit = Suit.Clubs,
                num = Number.Jack
            }); 
            deck.Add(new card()
            {
                suit = Suit.Clubs,
                num = Number.Ten
            }); 
            deck.Add(new card()
            {
                suit = Suit.Clubs,
                num = Number.Nine
            }); 
            deck.Add(new card()
            {
                suit = Suit.Clubs,
                num = Number.Eight
            }); 
            deck.Add(new card()
            {
                suit = Suit.Clubs,
                num = Number.Seven
            }); 
            deck.Add(new card()
            {
                suit = Suit.Clubs,
                num = Number.Six
            }); 
            deck.Add(new card()
            {
                suit = Suit.Clubs,
                num = Number.Five
            }); 
            deck.Add(new card()
            {
                suit = Suit.Clubs,
                num = Number.Four
            }); 
            deck.Add(new card()
            {
                suit = Suit.Clubs,
                num = Number.Three
            }); 
            deck.Add(new card()
            {
                suit = Suit.Clubs,
                num = Number.Two
            }); 

            //Diamonds
            deck.Add(new card()
            {
                suit = Suit.Diamonds,
                num = Number.Ace
            }); 
            deck.Add(new card()
            {
                suit = Suit.Diamonds,
                num = Number.King
            }); 
            deck.Add(new card()
            {
                suit = Suit.Diamonds,
                num = Number.Queen
            }); 
            deck.Add(new card()
            {
                suit = Suit.Diamonds,
                num = Number.Jack
            }); 
            deck.Add(new card()
            {
                suit = Suit.Diamonds,
                num = Number.Ten
            }); 
            deck.Add(new card()
            {
                suit = Suit.Diamonds,
                num = Number.Nine
            }); 
            deck.Add(new card()
            {
                suit = Suit.Diamonds,
                num = Number.Eight
            }); 
            deck.Add(new card()
            {
                suit = Suit.Diamonds,
                num = Number.Seven
            }); 
            deck.Add(new card()
            {
                suit = Suit.Diamonds,
                num = Number.Six
            }); 
            deck.Add(new card()
            {
                suit = Suit.Diamonds,
                num = Number.Five
            }); 
            deck.Add(new card()
            {
                suit = Suit.Diamonds,
                num = Number.Four
            }); 
            deck.Add(new card()
            {
                suit = Suit.Diamonds,
                num = Number.Three
            }); 
            deck.Add(new card()
            {
                suit = Suit.Diamonds,
                num = Number.Two
            }); 
            
            //hearts
            deck.Add(new card()
            {
                suit = Suit.Hearts,
                num = Number.Ace
            }); 
            deck.Add(new card()
            {
                suit = Suit.Hearts,
                num = Number.King
            }); 
            deck.Add(new card()
            {
                suit = Suit.Hearts,
                num = Number.Queen
            }); 
            deck.Add(new card()
            {
                suit = Suit.Hearts,
                num = Number.Jack
            }); 
            deck.Add(new card()
            {
                suit = Suit.Hearts,
                num = Number.Ten
            }); 
            deck.Add(new card()
            {
                suit = Suit.Hearts,
                num = Number.Nine
            }); 
            deck.Add(new card()
            {
                suit = Suit.Hearts,
                num = Number.Eight
            }); 
            deck.Add(new card()
            {
                suit = Suit.Hearts,
                num = Number.Seven
            }); 
            deck.Add(new card()
            {
                suit = Suit.Hearts,
                num = Number.Six
            }); 
            deck.Add(new card()
            {
                suit = Suit.Hearts,
                num = Number.Five
            }); 
            deck.Add(new card()
            {
                suit = Suit.Hearts,
                num = Number.Four
            }); 
            deck.Add(new card()
            {
                suit = Suit.Hearts,
                num = Number.Three
            }); 
            deck.Add(new card()
            {
                suit = Suit.Hearts,
                num = Number.Two
            });
        
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


