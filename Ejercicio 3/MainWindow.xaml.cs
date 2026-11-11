using System.Windows;
using System.Windows.Controls;

namespace Ejercicio3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnDesconectar_Click(object sender, RoutedEventArgs e)
        {
            popupMenu.IsOpen = false;
            btnMore.IsChecked = false;
            Application.Current.Shutdown();
        }

        private void PopupItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag != null)
            {
                txtContenido.Text = $"Opción de barra superior: {btn.Tag}";
                popupMenu.IsOpen = false;
                btnMore.IsChecked = false;
            }
        }

        private void SubItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                txtContenido.Text = $"Sección seleccionada: {btn.Content}";
            }
        }
    }
}
