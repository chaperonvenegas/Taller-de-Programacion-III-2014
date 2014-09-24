using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
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
    /// Lógica de interacción para NuevaCarrera.xaml
    /// </summary>
    public partial class NuevaCarrera : Window
    {
        public NuevaCarrera()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, RoutedEventArgs e)
        {
            string cadenaConexion           = ConfigurationManager.ConnectionStrings["WpfApplication2.Properties.Settings.bd_inacapConnectionString"].ToString();
            SqlConnection conexionBdInacap  = new SqlConnection(cadenaConexion);

            SqlCommand insertaCarrera       = new SqlCommand("insert into carreras(id_carrera,nombre_carrera,tipo_carrera) values(@v_id,@v_nombre,@v_tipo)", conexionBdInacap);
           
            insertaCarrera.Parameters.AddWithValue("@v_id", txt_codigo.Text.ToString());
            insertaCarrera.Parameters.AddWithValue("@v_nombre", txt_nombre.Text.ToString());
            insertaCarrera.Parameters.AddWithValue("@v_tipo", txt_tipo.Text.ToString());

            try
            {
                conexionBdInacap.Open();
                insertaCarrera.ExecuteNonQuery();
                lbl_resultado.Content = "Nueva Carrera registrada correctamente.";
            }
            catch (Exception)
            {

                lbl_resultado.Content = "Error";
            }


        }
    }
}
