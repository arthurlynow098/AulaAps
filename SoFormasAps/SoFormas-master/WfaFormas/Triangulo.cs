namespace WfaFormas
{
    public abstract class Triangulo : FormaGeometrica
    {
		private double altura;

		public double Altura
		{
			get { return altura; }
			set { altura = value; }
		}

		private double _base;

		public double Base
		{
			get { return _base; }
			set { _base = value; }
		}

		private double lado;

		public double Lado
		{
			get { return lado; }
			set { lado = value; }
		}

	}
}
