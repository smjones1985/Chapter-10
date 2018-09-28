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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listbox_size.ItemsSource = new List<string>() { "S", "M", "L", "XL" };
        }

        private void button_process_Click(object sender, RoutedEventArgs e)
        {
            if(!int.TryParse(text_quantity.Text, out int n))
            {
                MessageBox.Show("Invalid quantity. Must be a number", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            // Process; Displays what the user selected as well as the quantity
            MessageBox.Show($"You have selected {listbox_size.SelectedItem}, Quantity: {n}");
        }

        private void button_exit_Click(object sender, RoutedEventArgs e)
        {
            // Exit button; Close the application
            this.Close();
        }
    }
}
