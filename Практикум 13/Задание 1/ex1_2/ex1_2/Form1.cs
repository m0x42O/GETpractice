using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;


namespace ex1_2
{
    public partial class Form1 : Form
    {
        private Contact[] Contacts;
        private Contact[] FilteredContacts;

        public Form1()
        {
            InitializeComponent();
            LoadContacts();
            FillDGV();
            searchLM.TextChanged += SearchLM_TextChanged;
        }

        private void SearchLM_TextChanged(object sender, EventArgs e)
        {
            FindByLastName(searchLM.Text, Contacts);
        }

        private void LoadContacts()
        {
            string filepath = "contacts.xml";
            string bufData = File.ReadAllText(filepath).Replace('\n', ' ');
            this.FilteredContacts = this.Contacts = ParseContacts(bufData);
        }

        private void FillDGV()
        {
            grid.Rows.Clear();

            for (int i = 0; i < this.FilteredContacts.Length; i++)
            {
                grid.Rows.Add();
                grid["Phone", i].Value = this.FilteredContacts[i].Phone;
                grid["Address", i].Value = this.FilteredContacts[i].Adress;

                try
                {
                    grid["LastName", i].Value = ((Person)this.FilteredContacts[i]).LastName;
                }
                catch (InvalidCastException) { }
                try
                {
                    grid["Birthday", i].Value = ((Friend)this.FilteredContacts[i]).Birthday.ToString().Split(' ')[0];
                }
                catch (InvalidCastException) { }
                try
                {
                    grid["Birthday", i].Value = ((Friend)this.FilteredContacts[i]).Birthday.ToString().Split(' ')[0];
                }
                catch (InvalidCastException) { }
                try
                {
                    grid["Fax", i].Value = ((Organization)this.FilteredContacts[i]).Fax;
                }
                catch (InvalidCastException) { }
                try
                {
                    grid["Name", i].Value = ((Organization)this.FilteredContacts[i]).Name;
                }
                catch (InvalidCastException) { }
                try
                {
                    grid["ContactPerson", i].Value = ((Organization)this.FilteredContacts[i]).ContactPerson;
                }
                catch (InvalidCastException) { }
            }
        }

        static Contact[] ParseContacts(string bufData)
        {
            MatchCollection persons = Regex.Matches(bufData, "<Person>(.*?)</Person>");
            MatchCollection friends = Regex.Matches(bufData, "<Friend>(.*?)</Friend>");
            MatchCollection organizations = Regex.Matches(bufData, "<Organization>(.*?)</Organization>");
            int arraySize = persons.Count + friends.Count + organizations.Count;
            Contact[] contacts = new Contact[arraySize];
            int contactsIndex = 0;
            foreach (Match p in persons)
            {
                contacts[contactsIndex] = new Person(
                    Regex.Match(p.Value, "<LastName>(.*?)</LastName>").Groups[1].Value,
                    Regex.Match(p.Value, "<Phone>(.*?)</Phone>").Groups[1].Value,
                    Regex.Match(p.Value, "<Adress>(.*?)</Adress>").Groups[1].Value
                );
                contactsIndex++;
            }
            foreach (Match f in friends)
            {
                contacts[contactsIndex] = new Friend(
                    Regex.Match(f.Value, "<LastName>(.*?)</LastName>").Groups[1].Value,
                    Regex.Match(f.Value, "<Phone>(.*?)</Phone>").Groups[1].Value,
                    Regex.Match(f.Value, "<Adress>(.*?)</Adress>").Groups[1].Value,
                    ParseDate(Regex.Match(f.Value, "<Birthday>(.*?)</Birthday>").Groups[1].Value)
                );
                contactsIndex++;
            }
            foreach (Match o in organizations)
            {
                contacts[contactsIndex] = new Organization(
                    Regex.Match(o.Value, "<Name>(.*?)</Name>").Groups[1].Value,
                    Regex.Match(o.Value, "<Phone>(.*?)</Phone>").Groups[1].Value,
                    Regex.Match(o.Value, "<Fax>(.*?)</Fax>").Groups[1].Value,
                    Regex.Match(o.Value, "<ContactPerson>(.*?)</ContactPerson>").Groups[1].Value,
                    Regex.Match(o.Value, "<Adress>(.*?)</Adress>").Groups[1].Value
                );
                contactsIndex++;
            }
            return contacts;
        }

        static Contact[] FindByLastName(string lastName, Contact[] contacts)
        {
            List<Contact> matches = new List<Contact>();
            foreach (Contact c in contacts)
            {
                try
                {
                    Person p = (Person)c;
                    if (p.LastName.ToLower().Trim() == lastName.ToLower().Trim())
                        matches.Add(p);
                }
                catch (Exception ex) { }
            }
            return matches.ToArray();
        }

        static DateTime ParseDate(string s)
        {
            return DateTime.Parse(s);
        }

        static void ContactsOutput(Contact[] contacts)
        {
            foreach (Contact c in contacts)
            {
                c.Output();
                Console.WriteLine();
            }
        }

        abstract class Contact
        {
            public string Phone;
            public string Adress;
            public Contact(string Phone, string Adress)
            {
                this.Phone = Phone;
                this.Adress = Adress;
            }
            public void Output()
            {
                Console.WriteLine(this.ToString());
            }
        }

        class Person : Contact
        {
            public string LastName;
            public Person(string LastName, string Phone, string Adress)
                : base(Phone, Adress)
            {
                this.LastName = LastName;
            }
            public override string ToString()
            {
                return String.Format(
                    "Фамилия: {0}\nТелефон: {1}\nАдрес: {2}", this.LastName, this.Phone, this.Adress);
            }
        }

        class Friend : Person
        {
            public DateTime Birthday;
            public Friend(string LastName, string Phone, string Adress, DateTime Birthday)
                : base(LastName, Phone, Adress)
            {
                this.Birthday = Birthday;
            }
            public override string ToString()
            {
                return String.Format(
                    "Фамилия: {0}\nТелефон: {1}\nАдрес: {2}\nДата рождения: {3}", this.LastName, this.Phone, this.Adress, this.Birthday.ToString().Split(' ')[0]);
            }
        }

        class Organization : Contact
        {
            public string Name;
            public string Fax;
            public string ContactPerson;
            public Organization(string Name, string Phone, string Fax, string ContactPerson, string Adress)
                : base(Phone, Adress)
            {
                this.Name = Name;
                this.Fax = Fax;
                this.ContactPerson = ContactPerson;
            }
            public override string ToString()
            {
                return String.Format(
                    "Название: {0}\n" + "Телефон: {1}\n" + "Факс: {2}\n" + "Контактное лицо: {3}\n" + "Адрес: {4}",
                    this.Name, this.Phone, this.Fax, this.ContactPerson, this.Adress);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.FilteredContacts = FindByLastName(searchLM.Text, this.Contacts);
            FillDGV();
        }

        
    }

}
