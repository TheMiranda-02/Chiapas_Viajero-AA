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

namespace Pagina_Principal
{
    /// <summary>
    /// Lógica de interacción para IniciarSesion.xaml
    /// </summary>
    public partial class IniciarSesion : Window
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }


        //PARA EL TXTEMAIL DE EMAIL
        private void txtEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            // Si el texto es "email", lo borra y cambia el color del texto a negro
            if (txtEmail.Text == "email")
            {
                txtEmail.Text = "";
                txtEmail.Foreground = Brushes.Black;
            }
        }

        private void txtEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            // Si el campo está vacío, muestra el texto "email"
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "email";
                txtEmail.Foreground = new SolidColorBrush(Color.FromRgb(118, 113, 113));
            }
        }


        //PARA EL TXTCONTRASEÑA DE CONTRASEÑA
        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            passwordPlaceholder.Visibility = string.IsNullOrEmpty(txtPassword.Password)
                ? Visibility.Visible
                : Visibility.Collapsed;
        }

        private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Password))
                passwordPlaceholder.Visibility = Visibility.Collapsed;
        }

        private void txtPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Password))
                passwordPlaceholder.Visibility = Visibility.Visible;
        }


    }
}
