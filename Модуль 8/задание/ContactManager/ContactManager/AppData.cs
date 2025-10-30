using System.Collections.ObjectModel;

namespace ContactManager
{
    public static class AppData
    {
        public static ObservableCollection<ContactModel> Contacts { get; set; } = new ObservableCollection<ContactModel>
        {
            new ContactModel { Name = "Липинский Михаил", Phone = "+375 25 608 04 49", Email = "Markuncev@gmail.com" },
            new ContactModel { Name = "Казаченко Никита", Phone = "+375 33 356 42 45", Email = "Nikita@gmail.com" }
        };
    }
}