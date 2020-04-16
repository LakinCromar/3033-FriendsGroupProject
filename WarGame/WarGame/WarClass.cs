  using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace WarGame
{
    class WarClass
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public Dictionary<string, int > Deck { get; set; }

        public WarClass()
        {
             Deck = new Dictionary<string, int>();

        }

        /// <summary>
        /// This will shuffle the cards once the person clicks new game by randomizing the order of cards and storing it to a new deck
        /// </summary>
        /// <param name="cardsShuffle"></param>
        /// <returns>Shuffled set of cards</returns>
        public Dictionary<string, int> ShuffledDeck(Dictionary<string,int> cardsShuffle)
        {
            Dictionary<string, int> ShuffledDeck = new Dictionary<string, int>(cardsShuffle);
        
            Random Shuffle = new Random();
            
            ShuffledDeck = ShuffledDeck.Select(cards => cards);

            return string.Empty;
        }

    }

}
