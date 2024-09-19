using System;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace AulaAPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbForma.SelectedIndexChanged += cmbForma_SelectedIndexChanged;
            cmbTriangulo.SelectedIndexChanged += cmbTriangulo_SelectedIndexChanged;
        }

        private void cmbForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Esconder todos os campos inicialmente
            lblBase.Visible = false;
            lblAltura.Visible = false;
            lblRaio.Visible = false;
            txtBase.Visible = false;
            txtAltura.Visible = false;
            txtRaio.Visible = false;
            cmbTriangulo.Visible = false;

            // Mostrar campos de acordo com a forma selecionada
            switch (cmbForma.SelectedItem.ToString())
            {
                case "Circunferência":
                    lblRaio.Visible = true;
                    txtRaio.Visible = true;
                    break;
                case "Quadrado":
                    lblBase.Visible = true;
                    txtBase.Visible = true;
                    break;
                case "Retângulo":
                    lblBase.Visible = true;
                    txtBase.Visible = true;
                    lblAltura.Visible = true;
                    txtAltura.Visible = true;
                    break;
                case "Triângulo":
                    lblBase.Visible = true;
                    txtBase.Visible = true;
                    lblAltura.Visible = true;
                    txtAltura.Visible = true;
                    cmbTriangulo.Visible = true;
                    break;
            }
        }

        private void cmbTriangulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aqui você pode adicionar a lógica para o tipo de triângulo selecionado
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            // Lógica para calcular área e perímetro
            double area = 0;
            double perimetro = 0;

            switch (cmbForma.SelectedItem.ToString())
            {
                case "Circunferência":
                    double raio = Convert.ToDouble(txtRaio.Text);
                    area = Math.PI * raio * raio;
                    perimetro = 2 * Math.PI * raio;
                    break;
                case "Quadrado":
                    double lado = Convert.ToDouble(txtBase.Text);
                    area = lado * lado;
                    perimetro = 4 * lado;
                    break;
                case "Retângulo":
                    double baseRetangulo = Convert.ToDouble(txtBase.Text);
                    double alturaRetangulo = Convert.ToDouble(txtAltura.Text);
                    area = baseRetangulo * alturaRetangulo;
                    perimetro = 2 * (baseRetangulo + alturaRetangulo);
                    break;
                case "Triângulo":
                    double baseTriangulo = Convert.ToDouble(txtBase.Text);
                    double alturaTriangulo = Convert.ToDouble(txtAltura.Text);
                    area = (baseTriangulo * alturaTriangulo) / 2;
                    // Calcule o perímetro dependendo do tipo de triângulo
                    // Aqui você pode adicionar lógica específica para triângulos
                    break;
            }

            txtArea.Text = area.ToString();
            txtPerimetro.Text = perimetro.ToString();
        }
    }
}
