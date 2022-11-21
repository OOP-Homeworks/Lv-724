using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
           Dictionary<int,string> dic = new Dictionary<int,string>();
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Enter id of person = ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name of person - ");
                string name = Console.ReadLine();
                dic.Add(id, name);
            }
            Console.Write("Enter the id of person that wanted - ");
            int find = Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<int, string> kvp in dic)
            {
                
                if (find == kvp.Key)
                {
                    
                    Console.WriteLine("The Name of Person whis this id is -  {0}", kvp.Value);
                }
                else
                {
                    cont++;
                }
            }
            if (cont==7)
            {
                Console.WriteLine("We haven`t person with this id:{0}",find);
            }



        }
    }
}
