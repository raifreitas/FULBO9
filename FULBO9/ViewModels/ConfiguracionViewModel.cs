// --- IMPORTACIONES (Las "herramientas" que necesitamos) ---
using FULBO9.Core;      // Para usar ViewModelBase y RelayCommand
using FULBO9.Models;    // Para usar el modelo 'Campeonato'
using System.Windows.Input; // Para usar ICommand (la interfaz del RelayCommand)
using System.Windows;       // Para usar MessageBox (mostrar mensajes)

// ---- LÓGICA DE GUARDADO (temporal) ----
// Como aún no tenemos base de datos, usaremos JSON para guardar.
// Esto nos permite hacer que la app funcione AHORA.
using System.Text.Json;
using System.IO;
using System;

namespace FULBO9.ViewModels
{
    /**
     * Este es el CEREBRO (ViewModel) de la pantalla de Configuración.
     * Hereda de 'ViewModelBase' para poder usar el "Walkie-Talkie" (OnPropertyChanged).
     */
    public class ConfiguracionViewModel : ViewModelBase
    {
        // --- 1. DATOS (El Modelo) ---

        // Esta es la variable "real" que guarda el modelo
        private Campeonato _campeonato;

        // Esta es la "ventana" pública que la VISTA (View) puede ver.
        // La usaremos para enlazar todos los TextBox.
        public Campeonato CampeonatoActual
        {
            get { return _campeonato; }
            set
            {
                _campeonato = value;
                OnPropertyChanged(); // ¡Avisa a la Vista que 'CampeonatoActual' cambió!
            }
        }

        // --- 2. ACCIONES (Comandos para los botones) ---

        // Este comando se "atará" (bind) al botón de "Guardar" en la Vista.
        public ICommand GuardarCommand { get; }

        // (Este comando no lo usaremos por ahora, pero así es como se cargaría)
        // public ICommand CargarCommand { get; }


        // --- 3. CONSTRUCTOR (Lo que se ejecuta al abrir la pantalla) ---
        public ConfiguracionViewModel()
        {
            // Conecta el 'GuardarCommand' con el método 'GuardarConfiguracion'
            GuardarCommand = new RelayCommand(GuardarConfiguracion);

            // Carga la configuración al iniciar
            CargarConfiguracion();
        }


        // --- 4. MÉTODOS (La lógica real) ---

        private void CargarConfiguracion()
        {
            // LÓGICA TEMPORAL (reemplaza la BD por ahora)
            // Intenta leer el archivo JSON.
            if (File.Exists("configuracion.json"))
            {
                string json = File.ReadAllText("configuracion.json");
                CampeonatoActual = JsonSerializer.Deserialize<Campeonato>(json);
            }
            else
            {
                // Si no hay archivo, crea un 'Campeonato' nuevo y vacío
                // (Usará los valores por defecto que pusiste en el constructor del Model)
                // (Si quitaste el constructor, creará uno vacío)
                CampeonatoActual = new Campeonato();
            }
        }

        private void GuardarConfiguracion()
        {
            // LÓGICA TEMPORAL (reemplaza la BD por ahora)
            // Convierte el objeto 'CampeonatoActual' a un texto JSON
            string json = JsonSerializer.Serialize(CampeonatoActual, new JsonSerializerOptions { WriteIndented = true });

            // Guarda ese texto en un archivo
            File.WriteAllText("configuracion.json", json);

            // Avisa al usuario
            MessageBox.Show("¡Configuración guardada con éxito!");
        }
    }
}