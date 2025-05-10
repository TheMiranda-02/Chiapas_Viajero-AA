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

namespace Pagina_Principal
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

        //PARA IR A LA VENTANA DE INICIAR SESION
        private void BtnIniciarSesion(object sender, RoutedEventArgs e)
        {
            IniciarSesion ventana = new IniciarSesion();
            ventana.Show();

            this.Close();
        }

        //PARA IR A LA VENTANA DE CREAR CUENTA
        private void BtnCrearCuenta(object sender, RoutedEventArgs e)
        {
            CrearCuenta ventanacrear = new CrearCuenta();
            ventanacrear.Show();

            this.Close();
        }

        private void BtnRegistros(Object sender, RoutedEventArgs e)
        {
            Registros_Datos VentanaDatos = new Registros_Datos();
            VentanaDatos.Show();

            this.Close();
        }

    }
}
