using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        private int[] array = { 1, 5, 9, 11, 25, 8, 9 };
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index <= array.Length)
                    return array[index];
                else throw 
                        new ArgumentOutOfRangeException("Argument is bigger than arrays lenght");
            }
        }
        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.WriteLine(prog[5]);
            Console.Read();

        }
    }
}
