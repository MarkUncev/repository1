using System.Windows;
using System.Windows.Controls;

namespace ContactManager
{
    public partial class CreateContactPage : Page
    {
        public CreateContactPage()
        {
            InitializeComponent();
        }

        private void SaveContact_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Введите имя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var contact = new ContactModel
            {
                Name = NameTextBox.Text.Trim(),
                Phone = PhoneTextBox.Text.Trim(),
                Email = EmailTextBox.Text.Trim()
            };

            AppData.Contacts.Add(contact);
            MessageBox.Show("Контакт добавлен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

            NameTextBox.Clear();
            PhoneTextBox.Clear();
            EmailTextBox.Clear();
        }
    }
}