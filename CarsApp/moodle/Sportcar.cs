using System;
using System.Collections.Generic;
using System.Text;

namespace CarsApp.moodle
{
    class Sportcar : Car
    {
        public Sportcar(string name, string brand, int constructionYear, string color) : base(name, brand, constructionYear, color)
        {
            Type = CarTypes.Sportcar;
        }

        public override string ToString()
        {
            string back = $"{Name} {Type} {Brand} {ConstructionYear} {Color}";
            return back;
        }
    }
}
