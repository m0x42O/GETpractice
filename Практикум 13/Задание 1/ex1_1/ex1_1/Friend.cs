using System;
namespace ex1_1
{
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
}
