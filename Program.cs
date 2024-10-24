using System.Xml.Linq;

namespace OOP_Arv__Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion("beige", "carnivore", "Stor", true, 10, "In the Jungle");
            Console.WriteLine($"Djuret är Lejon.");
            lion.DisplayInfo();
            lion.Dangerous(true);
            lion.MakeSound("Roar!!");

            Tiger tiger = new Tiger("Striped", "carnivore", "Stor", true, 15, "Leopard",200);
            Console.WriteLine($"Djuret är Tiger.");
            tiger.DisplayInfo();
            tiger.Dangerous(true);
            tiger.MakeSound("Roar!!");
            tiger.StealthLevel(100);

            Cat cat= new Cat("Calico", "obligate carnivore", "Small but mighty", true, 5, "Lion",true);
            Console.WriteLine($"Djuret är Katt.");
            cat.DisplayInfo();
            cat.Dangerous(true);
            cat.MakeSound("Mmeoww");
            cat.LongHaired(false);

           
        }
    }


}
