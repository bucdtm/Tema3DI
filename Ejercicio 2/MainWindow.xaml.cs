using System.Windows;
using Fluent;

namespace Ejercicio2
{
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Fluent.Button btn)
            {
                lblInfo.Text = $"Acción ejecutada: {btn.Header}";
            }
        }
    }
}
