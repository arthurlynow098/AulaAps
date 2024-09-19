namespace WfaFormas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpFormas = new System.Windows.Forms.GroupBox();
            this.lblMedida1 = new System.Windows.Forms.Label();
            this.lblMedidas = new System.Windows.Forms.Label();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbObjetos = new System.Windows.Forms.ComboBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.cmbTriangulo = new System.Windows.Forms.ComboBox();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.grpFormas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFormas
            // 
            this.grpFormas.Controls.Add(this.lblMedida1);
            this.grpFormas.Controls.Add(this.lblMedidas);
            this.grpFormas.Controls.Add(this.lblTriangulo);
            this.grpFormas.Controls.Add(this.label2);
            this.grpFormas.Controls.Add(this.label1);
            this.grpFormas.Controls.Add(this.txtPerimetro);
            this.grpFormas.Controls.Add(this.lblPerimetro);
            this.grpFormas.Controls.Add(this.txtArea);
            this.grpFormas.Controls.Add(this.lblArea);
            this.grpFormas.Controls.Add(this.cmbObjetos);
            this.grpFormas.Controls.Add(this.btnCriar);
            this.grpFormas.Controls.Add(this.txtRaio);
            this.grpFormas.Controls.Add(this.txtAltura);
            this.grpFormas.Controls.Add(this.txtBase);
            this.grpFormas.Controls.Add(this.lblRaio);
            this.grpFormas.Controls.Add(this.lblAltura);
            this.grpFormas.Controls.Add(this.lblBase);
            this.grpFormas.Controls.Add(this.cmbTriangulo);
            this.grpFormas.Controls.Add(this.cmbForma);
            this.grpFormas.Location = new System.Drawing.Point(60, 28);
            this.grpFormas.Name = "grpFormas";
            this.grpFormas.Size = new System.Drawing.Size(592, 334);
            this.grpFormas.TabIndex = 0;
            this.grpFormas.TabStop = false;
            this.grpFormas.Enter += new System.EventHandler(this.grpFormas_Enter);
            // 
            // lblMedida1
            // 
            this.lblMedida1.AutoSize = true;
            this.lblMedida1.Location = new System.Drawing.Point(90, 169);
            this.lblMedida1.Name = "lblMedida1";
            this.lblMedida1.Size = new System.Drawing.Size(45, 13);
            this.lblMedida1.TabIndex = 18;
            this.lblMedida1.Text = "Medida:";
            this.lblMedida1.Visible = false;
            this.lblMedida1.Click += new System.EventHandler(this.lblMedida1_Click);
            // 
            // lblMedidas
            // 
            this.lblMedidas.AutoSize = true;
            this.lblMedidas.Location = new System.Drawing.Point(87, 113);
            this.lblMedidas.Name = "lblMedidas";
            this.lblMedidas.Size = new System.Drawing.Size(50, 13);
            this.lblMedidas.TabIndex = 17;
            this.lblMedidas.Text = "Medidas:";
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Location = new System.Drawing.Point(24, 65);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(101, 13);
            this.lblTriangulo.TabIndex = 16;
            this.lblTriangulo.Text = "Escolha o Triângulo";
            this.lblTriangulo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Escolha A Forma";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Formas já Criadas";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(278, 162);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetro.TabIndex = 13;
            this.txtPerimetro.TextChanged += new System.EventHandler(this.txtPerimetro_TextChanged);
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(207, 165);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(56, 13);
            this.lblPerimetro.TabIndex = 12;
            this.lblPerimetro.Text = "Perímetro:";
            this.lblPerimetro.Click += new System.EventHandler(this.lblPerimetro_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(278, 136);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 11;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(231, 136);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Área:";
            this.lblArea.Click += new System.EventHandler(this.lblArea_Click);
            // 
            // cmbObjetos
            // 
            this.cmbObjetos.FormattingEnabled = true;
            this.cmbObjetos.Location = new System.Drawing.Point(234, 105);
            this.cmbObjetos.Name = "cmbObjetos";
            this.cmbObjetos.Size = new System.Drawing.Size(162, 21);
            this.cmbObjetos.TabIndex = 9;
            this.cmbObjetos.DropDown += new System.EventHandler(this.cmbObjetos_DropDown);
            this.cmbObjetos.SelectedIndexChanged += new System.EventHandler(this.cmbObjetos_SelectedIndexChanged);
            this.cmbObjetos.TextUpdate += new System.EventHandler(this.cmbObjetos_TextUpdate);
            // 
            // btnCriar
            // 
            this.btnCriar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCriar.Location = new System.Drawing.Point(234, 33);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 21);
            this.btnCriar.TabIndex = 8;
            this.btnCriar.Text = "&Criar";
            this.btnCriar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtRaio
            // 
            this.txtRaio.Enabled = false;
            this.txtRaio.Location = new System.Drawing.Point(67, 188);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 20);
            this.txtRaio.TabIndex = 7;
            this.txtRaio.TextChanged += new System.EventHandler(this.txtRaio_TextChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Enabled = false;
            this.txtAltura.Location = new System.Drawing.Point(67, 159);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 6;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // txtBase
            // 
            this.txtBase.Enabled = false;
            this.txtBase.Location = new System.Drawing.Point(67, 133);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 5;
            this.txtBase.TextChanged += new System.EventHandler(this.txtBase_TextChanged);
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(24, 188);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(32, 13);
            this.lblRaio.TabIndex = 4;
            this.lblRaio.Text = "Raio:";
            this.lblRaio.Visible = false;
            this.lblRaio.Click += new System.EventHandler(this.lblRaio_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(24, 161);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.Visible = false;
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(24, 133);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(34, 13);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base:";
            this.lblBase.Visible = false;
            this.lblBase.Click += new System.EventHandler(this.lblBase_Click);
            // 
            // cmbTriangulo
            // 
            this.cmbTriangulo.FormattingEnabled = true;
            this.cmbTriangulo.Items.AddRange(new object[] {
            "Equilátero",
            "Isósceles",
            "Reto"});
            this.cmbTriangulo.Location = new System.Drawing.Point(27, 81);
            this.cmbTriangulo.Name = "cmbTriangulo";
            this.cmbTriangulo.Size = new System.Drawing.Size(145, 21);
            this.cmbTriangulo.TabIndex = 1;
            this.cmbTriangulo.Visible = false;
            this.cmbTriangulo.SelectedIndexChanged += new System.EventHandler(this.cmbTriangulo_SelectedIndexChanged);
            this.cmbTriangulo.TextUpdate += new System.EventHandler(this.cmbTriangulo_TextUpdate);
            this.cmbTriangulo.TextChanged += new System.EventHandler(this.cmbTriangulo_TextUpdate);
            // 
            // cmbForma
            // 
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Items.AddRange(new object[] {
            "Circunferência",
            "Quadrado",
            "Retângulo",
            "Triângulo"});
            this.cmbForma.Location = new System.Drawing.Point(27, 33);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(145, 21);
            this.cmbForma.TabIndex = 0;
            this.cmbForma.SelectedIndexChanged += new System.EventHandler(this.cmbForma_SelectedIndexChanged);
            this.cmbForma.TextUpdate += new System.EventHandler(this.cmbForma_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 401);
            this.Controls.Add(this.grpFormas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calcular Formas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpFormas.ResumeLayout(false);
            this.grpFormas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFormas;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.ComboBox cmbTriangulo;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbObjetos;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.Label lblMedidas;
        private System.Windows.Forms.Label lblMedida1;
    }
}

