namespace BasicASPNETApp.Models
{
    public class ContactDao
    {
        private List<string> contacts;

        public ContactDao() => contacts = ["anil", "sunil", "joydip"];

        public List<string> FetchContacts()
        {
            return contacts;
        }

        public string FetchContact(string personName)
        {            
            if (contacts.Any(c => c.Equals(personName)))
                return $"{contacts.Where(c => c.Equals(personName)).First()} is found...";
            else
                return $"{personName} not found";
        }
    }
}
