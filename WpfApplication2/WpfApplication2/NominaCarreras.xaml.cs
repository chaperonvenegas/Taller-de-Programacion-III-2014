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
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Lógica de interacción para NominaCarreras.xaml
    /// </summary>
    public partial class NominaCarreras : Window
    {
        public NominaCarreras()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfApplication2.bd_inacapDataSet bd_inacapDataSet = ((WpfApplication2.bd_inacapDataSet)(this.FindResource("bd_inacapDataSet")));
            // Cargar datos en la tabla carreras. Puede modificar este código según sea necesario.
            WpfApplication2.bd_inacapDataSetTableAdapters.carrerasTableAdapter bd_inacapDataSetcarrerasTableAdapter = new WpfApplication2.bd_inacapDataSetTableAdapters.carrerasTableAdapter();
            bd_inacapDataSetcarrerasTableAdapter.Fill(bd_inacapDataSet.carreras);
            System.Windows.Data.CollectionViewSource carrerasViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("carrerasViewSource")));
            carrerasViewSource.View.MoveCurrentToFirst();
        }

        private void carrerasDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
