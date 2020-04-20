using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WarGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

         
 


            //Dictionary<string, int> deck = new Dictionary<string, int>();

            ////Spades
            //deck.Add("A♠", 14);
            //deck.Add("K♠", 13);
            //deck.Add("Q♠", 12);
            //deck.Add("J♠", 11);
            //deck.Add("10♠", 10);
            //deck.Add("9♠", 9);
            //deck.Add("8♠", 8);
            //deck.Add("7♠", 7);
            //deck.Add("6♠", 6);
            //deck.Add("5♠", 5);
            //deck.Add("4♠", 4);
            //deck.Add("3♠", 3); 
            //deck.Add("2♠", 2);

            ////Clubs
            //deck.Add("A♣", 14);
            //deck.Add("K♣", 13);
            //deck.Add("Q♣", 12);
            //deck.Add("J♣", 11);
            //deck.Add("10♣", 10);
            //deck.Add("9♣", 9);
            //deck.Add("8♣", 8);
            //deck.Add("7♣", 7);
            //deck.Add("6♣", 6);
            //deck.Add("5♣", 5);
            //deck.Add("4♣", 4);
            //deck.Add("3♣", 3);
            //deck.Add("2♣", 2);


            ////Hearts
            //deck.Add("A♥", 14);
            //deck.Add("K♥", 13);
            //deck.Add("Q♥", 12);
            //deck.Add("J♥", 11);
            //deck.Add("10♥", 10);
            //deck.Add("9♥", 9);
            //deck.Add("8♥", 8);
            //deck.Add("7♥", 7);
            //deck.Add("6♥", 6);
            //deck.Add("5♥", 5);
            //deck.Add("4♥", 4);
            //deck.Add("3♥", 3);
            //deck.Add("2♥", 2);

            ////Diamonds
            //deck.Add("A♦", 14);
            //deck.Add("K♦", 13);
            //deck.Add("Q♦", 12);
            //deck.Add("J♦", 11);
            //deck.Add("10♦", 10);
            //deck.Add("9♦", 9);
            //deck.Add("8♦", 8);
            //deck.Add("7♦", 7);
            //deck.Add("6♦", 6);
            //deck.Add("5♦", 5);
            //deck.Add("4♦", 4);
            //deck.Add("3♦", 3);
            //deck.Add("2♦", 2);




        }
        private void NewGameBTN_Click(object sender, RoutedEventArgs e)
        {
            WarClass wc = new WarClass();
            List<card> GameDeck = ShuffledDeck();
            List<card> Player1 = new List<card>();
            List<card> Player2 = new List<card>();
            for (int i = 0; i < 26; i++)
            {
                Player1 = GameDeck;
            }
            for (int i = 26; i < 53; i++)
            {
                Player2 = GameDeck;
            }
            foreach  (card card in GameDeck)
            {
                
            }
            PlayGame(Player1, Player2);



        }
        public List<card> ShuffledDeck()
        {
            //Dictionary<string, int> ShuffledDeck = new Dictionary<string, int>(cardsShuffle);
            List<card> ShuffleDeck = new List<card>();
            WarClass wc = new WarClass();
            Random Shuffle = new Random();
            if (wc!=null)
            {
                for (int i = 0; i < wc.deck.Count -1; i++)

                {
                    ShuffleDeck.Add(wc.deck[i]);
                    //int cards = Shuffle.Next(0, wc.deck.Count);
                    //ShuffleDeck.Add(wc.deck[cards]);
                    //wc.deck.Remove(wc.deck[cards]);

                    // ShuffleDeck = wc.deck.OrderBy(X => Shuffle.Next()).ToList();
                }

            }
            


            wc.deck = ShuffleDeck;

            return ShuffleDeck;
        }
        public string PlayGame(List<card> P1, List<card> P2)
        {
            double p1Wins = 0;
            double p2Wins = 0;
            double warCount = 0;
            double roundsPlayed = 0;
            bool p1Winner;
            bool p2Winner;
            string winner = string.Empty;
            while (P1.Count>0 ||P2.Count >0)
            {
                for (int i = 0; i < P1.Count; i++)
                {
                    if (P1[i].num > P2[i].num)
                    {
                        P1.Add(P1[i]);
                        P1.Add(P2[i]);

                        p1Wins++;
                    }
                    else if (P1[i].num < P2[i].num)
                    {
                        P2.Add(P1[i]);
                        P2.Add(P2[i]);
                        p2Wins++;
                    }
                    else if (P1[i].num == P2[i].num)
                    {
                        while (P1[i].num == P2[i].num)
                        {
                            if (P1[i+4].num > P2[i+4].num)
                            {
                                P1.Add(P1[i]);
                                P1.Add(P1[i +1]);
                                P1.Add(P1[i+2]); 
                                P1.Add(P1[i+3]); 
                                P1.Add(P1[i+4]);
                                P1.Add(P2[i]);
                                P1.Add(P2[i+1]);
                                P1.Add(P2[i+2]);
                                P1.Add(P2[i+3]);
                                P1.Add(P2[i+4]);
                            }
                            else if (P1[i + 4].num < P2[i + 4].num)
                            {
                                P2.Add(P1[i]);
                                P2.Add(P1[i + 1]);
                                P2.Add(P1[i + 2]);
                                P2.Add(P1[i + 3]);
                                P2.Add(P1[i + 4]);
                                P2.Add(P2[i]);
                                P2.Add(P2[i + 1]);
                                P2.Add(P2[i + 2]);
                                P2.Add(P2[i + 3]);
                                P2.Add(P2[i + 4]);
                            }
                        }
                        


                        warCount++;
                    }
                }
            }
            if (P1.Count == 0)
            {
                p2Winner = true;
                p1Winner = false;
                winner = $"The winner is Player2";
            }
            else if (P2.Count == 0)
            {
                p2Winner = false;
                p1Winner = true;
                winner = $"The winner is Player1";
            }
            roundsPlayed++;

            string sentence = $"{winner}! \n Player 1 won {p1Wins} hands. \n Player 2 won {p2Wins} hands. \n There were {warCount} wars palyed. \n There were {roundsPlayed} rounds played";

            return sentence;







        }
    }
}