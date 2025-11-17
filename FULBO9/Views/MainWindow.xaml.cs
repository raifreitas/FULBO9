using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FULBO9.Views;


namespace FULBO9
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

        private void AbrirEquipos(object sender, RoutedEventArgs e)
        {
            FramePrincipal.Navigate(new Equipos());
        }

        private void AbrirConfiguracion(object sender, RoutedEventArgs e)
        {
            FramePrincipal.Navigate(new Configuracion());
        }

        private void AbrirJugadores(object sender, RoutedEventArgs e)
        {
            FramePrincipal.Navigate(new Jugadores());
        }

        private void AbrirTablaPosiciones(object sender, RoutedEventArgs e)
        {
            FramePrincipal.Navigate(new TablaDePosiciones());
        }

        private void AbrirGoles(object sender, RoutedEventArgs e)
        {
            FramePrincipal.Navigate(new Goles());
        }

        private void AbrirResultados(object sender, RoutedEventArgs e)
        {
            FramePrincipal.Navigate(new Resultados());
        }

        private void AbrirCalendario(object sender, RoutedEventArgs e)
        {
            FramePrincipal.Navigate(new Calendario());
        }

        private void AbrirGrupos(object sender, RoutedEventArgs e)
        {
            FramePrincipal.Navigate (new Grupos());
        }

        private void AbrirInscripciones(object sender, RoutedEventArgs e)
        {
            FramePrincipal.Navigate(new Inscripciones());
        }
    }
}