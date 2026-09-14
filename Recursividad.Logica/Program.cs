using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad.Logica
{
    public class Recursividades
    {
        public Recursividades()
        {
            
        }
        public int CalcularFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
                return num * CalcularFactorial(num - 1);
        }
    }
}
