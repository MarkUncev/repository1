using System.Windows;
using System.Windows.Controls;

namespace ContactManager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new SearchContactPage()); // Открываем поиск по умолчанию
        }

        private void GoToCreate(object sender, RoutedEventArgs e)
            => MainFrame.Navigate(new CreateContactPage());

        private void GoToSearch(object sender, RoutedEventArgs e)
            => MainFrame.Navigate(new SearchContactPage());

        private void GoToEdit(object sender, RoutedEventArgs e)
            => MainFrame.Navigate(new EditContactPage());
    }
}