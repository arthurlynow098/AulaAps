using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaFormas
{
    public class Retangulo : FormaGeometrica
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public override double CalcularArea()
        {
            return A * B;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (A + B);
        }

        public override string ToString()
        {
            return $"Retângulo ({B};{A})";
        }
    }
}
