using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaFormas
{
    public class Circunferencia : FormaGeometrica
    {
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public override double CalcularArea()
        {
            return Math.PI * raio * raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }

        public override string ToString()
        {
            return $"Circunferência ({raio})";
        }
    }
}
