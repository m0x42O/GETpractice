using System;
namespace ex1_1
{
    abstract class Contact
    {
        public string Phone;
        public string Adress;

        public Contact(string Phone, string Adress)
        {
            this.Phone = Phone;
            this.Adress = Adress;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
