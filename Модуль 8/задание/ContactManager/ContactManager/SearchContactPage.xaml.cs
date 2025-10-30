using System.Windows.Controls;
using System.Linq;

namespace ContactManager
{
    public partial class SearchContactPage : Page
    {
        public SearchContactPage()
        {
            InitializeComponent();
            ContactsListBox.ItemsSource = AppData.Contacts;
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = SearchTextBox.Text.ToLower();
            var filtered = string.IsNullOrWhiteSpace(search)
                ? AppData.Contacts
                : AppData.Contacts.Where(c => c.Name.ToLower().Contains(search));

            ContactsListBox.ItemsSource = filtered;
        }
    }
}