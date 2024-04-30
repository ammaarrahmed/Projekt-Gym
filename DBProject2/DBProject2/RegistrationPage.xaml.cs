using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DBProject2
{
    /// <summary>
    /// Interaction logic for RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Window
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        public ObservableCollection<string> ItemsSource
        {
            get { return (ObservableCollection<string>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(ObservableCollection<string>), typeof(RegistrationPage));

        public void ComboBox()
        {
            InitializeComponent();
            comboBox.DropDownOpened += (sender, e) => { listBox.Visibility = Visibility.Visible; };
            comboBox.DropDownClosed += (sender, e) => { listBox.Visibility = Visibility.Collapsed; };
            comboBox.SelectionChanged += (sender, e) =>
            {
                // Update selection in ListBox or CheckBoxes based on ComboBox selection
                // This is a simplified example
                listBox.SelectedItem = comboBox.SelectedItem;
            };
        }
    }
}
