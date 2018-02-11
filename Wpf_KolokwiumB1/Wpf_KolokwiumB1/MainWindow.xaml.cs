using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Wpf_KolokwiumB1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Druzyna team = new Druzyna();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ustawNapastnika_Click(object sender, RoutedEventArgs e)
        {
            
            string imie;
            string nazwisko;
            int numerNaKoszulce=-1;
            int pozycja=-1;

            imie = imie1.Text;
            nazwisko = nazwisko1.Text;
            try
            {
                numerNaKoszulce = Convert.ToInt32(numerNaKoszulce1.Text);
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
                       
            try
            {
                pozycja = int.Parse(pozycja1.Text);
                if (pozycja <0||pozycja>3)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            team.UstawNapastnika(pozycja,imie, nazwisko, numerNaKoszulce);
        }

        private void ustawObronce_Click(object sender, RoutedEventArgs e)
        {
            string imie;
            string nazwisko;
            int numerNaKoszulce=-1;
            int pozycja=-1;

            imie = imie1.Text;
            nazwisko = nazwisko1.Text;
            try
            {
                numerNaKoszulce = Convert.ToInt32(numerNaKoszulce1.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
            try
            {
                pozycja = int.Parse(pozycja1.Text);
                if(pozycja<0||pozycja>3)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            team.UstawObronce(pozycja, imie, nazwisko, numerNaKoszulce);
        }

        private void ustawNazwe_Click(object sender, RoutedEventArgs e)
        {
            string nazwa=nazwaDruzyny1.Text;
            if (team.CzyOK())
            {
                team.UstawNazwe(nazwa);
                MessageBox.Show("Wybrano nazwę dla drużyny: " + nazwa);
                druzyna1.Text = team.ToString();
            }
            else
                MessageBox.Show("Drużyna jeszcze nie w komplecie!");
            
        }

        

     }
}
