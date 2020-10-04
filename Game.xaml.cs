using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BlackJack
{
    /// <summary>
    /// Lógica de interacción para Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        Player player = new Player();
        Dealer dealer = new Dealer();


        public Game()
        {
            InitializeComponent();

        }

        public int Check(List<Card> hand)
        {
            int value = 0;

            foreach (Card c in hand)
            {
                if (value + c.Score > 21 && c.Score == 11)
                {
                    value += 1;
                }
                else
                {

                    value += c.Score;
                }
            }
            return 0;
        }

        private void btnCartas_Click(object sender, RoutedEventArgs e)
        {
            player.Addcard(dealer.Deal());
            txtcartas.Text = "";
            foreach (Card c in player.Hand)
            { 
                txtcartas.Text += c.Suit + c.Symbol + "    ";
            }
            if (player.Hand.Count > 21)
            {
                MessageBox.Show("Perdiste");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtcartas.Text = "";
            txtdealer.Text = "";
            btnrevol.Visibility = Visibility.Visible;
            btnstop.Visibility = Visibility.Visible;
        }

        private void btndealer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            player.Hand.Clear();
            if (player.Hand == null || player.Hand.Count >= 0)
            {
                dealer.Generate();
                dealer.Randomize();

                Card c1 = dealer.Deal();
                Card c2 = dealer.Deal();

                dealer.Init();
                player.Init(c1, c2);
                foreach (Card c in player.Hand)
                {
                    txtcartas.Text += c.Suit + c.Symbol + "    ";
                }
            }
            btnrevol.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            foreach (Card c in dealer.Hand)
            {
                txtdealer.Text += c.Suit + c.Symbol + "    ";
            }
            btnstop.Visibility = Visibility.Hidden;

        }

        private void btndealercartas_Click(object sender, RoutedEventArgs e)
        {
            player.Addcard(dealer.Deal());
            txtdealer.Text = "";
            foreach (Card c in player.Hand)
            {
                txtdealer.Text += c.Suit + c.Symbol + "    ";
            }
        }
    }
}
//if (player.Hand == null || player.Hand.Count >= 0)
//{
//dealer.Generate();
//dealer.Randomize();

//Card c1 = dealer.Deal();
//Card c2 = dealer.Deal();

//dealer.Init(c1, c2);
//player.Init(c1, c2);
//foreach (Card c in player.Hand)
//{
//txtcartas.Text += c.Suit + c.Symbol + "    ";
//}


//}
//else if (player.Hand.Count > 21)
//{
//MessageBox.Show("Perdiste");

//}
//else
//{
//Card c = dealer.Deal();
//player.Addcard(c);
//}