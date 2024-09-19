using System;

namespace WfaFormas
{
    public class TI : Triangulo
    {
        public override double CalcularArea()
        {
            return Altura * Base / 2;
        }

        public override double CalcularPerimetro()
        {
            return Base + 2 * Math.Sqrt((Base/2) * (Base/2) + Altura * Altura);
        }

        public override string ToString()
        {
            return $"Triângulo Isósceles ({Base};{Altura})";
        }
    }
}
