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
using FULBO9.Paginas;


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
    }
}