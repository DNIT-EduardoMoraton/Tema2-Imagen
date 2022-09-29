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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema3_Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void opacidadAltaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            img1Image.Opacity = 1;
        }

        private void opacidadMediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            img1Image.Opacity = 0.5;
        }

        private void opacidadBajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            img1Image.Opacity = 0.1;
        }

        private void ajusteFillRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            img1Image.Stretch = Stretch.Fill;
        }

        private void ajusteUniformRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            img1Image.Stretch = Stretch.Uniform;
        }

        private void ajusteUniformToFillRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            img1Image.Stretch = Stretch.UniformToFill;
        }

        private void ajusteNoneRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            img1Image.Stretch = Stretch.None;
        }
    }
}
