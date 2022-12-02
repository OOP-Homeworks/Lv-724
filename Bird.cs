using System;
namespace Task_5
{
    public class Bird : IFlyable
    {
        private string _name;
        private bool _canFly;

        public Bird(string name, bool canFly)
        {
            _name = name;
            _canFly = canFly;

            //  this._name = name;
            //  this._canFly = canFly;
       }

         public string Fly() => $"{_name} can fly? {_canFly}";
    }
}
