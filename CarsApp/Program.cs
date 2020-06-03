using CarsApp.moodle;
using System;
using System.Collections.Generic;

namespace CarsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            bool run = true;
            while (run)
            {
                Write("Was möchten sie machen?(1 = Auto eingeben, 2 = zeig alle Autos, 3 = Beenden )");
                int select = ReadInt();
                if (select == 2)
                {
                    foreach (Car oneCar in cars)
                    {
                        Console.WriteLine(oneCar.ToString());
                        run = false;
                        break;
                    }
                }
                Write("Welchen Autotyp wünschen Sie?(1 = Sportauto, 2 = Standardauto)Bitte Zahl eingeben:");
                int type = ReadInt();
                CarTypes carType = CarTypes.Normalcar;
                if (type == 1)
                {
                    carType = CarTypes.Sportcar;
                }
                Write("Welchen Name hat das Auto?");
                string carName = Read();
                Write("Welchen Hersteller hat das Auto?");
                string carBrand = Read();
                Write("Welches Baujahr hat das Auto?");
                int carConstructionYear = ReadInt();
                Write("Welche Farbe hat das Auto?");
                string carColor = Read();
                Write("Ihr Auto:" + carType + " " + carName + " " + carBrand + " " + carConstructionYear + " " + carColor);
                if (type == 1)
                {
                    Sportcar sportcar = new Sportcar(carName, carBrand, carConstructionYear, carColor);
                    cars.Add(sportcar);
                }
                else if (type == 2)
                {
                    Car car = new Car(carName, carBrand, carConstructionYear, carColor);
                    cars.Add(car);
                }
                
            }

            Console.ReadKey();
        }

        public static void Write(string text)
        {
            Console.WriteLine(text);
        }

        public static string Read()
        {
            string answer = Console.ReadLine();
            return answer;
        }

        public static int ReadInt()
        {
            string answer = Console.ReadLine();
            int finish = 0;
            int.TryParse(answer, out finish);
            return finish;
        }
    }
}
