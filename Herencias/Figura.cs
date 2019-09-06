using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    abstract class Figura
    {
        public string Color { get; set; }
        //todas las fiuras deben ser capaces de calcular area
        public abstract double calcularArea();
        public string toString()
        {
            return "Soy una figura:" + Color;
        }
    }
}
