using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv__Lab_6
{
    internal class Tiger : Lion
    {
        private int stealthLevel { get; set; } = 0;

        public Tiger(string Color, string FoodVores, string Size, bool IsMammal, int Age, string name, int StealthLevel) : base(Color, FoodVores, Size, IsMammal, Age, name)
        {
            stealthLevel = StealthLevel;

        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            
        }

        public override bool Dangerous(bool v)
        {
            return base.Dangerous(v);
        }

        public override string MakeSound(string v)
        {
             return base.MakeSound(v);
        }

        public int StealthLevel(int v)
        {
            Console.WriteLine($"Tiger har Stealth Level: {v}");
            return v;
        }
    }
}
