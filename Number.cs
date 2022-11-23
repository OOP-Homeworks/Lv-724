using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_06_tast_06
{
    internal class Number: INomer
    {
        private int num;

        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public  Number(int a)
        {
            this.num = a;
        }

        public void ToString()
        {
            Console.WriteLine("{0}", num);
        }
    }
}
