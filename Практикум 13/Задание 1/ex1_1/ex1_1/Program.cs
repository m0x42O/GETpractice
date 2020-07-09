using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace ex1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "contacts.xml";
            string bufData = File.ReadAllText(filepath).Replace('\n', ' ');
            Contact[] contacts = ParseContacts(bufData);
            ContactsOutput(contacts);
            Console.Write("Поиск по фамилии: ");
            string request = Console.ReadLine();
            Contact[] searchResults = FindByLastName(request, contacts);
            Console.WriteLine("Всего найдено: {0}\n", searchResults.Length);
            ContactsOutput(searchResults);
            Console.ReadKey();
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
    }
}
