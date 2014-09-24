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

namespace WpfApplication1
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

  


        private void txt_edad_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            txt_edad.Clear();
            lbl_resultado.Content = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int edad =Convert.ToInt16(txt_edad.Text);
                var r = lbl_resultado;
                if (edad > 0 && edad <= 10)
                {
                    r.Content = "El peso ideal es " + (edad* 2 + 8) + " kilos.";
                }
                else
                {
                   // r.Content = "Edad inválida para calcular.";
                    MessageBox.Show("Edad inválida para calcular","Error", MessageBoxButton.OK,MessageBoxImage.Exclamation);
                }
                }
            catch (Exception ex)
            {

                lbl_resultado.Content = "Ingrese una edad válida.";
            }
            
        }
    }
}
