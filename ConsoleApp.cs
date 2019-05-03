using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SieveofEratosthenes Engine = new SieveofEratosthenes(121);
            Engine.InitializeSieve();
            foreach(var a in Engine.ListPrimeNumber)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
    }
    }
    public class SieveofEratosthenes
    {
        private bool[]ListPrimeNumbersBool { get;  set; }
        public List<int> ListPrimeNumber { get; private set; }
        private int MaximumValue { get; set; }
        public SieveofEratosthenes(int Max)
        {
            this.MaximumValue = Max;
            this.ListPrimeNumber = new List<int>();
            this.ListPrimeNumbersBool = new bool[Max + 1];
        }
        public void InitializeSieve()
        {
            for (int i = 2; i <= this.MaximumValue; i++)
                ListPrimeNumbersBool[i] = true;
            for (int i = 2; i <= this.MaximumValue; i++)
            {
                if (ListPrimeNumbersBool[i])
                {
                    for (int j = i * 2; j <= this.MaximumValue; j += i)
                        ListPrimeNumbersBool[j] = false;
                }
            }
            int max = this.MaximumValue + 1;
            for (int i = 2; i < max; i++)
                if (ListPrimeNumbersBool[i]) ListPrimeNumber.Add(i);
        }
    }
}
