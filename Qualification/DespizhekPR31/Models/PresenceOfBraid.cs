using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespizhekPR31.Models
{
    public class PresenceOfBraid : Cabel
    {
        //Поле дочернего класса
        public bool Availability { get; set; }

        //Конструктор дочернего класса
        public PresenceOfBraid(string type, int quantity, double diameter, bool availability) : base(type, quantity, diameter)
        {
            Availability = availability;
        }


        //Переопределение функции из класса наследника
        public override double Q()
        {
            if (Availability)
            {
                return 2.1 * base.Q();
            }
            else
            {
                return 0.7 * base.Q();
            }
        }

        //Переопределение функции из класса наследника
        public override void PrintInfo()
        {
            Console.WriteLine($"Type: {Type}, QuantityCores: {QuantityCores}, Diameter: {Diameter}, Q: {Math.Round(Q(), 2)}, Availability: {Availability}");
        }

    }
}
