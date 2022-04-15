using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    struct LeanerEquation
    {
        double k;
        double b;

        public LeanerEquation (double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            if (k == 0 && b == 0)
            {
                return "Решением является любое число";
            }
                
            else if (k == 0)
            {

                return "Уравнение не имеет решения!";
            }
             else
            {
                double x = -b / k;
                return $"x = {x}";
            }
        }
    }
}
