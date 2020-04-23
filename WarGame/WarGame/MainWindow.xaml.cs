using System;
using System.Collections;
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
            Queue<int> player1 = new Queue<int>();
            Queue<int> player2 = new Queue<int>();
            
            foreach (string item in P1)
            {
                P1Convert = wc.ConvertNum(item);
                player1.Enqueue(P1Convert);
            }
            foreach (string item in P2)
            {
                P2Convert = wc.ConvertNum(item);
                player2.Enqueue(P2Convert);

            }
            //use stack instead of list pop()
            //actual process for comparing card in one list to card in another list
            do
            {
               
                int p1 = player1.Dequeue();
                int p2 = player2.Dequeue();


                if (p1 > p2)
                {
                    player1.Enqueue(p1);
                    player1.Enqueue(p2);
                      
                        
                    p1Wins++;
                }
                else if (p1 < p2)
                {
                    player2.Enqueue(p1);
                    player2.Enqueue(p2);
                        
                    p2Wins++;
                }
                else if (p1 == p2)
                {
                    warCount++;
                List<int> war = new List<int>();

                war.Add(p1);
                war.Add(p2);
                war.Add(player1.Dequeue());
                war.Add(player1.Dequeue());
                war.Add(player1.Dequeue());
                war.Add(player2.Dequeue()); 
                war.Add(player2.Dequeue()); 
                war.Add(player2.Dequeue());

                    if (player1.Dequeue() > player2.Dequeue())
                    {
                        foreach (var item in war)
                        {
                            player1.Enqueue(item);
                        }


                        p1Wins++;

                    }
                    else if (player1.Dequeue() < player2.Dequeue())
                    {
                        foreach (var item in war)
                        {
                            player2.Enqueue(item);
                        }
                    }
                    if(player1.Dequeue() == player2.Dequeue())
                    {
                        do
                        {
                            warCount++;
                            war.Add(player1.Dequeue());
                            war.Add(player1.Dequeue());
                            war.Add(player1.Dequeue());
                            war.Add(player2.Dequeue());
                            war.Add(player2.Dequeue());
                            war.Add(player2.Dequeue());
                            
                        } while (player1.Dequeue() == player2.Dequeue());

                        if (player1.Dequeue() > player2.Dequeue())
                        {
                            foreach (var item in war)
                            {
                                player1.Enqueue(item);
                            }


                            p1Wins++;

                        }
                        else if (player1.Dequeue() < player2.Dequeue())
                        {
                            foreach (var item in war)
                            {
                                player2.Enqueue(item);
                            }
                        }

                    }

                }
                 
            } while (player1.Dequeue() !=0 || player2.Dequeue() != 0);
            
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
            List<string> Player1 = new List<string>();
            List<string> Player2 = new List<string>();
            foreach (var item in lsbPlayer1.Items)
            {
                Player1.Add(item.ToString());
            }
            foreach (var item in lsbPlayer2.Items)
            {
                Player2.Add(item.ToString());
            }
           string results =  PlayGame(Player1, Player2);
            txtResults.Text = results;
        }
    }
}