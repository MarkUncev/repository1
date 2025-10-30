using System.Windows;
using System.Windows.Controls;

namespace ContactManager
{
    public partial class EditContactPage : Page
    {
        private ContactModel selectedContact;

        public EditContactPage()
        {
            InitializeComponent();
            ContactsListBox.ItemsSource = AppData.Contacts;
        }

        private void ContactsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedContact = ContactsListBox.SelectedItem as ContactModel;
            if (selectedContact != null)
            {
                NameTextBox.Text = selectedContact.Name;
                PhoneTextBox.Text = selectedContact.Phone;
                EmailTextBox.Text = selectedContact.Email;
                EditForm.IsEnabled = true;
            }
            else
            {
                EditForm.IsEnabled = false;
            }
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            if (selectedContact == null || string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                MessageBox.Show("Выберите контакт и введите имя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            selectedContact.Name = NameTextBox.Text.Trim();
            selectedContact.Phone = PhoneTextBox.Text.Trim();
            selectedContact.Email = EmailTextBox.Text.Trim();

            MessageBox.Show("Изменения сохранены!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            ContactsListBox.ItemsSource = null;
            ContactsListBox.ItemsSource = AppData.Contacts;
        }

        private void DeleteContact_Click(object sender, RoutedEventArgs e)
        {
            if (selectedContact != null &&
                MessageBox.Show($"Удалить контакт \"{selectedContact.Name}\"?", "Подтверждение",
                MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                AppData.Contacts.Remove(selectedContact);
                MessageBox.Show("Контакт удалён!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                NameTextBox.Clear();
                PhoneTextBox.Clear();
                EmailTextBox.Clear();
                EditForm.IsEnabled = false;

                ContactsListBox.ItemsSource = null;
                ContactsListBox.ItemsSource = AppData.Contacts;
            }
        }
    }
}