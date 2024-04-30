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


namespace DBProject2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;

        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the RegistrationPage window
           
            Customer customerwindow = new Customer();
            this.Close();
            customerwindow.Show();

            // Show the RegistrationPage window
          

            // Optionally, you can close the current window
        }

        private void cmbAccountType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the RegistrationPage window
            RegistrationPage registrationWindow = new RegistrationPage();

            // Show the RegistrationPage window
            this.Close();
            registrationWindow.Show();

            // Optionally, you can close the current window

        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}



