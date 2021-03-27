using System;
namespace Directorio
{
    public class ContactList
    {
        ContactNode Head;

        public void Add ( Contact contactToAdd)
        {
            ContactNode newContactNode = new  ContactNode();
            newContactNode.Contact = contactToAdd;

            if (Head == null)
            {
                Head = newContactNode;
                
            }
            else
            {
                ContactNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }

                last.Next = newContactNode;

            }
        }


        public void Insert (int n, Contact contactInsert)
        {

            ContactNode insertcontact = new ContactNode();
            insertcontact.Contact = contactInsert;

            if (Head ==null) 
            {
                Head = insertcontact; 
            }
            else
            {
                ContactNode puntero = Head;
                int contador = 0;
                while (contador <n && puntero.Next != null)
                {
                    puntero = puntero.Next;
                    contador++;
                }
                insertcontact.Next = puntero.Next;
                puntero.Next = insertcontact;
            }


        }


        public void Print()
        {
            ContactNode tmp = Head;
            while (tmp != null)
            {
                Console.WriteLine($"Nombre:{tmp.Contact.Nombre} -Numero : {tmp.Contact.Numero}");
                tmp = tmp.Next;
            }
        }
    }
}
