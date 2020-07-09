using System;
namespace ex1_1
{
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
                this.Name, this.PhoneNumber, this.FaxNumber, this.ContactPerson, this.Adress);
        }
    }
}
