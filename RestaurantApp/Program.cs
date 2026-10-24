using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TIT.1/1");
            List<Restaurant> restaurants = new List<Restaurant>
        {
           new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
           new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
           new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
           new Restaurant(4, "Salapao aud aud", "Mu dang", 4.8),
           new Restaurant(5, "Auau store", "bag pack", 4.9)
        };
            foreach (var item in restaurants)
            {
                Console.WriteLine($"{item.Id}. {item.Name} ({item.Thype}) - poine; {item.point}");

            }
        }
        public class Restaurant
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Thype { get; set; }
            public double point { get; set; }

            public Restaurant(int id, string name, string thype, double point)
            {
                this.Id = id;
                this.Name = name;
                this.Thype = thype;
                this.point = point;
            }
        }
    }
}



