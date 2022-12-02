using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Plane : IFlyable
    {
        private string _mark;
        private int _highFly;

        public Plane(string mark, int highFly)
        {
            _mark = mark;
            _highFly = highFly;

            //  this._mark = mark;
            //  this._highFly = highFly;
        }

        public string Fly() => $"{_mark} can fly {_highFly}";
    }
}