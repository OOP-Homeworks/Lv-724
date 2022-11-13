﻿namespace Task_4
{
    public class Car
    {
        public const string CompanyName = "Subaru";
        private string _name;
        private string _color;
        private double _price;

        public Car()
        {

        }

        public Car(string name, string color, double price)
        {
            _name = name;
            _color = color;
            _price = price;
        }

        public string Color 
        {
            get => _color;
            set => _color = value;
        }

        public string Print() => $"This is a {_name}, its color is {_color} and its price is {_price}";

        public double ChangePrice(double percentage) => _price *= percentage;
    }
}