using Separator;
using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSeparator consoleSeparator = new ConsoleSeparator('_', 50);
            SeparateEvent separateEvent = new SeparateEvent();
            separateEvent.OnSeparate += consoleSeparator.Separator;

            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(3);
            numbers.Enqueue(5);
            numbers.Enqueue(8);
            var queueElement = numbers.Dequeue();
            Console.WriteLine(queueElement);
            separateEvent.Display();

            Queue<Person> person = new Queue<Person>();
            person.Enqueue(new Person() { Name = "Tom" });
            person.Enqueue(new Person() { Name = "Bill" });
            person.Enqueue(new Person() { Name = "John" });
            var p = person.Peek();
            Console.WriteLine(p.Name);
            separateEvent.Display();
            foreach(Person x in person)
            {
                Console.WriteLine(x.Name);
            }
            separateEvent.Display();

            p = person.Dequeue();
            Console.WriteLine(p.Name);
            separateEvent.Display();
            foreach(Person x in person)
            {
                Console.WriteLine(x.Name);
            }
            Console.ReadKey();


        }
    }
}
