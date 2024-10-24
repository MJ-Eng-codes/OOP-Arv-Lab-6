using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Arv__Lab_6
{
    internal class Cat : Lion
    {
        private bool longHair { get; set; } = true;
        public Cat(string Color, string FoodVores, string Size, bool IsMammal, int Age, string name, bool LongHair) : base(Color, FoodVores, Size, IsMammal, Age, name)
        {
            longHair = LongHair;
        }

        public override void DisplayInfo()
        {
           base.DisplayInfo();
            
        }

        public override bool Dangerous(bool v)
        {
            return base.Dangerous(v);
            Console.WriteLine("Extremt farligt!");
        }

        public override string MakeSound(string v)
        {
             return base.MakeSound(v);
        }

        public bool LongHaired (bool v)
        {
            Console.WriteLine($"Katten har långt päls: {v}");
            return v;
        }
    }
}
