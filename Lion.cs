using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv__Lab_6
{
    internal class Lion : Animal
    {
        private string name = "unknown";
        public Lion(string Color, string FoodVores, string Size, bool IsMammal, int Age, string name) : base(Color, FoodVores, Size, IsMammal, Age)
        {
            this.name = name;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Den heter {name}");
            base.DisplayInfo();
        }

        public override bool Dangerous(bool v)
        {
            return base.Dangerous(true);
        }

        public override string MakeSound(string v)
        {
            Console.Write("Den gör ljudet:");
            return base.MakeSound(v);
        }

    }
}
