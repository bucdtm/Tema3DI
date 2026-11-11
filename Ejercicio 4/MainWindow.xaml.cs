using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Ejercicio4
{
    public partial class MainWindow : Window
    {
        private bool _isMenuExpanded = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnHamburger_Click(object sender, RoutedEventArgs e)
        {
            _isMenuExpanded = !_isMenuExpanded;
            double targetWidth = _isMenuExpanded ? 220 : 60;

            GridLengthAnimation animation = new GridLengthAnimation
            {
                From = navColumn.Width,
                To = new GridLength(targetWidth),
                Duration = TimeSpan.FromMilliseconds(200)
            };

            navColumn.BeginAnimation(ColumnDefinition.WidthProperty, animation);
        }

        private void MenuOption_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag != null)
            {
                string tag = btn.Tag.ToString() ?? string.Empty;
                lblTituloSeccion.Text = $"Sección: {tag}";
                lblDescripcionSeccion.Text = $"Has navegado a la pantalla de {tag}.";
            }
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
    }

    public class GridLengthAnimation : AnimationTimeline
    {
        public static readonly DependencyProperty FromProperty =
            DependencyProperty.Register("From", typeof(GridLength), typeof(GridLengthAnimation));

        public static readonly DependencyProperty ToProperty =
            DependencyProperty.Register("To", typeof(GridLength), typeof(GridLengthAnimation));

        public GridLength From
        {
            get => (GridLength)GetValue(FromProperty);
            set => SetValue(FromProperty, value);
        }

        public GridLength To
        {
            get => (GridLength)GetValue(ToProperty);
            set => SetValue(ToProperty, value);
        }

        public override Type TargetPropertyType => typeof(GridLength);

        protected override Freezable CreateInstanceCore() => new GridLengthAnimation();

        public override object GetCurrentValue(object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock)
        {
            double progress = animationClock.CurrentProgress ?? 1.0;
            double fromVal = From.Value;
            double toVal = To.Value;

            if (fromVal > toVal)
            {
                return new GridLength((1 - progress) * (fromVal - toVal) + toVal, GridUnitType.Pixel);
            }

            return new GridLength(progress * (toVal - fromVal) + fromVal, GridUnitType.Pixel);
        }
    }
}
