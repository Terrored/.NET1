using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET1
{

    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public bool CanGoForBeer;

        public Person(string Name, string Surname, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            CanDrink();
            
        }

        public void WhoAreYou()
        {
            Console.WriteLine("Nazywam się " + Name + " " + Surname+".");
            Console.WriteLine("Mam lat " + Age);
            if (CanGoForBeer)
            {
                Console.WriteLine("Może iść na piwo");

            }
            else Console.WriteLine("Nie może iść na piwo");

        }

        public void CanDrink()
        {
            if (Age>=18)
            {
                CanGoForBeer = true;
            }
            else
            {
                CanGoForBeer = false;
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Janusz","Tracz",54);
            //person1.Name = "Janusz";
            //person1.Surname = "Tracz";
            //person1.Age = 54;                 // komentowanie grupowe ctrl + k + c , ctrl + k + u 

            // person1.WhoAreYou();

            Order order1 = new Order();
            Dish dish1 = new Dish("Kiełbasa po Węgiersku", 7.99);
            Dish dish2 = new Dish("Pierogi", 14.99);
            Dish dish3 = new Dish("Bigos", 21.99);
            order1.OrderList.Add(dish1);
            order1.OrderList.Add(dish2);
            order1.OrderList.Add(dish3);

            foreach (var dish in order1.OrderList)
            {
                Console.WriteLine(dish.Name);
                Console.WriteLine(dish.Price);

            }

            order1.CalculateToPay();
            Console.WriteLine(order1.ToPay);

            Console.ReadKey();
            

        }
    }
}
