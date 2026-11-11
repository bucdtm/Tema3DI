using System.Windows;
using System.Windows.Controls;

namespace Ejercicio5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Option_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                string mensaje = $"Has seleccionado: {btn.Content}";
                txtEstado1.Text = mensaje;
                txtEstado2.Text = mensaje;
                txtEstado3.Text = mensaje;
                txtEstado4.Text = mensaje;
                txtEstado5.Text = mensaje;
            }
        }
    }
}
