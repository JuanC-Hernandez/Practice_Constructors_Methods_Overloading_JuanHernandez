using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Constructors_Methods_Overloading_JuanHernandez
{
    public class Car
    {
        // Variables
        string _make;
        string _model;
        int _year;
        int _mileage;
        
        // Properties
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }

        public Car() // default constructor
        {
            Make = "unassigned";
            Model = "unassigned";
            Year = 0;
            Mileage = 0;
        }
        public Car(string make, string model) // constructor: takes 2 variables
        {
            Make = make;    
            Model = model;  
            Year = 0;
            Mileage = 0;
        }
        public Car(string make, string model, int year, int mileage) // constructor: tales 4 variables
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }
        public override string ToString()
        {
            return $"{Year} {Make} {Model} - {Mileage}";
        }
    }
}
