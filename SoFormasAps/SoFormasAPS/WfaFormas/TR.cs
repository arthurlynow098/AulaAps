using System;

namespace WfaFormas
{
    public class TR : Triangulo
    {
        public override double CalcularArea()
        {
            return Altura * Base / 2;
        }

        public override double CalcularPerimetro()
        {
            return Altura + Base + Math.Sqrt(Altura * Altura + Base * Base);
        }

        public override string ToString()
        {
            return $"Triângulo Reto ({Base};{Altura})";
        }
    }
}
