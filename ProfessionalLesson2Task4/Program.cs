using System;
using System.Collections;
using System.Collections.Specialized;

namespace ProfessionalLesson2Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            CarEqualityComparer cec = new CarEqualityComparer();
            OrderedDictionary OrDic = new OrderedDictionary(cec);

            Car car1 = new Car(2001, "Red");
            Car car2 = new Car(2001, "Red");
            Car car3 = new Car(2005, "Blue");

            OrDic.Add(car1, car1.Color);
            OrDic.Add(car2, car1.Color);
            OrDic.Add(car3, car1.Color);

            foreach (DictionaryEntry item in OrDic)
                Console.WriteLine("Key: " + item.Key + " - Value: " + item.Value);
        }
    }

    class CarEqualityComparer : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;

            Car car1 = x as Car;
            Car car2 = y as Car;

            if (car1.Color == car2.Color && car1.Year == car2.Year)
                return true;
            else
                return false;
        }

        public int GetHashCode(object obj)
        {
            Car car = obj as Car;
            int hash = car.Color.GetHashCode() * car.Year.GetHashCode() + 254;
            return hash.GetHashCode();
        }
    }
}