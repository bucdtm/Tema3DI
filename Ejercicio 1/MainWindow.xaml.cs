using System.Windows;
using System.Windows.Controls;

namespace Ejercicio1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Característica requerida: Salir del programa con Application.Current.Shutdown()
        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnMaximizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.WindowState == WindowState.Maximized 
                ? WindowState.Normal 
                : WindowState.Maximized;
        }

        private void BtnEntradas_Click(object sender, RoutedEventArgs e)
        {
            lblEstado.Text = "Opción seleccionada: Entradas de material";
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            lblEstado.Text = "Opción seleccionada: Guardar / Base de datos";
        }

        private void BtnListados_Click(object sender, RoutedEventArgs e)
        {
            lblEstado.Text = "Opción seleccionada: Listados generales";
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender is MenuItem item)
            {
                lblEstado.Text = $"Menú seleccionado: {item.Header}";
            }
        }
    }
}
