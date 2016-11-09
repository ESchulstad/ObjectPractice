using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randy = new Random();
            

            for(int i = 0; i < 10; i++ )
            {
                int newSurprise = randy.Next(101);
                Console.WriteLine(newSurprise + 100);

            }
        }
    }
}
