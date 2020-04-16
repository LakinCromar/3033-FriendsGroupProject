using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarGame
{
    class WarClass
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public Dictionary<string, string> Cards { get; set; }
        public Dictionary<string, string > DeckShuffle { get; set; }
        
        public WarClass()
        {
             DeckShuffle = new Dictionary<string, string>();
        }
        public string ShuffleCards()
        {
            Random Shuffle = new Random();
            Dictionary<string, string> ShuffledDeck = new Dictionary<string, string>(Dictionary DeckShuffle);
            ShuffledDeck = ShuffledDeck.Select(cards => cards);

            return string.Empty;
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

    class ShuffleCards
    {
        
        

    }
}
