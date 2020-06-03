using System;
using System.Collections.Generic;
using System.Text;

namespace CarsApp.moodle
{
    class Car
    {   
        public string Name { get; set; }
        public CarTypes Type { get; set; }
        public string Brand { get; set; }
        public int ConstructionYear { get; set; }
        public string Color { get; set; }

        public Car(string name, CarTypes type, string brand, int constructionYear, string color)
        {
            Name = name;
            Type = type;
            Brand = brand;
            ConstructionYear = constructionYear;
            Color = color;
        }

        public override string ToString()
        {
            string back = $"{Name} {Type} {Brand} {ConstructionYear} {Color}";
            return back;
        }
    }
}
