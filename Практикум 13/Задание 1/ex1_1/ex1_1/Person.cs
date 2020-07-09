using System;
namespace Person
{
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
                "Фамилия: {0}\nТелефон: {1}\nАдрес: {2}", this.LastName, this.PhoneNumber, this.Adress);
        }
    }
}