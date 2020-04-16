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
            Dictionary<string, int> Deck = new Dictionary<string, int>();

            //Spades
            Deck.Add("A♠", 14);
            Deck.Add("K♠", 13);
            Deck.Add("Q♠", 12);
            Deck.Add("J♠", 11);
            Deck.Add("10♠", 10);
            Deck.Add("9♠", 9);
            Deck.Add("8♠", 8);
            Deck.Add("7♠", 7);
            Deck.Add("6♠", 6);
            Deck.Add("5♠", 5);
            Deck.Add("4♠", 4);
            Deck.Add("3♠", 3); 
            Deck.Add("2♠", 2);

            //Clubs
            Deck.Add("A♣", 14);
            Deck.Add("K♣", 13);
            Deck.Add("Q♣", 12);
            Deck.Add("J♣", 11);
            Deck.Add("10♣", 10);
            Deck.Add("9♣", 9);
            Deck.Add("8♣", 8);
            Deck.Add("7♣", 7);
            Deck.Add("6♣", 6);
            Deck.Add("5♣", 5);
            Deck.Add("4♣", 4);
            Deck.Add("3♣", 3);
            Deck.Add("2♣", 2);


            //Hearts
            Deck.Add("A♥", 14);
            Deck.Add("K♥", 13);
            Deck.Add("Q♥", 12);
            Deck.Add("J♥", 11);
            Deck.Add("10♥", 10);
            Deck.Add("9♥", 9);
            Deck.Add("8♥", 8);
            Deck.Add("7♥", 7);
            Deck.Add("6♥", 6);
            Deck.Add("5♥", 5);
            Deck.Add("4♥", 4);
            Deck.Add("3♥", 3);
            Deck.Add("2♥", 2);

            //Diamonds
            Deck.Add("A♦", 14);
            Deck.Add("K♦", 13);
            Deck.Add("Q♦", 12);
            Deck.Add("J♦", 11);
            Deck.Add("10♦", 10);
            Deck.Add("9♦", 9);
            Deck.Add("8♦", 8);
            Deck.Add("7♦", 7);
            Deck.Add("6♦", 6);
            Deck.Add("5♦", 5);
            Deck.Add("4♦", 4);
            Deck.Add("3♦", 3);
            Deck.Add("2♦", 2);




        }
        private void NewGameBTN_Click(object sender, RoutedEventArgs e)
        {
            WarClass wc = new WarClass();
            List<card> GameDeck = wc.ShuffledDeck();
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

            PlayGame(Player1, Player2);



        }       
        private void FlipCardBTN_Click(object sender, RoutedEventArgs e)
        {
            

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


                        p1Wins++;
                    }
                    else if (P1[i].num < P2[i].num)
                    {



                        p2Wins++;
                    }
                    else if (P1[i].num == P2[i].num)
                    {



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