using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv__Lab_6
{
    abstract class Animal
    {
        //5 egenskaper
        private string color { get; set; } = "unknown";
        private string foodVores{ get; set; } = "unknown";
        private string size { get; set; } = "unknown";
        private bool isMammal { get; set; } = false;
        private int age { get; set; } = 0;

        //Constructor
        public Animal(string Color, string FoodVores, string Size, bool IsMammal, int Age)
        {
            color = Color;
            foodVores = FoodVores;
            size = Size;
            isMammal = IsMammal;
            age = Age;
        }
        // 3 metoder
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"färg: {color}, matpreferens: {foodVores}, storlek: {size}, Är mammal: {isMammal}, Ålder: {age}");
        }

        public virtual bool Dangerous(bool v)
        {
            bool IsDangerous = true;
            Console.WriteLine($"Djuret är farlig för oss: {IsDangerous}");
            return IsDangerous;
        }
        public virtual string MakeSound(string v)
        {
           
            Console.WriteLine(v);
            return v;
            
        }
    }

}
