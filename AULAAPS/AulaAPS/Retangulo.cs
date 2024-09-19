namespace AulaAPS
{
    internal class Retangulo : FormaGeometrica
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
            return _base * altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (_base + altura);
        }

        public override string ToString()
        {
            return $"Retângulo (Base: {_base}, Altura: {altura})";
        }
    }
}
