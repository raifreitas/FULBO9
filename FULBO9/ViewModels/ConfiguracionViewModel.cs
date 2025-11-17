// --- IMPORTACIONES (Las "herramientas" que necesitamos) ---
using FULBO9.Core;
using FULBO9.Models;
using System.Windows.Input;
using System.Windows;
using System.Text.Json;
using System.IO;
using System;

namespace FULBO9.ViewModels
{
    public class ConfiguracionViewModel : ViewModelBase
    {
        // --- 1. DATOS (El Modelo) ---

        // ARREGLO: Inicializamos el campo para que nunca sea 'null'
        // al salir del constructor.
        private Campeonato _campeonato = new Campeonato();

        public Campeonato CampeonatoActual
        {
            get { return _campeonato; }
            set
            {
                _campeonato = value;
                OnPropertyChanged();
            }
        }

        // --- 2. ACCIONES (Comandos para los botones) ---

        // ARREGLO: 'GuardarCommand' debe ser 'get' y 'set' (o 'get' y 'init')
        // o inicializarse aquí. Lo inicializaremos en el constructor.
        public ICommand GuardarCommand { get; }

        // --- 3. CONSTRUCTOR ---
        public ConfiguracionViewModel()
        {
            GuardarCommand = new RelayCommand(GuardarConfiguracion);
            CargarConfiguracion();
        }


        // --- 4. MÉTODOS (La lógica real) ---

        private void CargarConfiguracion()
        {
            try // Es buena práctica envolver I/O en un try-catch
            {
                if (File.Exists("configuracion.json"))
                {
                    string json = File.ReadAllText("configuracion.json");

                    // ARREGLO: Verificamos si la deserialización da 'null'
                    var configCargada = JsonSerializer.Deserialize<Campeonato>(json);
                    if (configCargada != null)
                    {
                        CampeonatoActual = configCargada;
                    }
                    else
                    {
                        // Si el JSON está corrupto, empezamos con uno nuevo
                        CampeonatoActual = new Campeonato();
                    }
                }
                else
                {
                    CampeonatoActual = new Campeonato();
                }
            }
            catch (Exception ex)
            {
                // Si algo falla (ej. permisos), mostramos un error
                MessageBox.Show($"Error al cargar configuración: {ex.Message}");
                CampeonatoActual = new Campeonato();
            }
        }

        private void GuardarConfiguracion()
        {
            try
            {
                string json = JsonSerializer.Serialize(CampeonatoActual, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("configuracion.json", json);
                MessageBox.Show("¡Configuración guardada con éxito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar configuración: {ex.Message}");
            }
        }
    }
}