using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProfessionalLesson2Task2
{
    //    Задание 2
    //Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими
    //продукции.Из коллекции можно получать категории товаров, которые купил покупатель или по
    //категории определить покупателей.

    class Program
    {
        static void Main(string[] args)
        {
            List<(string category, string customer)> list = new List<(string category, string customer)>(); // works faster than other tested Collections 
            Dictionary<string, string> d = new Dictionary<string, string>();
            Hashtable hs = new Hashtable();
            ArrayList arl = new ArrayList();
            Stopwatch st = new Stopwatch();

            #region TEST 
            //st.Start(); 
            //for (int i = 0; i < 1000000; i++) 
            //{ 
            //    hs.Add($"Tea{i}", "Customer1"); 
            //    //list.Add(("Tea", "Customer2")); 
            //    hs.Add($"Coffee{i}", "Customer1"); 
            //    //list.Add(("Coffee", "Customer3")); 

            //} 
            //st.Stop(); 
            //Console.WriteLine(st.ElapsedTicks); 

            //st.Restart(); 

            //st.Start(); 
            //for (int i = 0; i < 1000000; i++) 
            //{ 
            //    arl.Add(($"Tea{i}", "Customer1")); 
            //    //list.Add(("Tea", "Customer2")); 
            //    arl.Add(($"Coffee{i}", "Customer1")); 
            //    //list.Add(("Coffee", "Customer3")); 

            //} 
            //st.Stop(); 
            //Console.WriteLine(st.ElapsedTicks); 

            //st.Restart(); 

            //st.Start(); 
            //for (int i = 0; i < 1000000; i++) 
            //{ 
            //    list.Add(($"Tea{i}", "Customer1")); 
            //    //list.Add(("Tea", "Customer2")); 
            //    list.Add(($"Coffee{i}", "Customer1")); 
            //    //list.Add(("Coffee", "Customer3")); 

            //} 
            //st.Stop(); 
            //Console.WriteLine(st.ElapsedTicks); 

            //st.Restart(); 


            //st.Start(); 
            //for (int i = 0; i < 1000000; i++) 
            //{ 
            //    d.Add($"Tea{i}", "Customer1"); 
            //    //d.Add($"Tea{i}", "Customer2"); 
            //    //d.Add($"Coffee{i}", "Customer1"); 
            //    d.Add($"Coffee{i}", "Customer3"); 
            //} 
            //st.Stop(); 
            //Console.WriteLine(st.ElapsedTicks); 
            #endregion

            for (int i = 0; i < 5; i++)
            {
                list.Add(($"Tea{i}", "Customer1"));
                list.Add(($"Tea{i}", "Customer2"));
                list.Add(($"Coffee{i}", "Customer1"));
            }

            foreach (var item in list)
                Console.WriteLine($"{item.category} was bought by {item.customer}.");

            var teaBuyers = from item in list
                            where item.category.StartsWith("Tea")
                            select new { Customer = item.customer, Category = item.category };

            Console.WriteLine(new string('-', 20));

            foreach (var item in teaBuyers)
                Console.WriteLine($"{item.Category} was bought by {item.Customer}");
        }
    }
}
