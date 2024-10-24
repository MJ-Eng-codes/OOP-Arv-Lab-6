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
        public Cat(string Color, string FoodVores, string Size, bool IsMammal, int Age, string name) : base(Color, FoodVores, Size, IsMammal, Age, name)
        {
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
    }
}
