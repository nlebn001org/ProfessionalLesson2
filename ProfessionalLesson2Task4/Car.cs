using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalLesson2Task4
{
    class Car
    {
        int year;
        string color;
        public int Year { get => year; set => year = value; }
        public string Color { get => color; set => color = value; }

        public Car(int year, string color)
        {
            this.year = year;
            this.color = color;
        }

        public override string ToString()
        {
            return $"Year: {year}, Color: {color}";
        }
    }
}
