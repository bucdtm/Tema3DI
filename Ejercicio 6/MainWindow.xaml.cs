using System.Windows;
using System.Windows.Controls;

namespace Ejercicio6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavHeader_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag != null)
            {
                lblStatus.Text = $"Sección activa: {btn.Tag}";
            }
        }

        private void BtnAddItem_Click(object sender, RoutedEventArgs e)
        {
            lblStatus.Text = "Acción: '+ Add Item' pulsado";
        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            lblStatus.Text = "Acción: Ajustes pulsado";
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void StageButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag != null)
            {
                lblStatus.Text = $"Etapa seleccionada (Your Stage): {btn.Tag}";
            }
        }

        private void TaskNavButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag != null)
            {
                lblStatus.Text = $"Bandeja de tareas seleccionada: {btn.Tag}";
            }
        }
    }
}
