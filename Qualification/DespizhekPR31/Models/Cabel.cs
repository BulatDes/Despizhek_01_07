using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DespizhekPR31.Models
{
    public class Cabel
    {
        public string Type { get; set; }
        public int QuantityCores { get; set; }
        public double Diameter { get; set; }
        
        //Конструктор класса наследника
        public Cabel(string type, int quantity, double diameter)
        {
            Type = type;
            QuantityCores = quantity;
            Diameter = diameter;
        }

        //Функция базового класса
        public virtual double Q()
        {
            return Diameter / QuantityCores;
        }
        //Функция базового класса
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Type: {Type}, QuantityCores: {QuantityCores}, Diameter: {Diameter}, Q: {Math.Round(Q(),2)}");
        }
    }
}
