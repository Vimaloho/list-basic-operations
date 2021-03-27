using System;

namespace Directorio
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactList contactList = new ContactList();

            Contact contact1 = new Contact();
            contact1.Nombre = "Juan";
            contact1.Numero = 314134134;
            contactList.Add(contact1);

            Contact contact2 = new Contact();
            contact2.Nombre = "carlos";
            contact2.Numero = 234234;
            contactList.Add(contact2);

            Contact contact3 = new Contact();
            contact3.Nombre = "sol";
            contact3.Numero = 2345234;
            contactList.Add(contact3);

            Contact contact4 = new Contact();
            contact4.Nombre = "jose";
            contact4.Numero = 12341;
            contactList.Insert(4);

          
            
            contactList.Print();



        }
    }
}
