using FULBO9.ViewModels;
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
using System.Windows.Shapes;

namespace FULBO9.Views
{
    /// <summary>
    /// Lógica de interacción para Configuracion.xaml
    /// </summary>
    public partial class Configuracion : Page
    {
        /**
     * Esta es la "Vista" (la parte C#).
     * Su única responsabilidad es inicializar y 
     * conectar el ViewModel.
     */
        public Configuracion()
        {
            InitializeComponent();

            // --- ¡LA CONEXIÓN CLAVE! ---
            // Le dice a esta Vista (Configuracion.xaml) que su
            // "cerebro" (DataContext) es una nueva instancia de 
            // nuestro ConfiguracionViewModel.
            this.DataContext = new ConfiguracionViewModel();
        }
    }
}
