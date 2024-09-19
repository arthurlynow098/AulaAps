using System;
using System.Windows.Forms;

namespace AulaAPS
{
    public partial class Form1 : Form
    {
        private IFormaGeometrica formaSelecionada;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarFormulario();
        }

        private void AtualizarFormulario()
        {
            string forma = cmbForma.SelectedItem.ToString();
            formaSelecionada = FormaFactory.CriarForma(forma);
            ExibirCampos(formaSelecionada);
        }

        private void ExibirCampos(IFormaGeometrica forma)
        {
            lblBase.Visible = forma.NecessitaBase;
            txtBase.Visible = forma.NecessitaBase;
            lblAltura.Visible = forma.NecessitaAltura;
            txtAltura.Visible = forma.NecessitaAltura;
            lblRaio.Visible = forma.NecessitaRaio;
            txtRaio.Visible = forma.NecessitaRaio;
            cmbTriangulo.Visible = forma is Triangulo;

            if (forma is Triangulo triangulo)
            {
                cmbTriangulo.DataSource = triangulo.Tipos;
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (formaSelecionada != null)
            {
                try
                {
                    formaSelecionada.DefinirDimensoes(
                        Convert.ToDouble(txtBase.Text),
                        Convert.ToDouble(txtAltura.Text),
                        Convert.ToDouble(txtRaio.Text)
                    );
                    cmbObjetos.Items.Add(formaSelecionada);
                    limpaCampos();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, insira valores válidos nos campos.");
                }
            }
        }

        private void limpaCampos()
        {
            txtBase.Clear();
            txtAltura.Clear();
            txtRaio.Clear();
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbObjetos.SelectedItem is IFormaGeometrica forma)
            {
                txtArea.Text = forma.CalcularArea().ToString("F2");
                txtPerimetro.Text = forma.CalcularPerimetro().ToString("F2");
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1042, 519);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public static class FormaFactory
    {
        public static IFormaGeometrica CriarForma(string forma)
        {
            return forma switch
            {
                "Quadrado" => new Quadrado(),
                "Retângulo" => new Retangulo(),
                "Circunferência" => new Circunferencia(),
                "Triângulo" => new Triangulo(),
                _ => null,
            };
        }
    }

    public interface IFormaGeometrica
    {
        bool NecessitaBase { get; }
        bool NecessitaAltura { get; }
        bool NecessitaRaio { get; }
        void DefinirDimensoes(double baseValue, double altura, double raio);
        double CalcularArea();
        double CalcularPerimetro();
    }

    public class Quadrado : IFormaGeometrica
    {
        public double Lado { get; set; }

        public bool NecessitaBase => true;
        public bool NecessitaAltura => false;
        public bool NecessitaRaio => false;

        public void DefinirDimensoes(double baseValue, double altura, double raio)
        {
            Lado = baseValue;
        }

        public double CalcularArea() => Lado * Lado;
        public double CalcularPerimetro() => 4 * Lado;
    }

    public class Retangulo : IFormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public bool NecessitaBase => true;
        public bool NecessitaAltura => true;
        public bool NecessitaRaio => false;

        public void DefinirDimensoes(double baseValue, double altura, double raio)
        {
            Base = baseValue;
            Altura = altura;
        }

        public double CalcularArea() => Base * Altura;
        public double CalcularPerimetro() => 2 * (Base + Altura);
    }

    public class Circunferencia : IFormaGeometrica
    {
        public double Raio { get; set; }

        public bool NecessitaBase => false;
        public bool NecessitaAltura => false;
        public bool NecessitaRaio => true;

        public void DefinirDimensoes(double baseValue, double altura, double raio)
        {
            Raio = raio;
        }

        public double CalcularArea() => Math.PI * Raio * Raio;
        public double CalcularPerimetro() => 2 * Math.PI * Raio;
    }

    public class Triangulo : IFormaGeometrica
    {
        public string[] Tipos = { "Equilátero", "Isósceles", "Reto" };
        public double Base { get; set; }
        public double Altura { get; set; }

        public bool NecessitaBase => true;
        public bool NecessitaAltura => true;
        public bool NecessitaRaio => false;

        public void DefinirDimensoes(double baseValue, double altura, double raio)
        {
            Base = baseValue;
            Altura = altura;
        }

        public double CalcularArea() => (Base * Altura) / 2;
        public double CalcularPerimetro()
        {
            // Exemplo para equilátero, pode ser expandido para outros tipos
            return 3 * Base;
        }
    }
}
