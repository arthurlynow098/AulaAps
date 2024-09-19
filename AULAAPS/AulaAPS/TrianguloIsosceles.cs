using System;

namespace AulaAPS
{
    public class Triangulo : FormaGeometrica
    {
        public virtual double CalcularArea() => 0;
        public virtual double CalcularPerimetro() => 0;
    }

    public class TrianguloIsosceles : Triangulo
    {
        private double _base;
        public double Base
        {
            get => _base;
            set => _base = value;
        }

        private double altura;
        public double Altura
        {
            get => altura;
            set => altura = value;
        }

        public override double CalcularArea()
        {
            return (_base * altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            double hipotenusa = Math.Sqrt(Math.Pow(_base / 2, 2) + Math.Pow(altura, 2));
            return _base + (hipotenusa * 2);
        }

        public override string ToString()
        {
            return $"Triângulo Isósceles (Base: {_base}, Altura: {altura})";
        }
    }

    public abstract class FormaGeometrica
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}
