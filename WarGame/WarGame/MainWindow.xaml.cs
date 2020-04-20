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
            


            //List<card> deck = new List<card>();

            ////Spades
            //deck.Add(new card()
            //{
            //    suit = Suit.Spades,
            //    num = Number.Ace
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Spades,
            //    num = Number.King
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Spades,
            //    num = Number.Queen
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Spades,
            //    num = Number.Jack
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Spades,
            //    num = Number.Ten
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Spades,
            //    num = Number.Nine
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Spades,
            //    num = Number.Eight
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Spades,
            //    num = Number.Seven
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Spades,
            //    num = Number.Six
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Spades,
            //    num = Number.Five
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Spades,
            //    num = Number.Four
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Spades,
            //    num = Number.Three
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Spades,
            //    num = Number.Two
            //});

            ////Clubs
            //deck.Add(new card()
            //{
            //    suit = Suit.Clubs,
            //    num = Number.Ace
            //}); deck.Add(new card()
            //{
            //    suit = Suit.Clubs,
            //    num = Number.King
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Clubs,
            //    num = Number.Queen
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Clubs,
            //    num = Number.Jack
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Clubs,
            //    num = Number.Ten
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Clubs,
            //    num = Number.Nine
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Clubs,
            //    num = Number.Eight
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Clubs,
            //    num = Number.Seven
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Clubs,
            //    num = Number.Six
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Clubs,
            //    num = Number.Five
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Clubs,
            //    num = Number.Four
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Clubs,
            //    num = Number.Three
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Clubs,
            //    num = Number.Two
            //});

            ////Diamonds
            //deck.Add(new card()
            //{
            //    suit = Suit.Diamonds,
            //    num = Number.Ace
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Diamonds,
            //    num = Number.King
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Diamonds,
            //    num = Number.Queen
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Diamonds,
            //    num = Number.Jack
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Diamonds,
            //    num = Number.Ten
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Diamonds,
            //    num = Number.Nine
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Diamonds,
            //    num = Number.Eight
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Diamonds,
            //    num = Number.Seven
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Diamonds,
            //    num = Number.Six
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Diamonds,
            //    num = Number.Five
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Diamonds,
            //    num = Number.Four
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Diamonds,
            //    num = Number.Three
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Diamonds,
            //    num = Number.Two
            //});

            ////hearts
            //deck.Add(new card()
            //{
            //    suit = Suit.Hearts,
            //    num = Number.Ace
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Hearts,
            //    num = Number.King
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Hearts,
            //    num = Number.Queen
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Hearts,
            //    num = Number.Jack
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Hearts,
            //    num = Number.Ten
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Hearts,
            //    num = Number.Nine
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Hearts,
            //    num = Number.Eight
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Hearts,
            //    num = Number.Seven
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Hearts,
            //    num = Number.Six
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Hearts,
            //    num = Number.Five
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Hearts,
            //    num = Number.Four
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Hearts,
            //    num = Number.Three
            //});
            //deck.Add(new card()
            //{
            //    suit = Suit.Hearts,
            //    num = Number.Two
            //});


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
            //create new instance of war class, call the shuffled deck method, create lists for each player
            WarClass wc = new WarClass();
            List<string> GameDeck = ShuffledDeck();
            List<string> Player1 = new List<string>();
            List<string> Player2 = new List<string>();

            //add cards to each players list. 
            for (int i = 0; i < (GameDeck.Count)/2; i++)
            {

                Player1.Add(GameDeck[i]);
            }
            for (int i = (GameDeck.Count)/2 ; i < GameDeck.Count; i++)
            {
                Player2.Add(GameDeck[i]);
            }

            lsbPlayer1.IsEnabled = true;
            lsbPlayer2.IsEnabled = true;

            //start Converting from "Ace of Spades" "A♠" and store to a new list.
            string P1Convert = string.Empty;
            string P2Convert = string.Empty;
      
            
            //output converted list to list boxes
            foreach  (string item in Player1)
            {
                P1Convert = wc.Convert(item);
               
                lsbPlayer1.Items.Add(P1Convert);
            }
            foreach (var item in Player2)
            {
                P2Convert = wc.Convert(item);
                lsbPlayer2.Items.Add(P2Convert);

            }

            //count of each players deck
            int p1Count = Player1.Count;
            int p2Count = Player2.Count;
            txtCountP1.Text = p1Count.ToString();
            txtCountP2.Text = p2Count.ToString();

            btnPlayGame.IsEnabled = true;

        }
        public List<string> ShuffledDeck()
        {
           
            List<card> ShuffleDeck = new List<card>();
            WarClass wc = new WarClass();
            Random Shuffle = new Random();
            
            //creates a new random instance of card type and stores a random oorder to shffledeck list
            foreach  (card card in wc.Deck)
            {
                ShuffleDeck = wc.Deck.OrderBy(card => Shuffle.Next()).ToList();
            }

            //gets the cards in the shuffled deck list and converts them to a string so i can output each card individually
            List<string> SD = new List<string>();
            string cd = string.Empty;
            foreach (card item in ShuffleDeck)
            {
                cd = $"{item.num} of {item.suit}";
                SD.Add(cd);
            }
            return SD;
        }
        public string PlayGame(List<string> P1, List<string> P2)
        {
            double p1Wins = 0;
            double p2Wins = 0;
            double warCount = 0;
            double roundsPlayed = 0;
            bool p1Winner;
            bool p2Winner;
            string winner = string.Empty;
            WarClass wc = new WarClass();
            int P1Convert = 0;
            int P2Convert = 0;
            
            
            // convert the list to the new convert method so i can get values rather than strings. store them to lists of type int
            List<int> player1 = new List<int>();
            List<int> player2 = new List<int>();
            foreach (string item in P1)
            {
                P1Convert = wc.ConvertNum(item);
                player1.Add(P1Convert);
            }
            foreach (string item in P2)
            {
                P2Convert = wc.ConvertNum(item);
                player2.Add(P2Convert);

            }

            //actual process for comparing card in one list to card in another list
            do
            {
                for (int i = 0; i <player1.Count; i++)
                {
                    if (player1[i] > player2[i])
                    {

                        player1.Add(player1[i]);
                        player1.Add(player2[i]);
                        p1Wins++;
                    }
                    else if (player1[i] < player2[i])
                    {
                        player2.Add(player1[i]);
                        player2.Add(player2[i]);
                        p2Wins++;
                    }
                    else if (player1[i] == player2[1])
                    {
                        warCount++;
                        if (player1[i+4] > player2[i+4])
                        {
                            player1.Add(player1[i]);
                            player1.Add(player1[i + 1]);
                            player1.Add(player1[i + 2]);
                            player1.Add(player1[i + 3]);
                            player1.Add(player1[i + 4]);
                            player1.Add(player2[i]);
                            player1.Add(player2[i + 1]);
                            player1.Add(player2[i + 2]);
                            player1.Add(player2[i + 3]);
                            player1.Add(player2[i + 4]); ;

                            p1Wins++;

                        }
                        else if (player1[i+4] < player2[i+4])
                        {
                            player2.Add(player1[i]);
                            player2.Add(player1[i + 1]);
                            player2.Add(player1[i + 2]);
                            player2.Add(player1[i + 3]);
                            player2.Add(player1[i + 4]);
                            player2.Add(player2[i]);
                            player2.Add(player2[i + 1]);
                            player2.Add(player2[i + 2]);
                            player2.Add(player2[i + 3]);
                            player2.Add(player2[i + 4]);

                            p2Wins++;
                        }
                        else if (player1[i+4] == player2[i+4])
                        {
                            warCount++;
                            if (player1[i+8] > player2[i + 8] || player1[i + 8] == player2[i + 8])
                            {
                                player1.Add(player1[i]);
                                player1.Add(player1[i+1]);
                                player1.Add(player1[i+2]);
                                player1.Add(player1[i+3]);
                                player1.Add(player1[i+4]);
                                player1.Add(player2[i]);
                                player1.Add(player2[i+1]);
                                player1.Add(player2[i+2]);
                                player1.Add(player2[i+3]);
                                player1.Add(player2[i+4]);
                                player1.Add(player1[i+5]);
                                player1.Add(player1[i+6]);
                                player1.Add(player1[i+7]);
                                player1.Add(player1[i+8]);
                                player1.Add(player2[i+5]);
                                player1.Add(player2[i+6]);
                                player1.Add(player2[i+7]);
                                player1.Add(player2[i+8]);

                                p1Wins++;
                            }
                            else if (player1[i+8] < player2[i+8])
                            {
                                player2.Add(player1[i]);
                                player2.Add(player1[i + 1]);
                                player2.Add(player1[i + 2]);
                                player2.Add(player1[i + 3]);
                                player2.Add(player1[i + 4]);
                                player2.Add(player2[i]);
                                player2.Add(player2[i + 1]);
                                player2.Add(player2[i + 2]);
                                player2.Add(player2[i + 3]);
                                player2.Add(player2[i + 4]);
                                player2.Add(player1[i + 5]);
                                player2.Add(player1[i + 6]);
                                player2.Add(player1[i + 7]);
                                player2.Add(player1[i + 8]);
                                player2.Add(player2[i + 5]);
                                player2.Add(player2[i + 6]);
                                player2.Add(player2[i + 7]);
                                player2.Add(player2[i + 8]);

                                p2Wins++;
                            }

                        }
                    }
                }
               
            } while (player1.Count != 0 || player2.Count != 0);
            
            if (player1.Count == 0)
            {
                p2Winner = true;
                p1Winner = false;
                winner = $"The winner is Player2";
            }
            else if (player2.Count == 0)
            {
                p2Winner = false;
                p1Winner = true;
                winner = $"The winner is Player1";
            }
            roundsPlayed++;

            string sentence = $"{winner}! \n Player 1 won {p1Wins} hands. \n Player 2 won {p2Wins} hands. \n There was {warCount} wars palyed. \n There was {roundsPlayed} rounds played";

            return sentence;

        }

        private void btnPlayGame_Click(object sender, RoutedEventArgs e)
        {
            txtResults.IsEnabled = true;
            PG pg = new PG();
           string results =  PlayGame(pg.Player1, pg.Player2);
            txtResults.Text = results;
        }
    }
}