using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<ContactExtended>();

            // добавляем контакты
            phoneBook.Add(new ContactExtended("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new ContactExtended("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new ContactExtended("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new ContactExtended("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new ContactExtended("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new ContactExtended("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            while (true)
            {
                var input = (Console.ReadKey().KeyChar);
                var parsed = Int32.TryParse(input.ToString(), out int pageNumber);
                Thread.Sleep(1000);
                Console.Clear();

                var phoneBookSorted = phoneBook.OrderBy(c => c.Name).ThenBy(c => c.LastName);
                
                foreach (var person in phoneBookSorted.Skip((pageNumber - 1) * 2).Take(2))
                {
                    Console.WriteLine("Имя: " + person.Name);
                    Console.WriteLine("Фамилия: " + person.LastName);
                    Console.WriteLine("Контактный телефон: " + person.PhoneNumber);
                    Console.WriteLine();
                }
            }
        }

    }
}
