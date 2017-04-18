using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: CLSCompliant(true)]
namespace JenkinsConsole
{
    public class Program
    {
        static void Main()
        {
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Division(float a, float b)
        {
            return (float)(a / b);
        }

        public int Soustraction(int a, int b)
        {
            return a - b;
        }
    }
}
