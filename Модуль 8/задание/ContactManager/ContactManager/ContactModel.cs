using System;

namespace ContactManager
{
    public class ContactModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";

        public override string ToString() => $"{Name} ({Phone})";
    }
}