using System;

namespace AulaAPS
{
    public class Triangulo : FormaGeometrica
    {
        public virtual double CalcularArea() => 0;
        public virtual double CalcularPerimetro() => 0;
    }

    public class TrianguloEquilatero : Triangulo
    {
        private double _base;
        public double Base
        {
            get => _base;
            set => _base = value;
        }

        public override double CalcularArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(_base, 2);
        }

        public override double CalcularPerimetro()
        {
            return 3 * _base;
        }

        public override string ToString()
        {
            return $"Triângulo Equilátero (Base: {_base})";
        }
    }

    public abstract class FormaGeometrica
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}
