using System;
using System.Collections;

namespace ProfessionalLesson2Task1
{

    //    Используя класс SortedList, создайте небольшую коллекцию и выведите на экран значения пар
    //«ключ- значение» сначала в алфавитном порядке, а затем в обратном.

    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            SortedList slDes;

            for (int i = 0; i < 10; i++)
                sl.Add(i, $"Value {i}");

            slDes = new SortedList(sl, new DescenidngComparer());

            foreach (DictionaryEntry item in sl)
                Console.WriteLine(item.Key + " " + item.Value);

            Console.WriteLine(new string('-', 20));

            foreach (DictionaryEntry item in slDes)
                Console.WriteLine(item.Key + " " + item.Value);

        }
    }

}
