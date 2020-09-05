using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Onlypans
{
    /// <summary>
    /// Lógica de interacción para login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            if(txtusername.Text== "empleada" && txtpassword.Password=="1234" )
            {
                MainWindow w = (MainWindow) Window.GetWindow(this);
                w.FrameMain.NavigationService.Navigate(new home());
            }
            if (txtusername.Text == "administradora" && txtpassword.Password == "4321")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.FrameMain.NavigationService.Navigate(new home_administradora());
            }
            else
            {
                MessageBox.Show("datos incorrectos");
            }

        }
    }
}
