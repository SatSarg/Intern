using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer1
    {
    class Program
    {
        //public Program(int)
        private int[] array= { 3, 5, 20, 36, 41 };
        public int this[int index]
        {
         get
            {
                if (index >= 0 && index <= array.Length)
                    return array[index];
                else throw new ArgumentOutOfRangeException();
            }
            set
            {
                array[index] = value;
            }
        }
        static void Main(string[] args)
        {
            //int size = 6;
            Program prog = new Program();
            Console.WriteLine(prog[3]);
            prog[3] = 5;
            Console.WriteLine(prog[3]);
            Console.Read();
        }
    }
}
