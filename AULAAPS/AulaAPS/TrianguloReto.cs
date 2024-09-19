using System;
using System.Windows.Forms;

namespace AulaAPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarVisibilidade();
        }

        private void AtualizarVisibilidade()
        {
            bool quadradoVisivel = cmbForma.Text == "Quadrado";
            bool retanguloVisivel = cmbForma.Text == "Retângulo";
            bool circunferenciaVisivel = cmbForma.Text == "Circunferência";
            bool trianguloVisivel = cmbForma.Text == "Triângulo";

            ExibirCampos("Base", quadradoVisivel || retanguloVisivel);
            ExibirCampos("Altura", retanguloVisivel || trianguloVisivel);
            ExibirCampos("Raio", circunferenciaVisivel);
            cmbTriangulo.Visible = trianguloVisivel;
        }

        private void ExibirCampos(string tipo, bool visivel)
        {
            switch (tipo)
            {
                case "Base":
                    lblBase.Visible = txtBase.Visible = visivel;
                    break;
                case "Altura":
                    lblAltura.Visible = txtAltura.Visible = visivel;
                    break;
                case "Raio":
                    lblRaio.Visible = txtRaio.Visible = visivel;
                    break;
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbForma.Text == "Quadrado")
                {
                    AdicionarForma("Quadrado", txtBase.Text);
                }
                else if (cmbForma.Text == "Retângulo")
                {
                    AdicionarForma("Retângulo", txtBase.Text, txtAltura.Text);
                }
                else if (cmbForma.Text == "Circunferência")
                {
                    AdicionarForma("Circunferência", txtRaio.Text);
                }
                else if (cmbForma.Text == "Triângulo")
                {
                    AdicionarTriangulo();
                }
                LimparCampos();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarForma(string tipo, params string[] valores)
        {
            double[] valoresNumericos = new double[valores.Length];

            for (int i = 0; i < valores.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(valores[i]) || !double.TryParse(valores[i], out valoresNumericos[i]))
                {
                    throw new FormatException($"Valor para {tipo} está em um formato incorreto.");
                }
            }

            // Lógica para adicionar a forma ao comboBox baseado no tipo
            // Por exemplo:
            // if (tipo == "Quadrado") { /* Adiciona quadrado */ }
            // if (tipo == "Retângulo") { /* Adiciona retângulo */ }
            // if (tipo == "Circunferência") { /* Adiciona circunferência */ }
        }

        private void AdicionarTriangulo()
        {
            // Adicione lógica para adicionar triângulo aqui, semelhante a AdicionarForma.
        }

        private void LimparCampos()
        {
            txtAltura.Clear();
            txtRaio.Clear();
            txtBase.Clear();
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para atualizar área e perímetro
        }
    }
}
