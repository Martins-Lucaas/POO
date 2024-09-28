namespace Wfa_CadastroPFPJ
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
            this.rbPF = new System.Windows.Forms.RadioButton();
            this.rbPJ = new System.Windows.Forms.RadioButton();
            this.lblCpfCnpj = new System.Windows.Forms.Label();
            this.mtbCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.LblFilhosFuncionarios = new System.Windows.Forms.Label();
            this.lblSalarioFaturamento = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lvPf = new System.Windows.Forms.ListView();
            this.lvPj = new System.Windows.Forms.ListView();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbFilhosFuncionarios = new System.Windows.Forms.TextBox();
            this.tbSalarioFaturamento = new System.Windows.Forms.TextBox();
            this.tbNomeFantasia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbPF
            // 
            this.rbPF.AutoSize = true;
            this.rbPF.Location = new System.Drawing.Point(27, 29);
            this.rbPF.Name = "rbPF";
            this.rbPF.Size = new System.Drawing.Size(125, 24);
            this.rbPF.TabIndex = 0;
            this.rbPF.TabStop = true;
            this.rbPF.Text = "Pessoa Fisica";
            this.rbPF.UseVisualStyleBackColor = true;
            this.rbPF.CheckedChanged += new System.EventHandler(this.rbPF_CheckedChanged);
            // 
            // rbPJ
            // 
            this.rbPJ.AutoSize = true;
            this.rbPJ.Location = new System.Drawing.Point(184, 29);
            this.rbPJ.Name = "rbPJ";
            this.rbPJ.Size = new System.Drawing.Size(138, 24);
            this.rbPJ.TabIndex = 1;
            this.rbPJ.TabStop = true;
            this.rbPJ.Text = "Pessoa Juridica";
            this.rbPJ.UseVisualStyleBackColor = true;
            this.rbPJ.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(122, 92);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(40, 20);
            this.lblCpfCnpj.TabIndex = 2;
            this.lblCpfCnpj.Text = "CPF";
            this.lblCpfCnpj.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCpfCnpj.Click += new System.EventHandler(this.label1_Click);
            // 
            // mtbCpfCnpj
            // 
            this.mtbCpfCnpj.Location = new System.Drawing.Point(170, 82);
            this.mtbCpfCnpj.Name = "mtbCpfCnpj";
            this.mtbCpfCnpj.Size = new System.Drawing.Size(788, 26);
            this.mtbCpfCnpj.TabIndex = 3;
            this.mtbCpfCnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(16, 146);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(146, 20);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCidade
            // 
            this.lblCidade.Location = new System.Drawing.Point(16, 195);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(146, 20);
            this.lblCidade.TabIndex = 6;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblFilhosFuncionarios
            // 
            this.LblFilhosFuncionarios.Location = new System.Drawing.Point(16, 237);
            this.LblFilhosFuncionarios.Name = "LblFilhosFuncionarios";
            this.LblFilhosFuncionarios.Size = new System.Drawing.Size(146, 20);
            this.LblFilhosFuncionarios.TabIndex = 8;
            this.LblFilhosFuncionarios.Text = "Qtd Filhos";
            this.LblFilhosFuncionarios.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSalarioFaturamento
            // 
            this.lblSalarioFaturamento.Location = new System.Drawing.Point(16, 289);
            this.lblSalarioFaturamento.Name = "lblSalarioFaturamento";
            this.lblSalarioFaturamento.Size = new System.Drawing.Size(146, 20);
            this.lblSalarioFaturamento.TabIndex = 10;
            this.lblSalarioFaturamento.Text = "Salario";
            this.lblSalarioFaturamento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblSalarioFaturamento.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.Location = new System.Drawing.Point(16, 342);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(146, 20);
            this.lblNomeFantasia.TabIndex = 12;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            this.lblNomeFantasia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(681, 394);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(122, 38);
            this.btCadastrar.TabIndex = 14;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(836, 394);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(122, 38);
            this.btLimpar.TabIndex = 15;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // lvPf
            // 
            this.lvPf.HideSelection = false;
            this.lvPf.Location = new System.Drawing.Point(20, 457);
            this.lvPf.Name = "lvPf";
            this.lvPf.Size = new System.Drawing.Size(938, 96);
            this.lvPf.TabIndex = 16;
            this.lvPf.UseCompatibleStateImageBehavior = false;
            // 
            // lvPj
            // 
            this.lvPj.HideSelection = false;
            this.lvPj.Location = new System.Drawing.Point(20, 609);
            this.lvPj.Name = "lvPj";
            this.lvPj.Size = new System.Drawing.Size(938, 96);
            this.lvPj.TabIndex = 17;
            this.lvPj.UseCompatibleStateImageBehavior = false;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(170, 135);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(788, 26);
            this.tbNome.TabIndex = 18;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(170, 185);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(788, 26);
            this.tbCidade.TabIndex = 19;
            // 
            // tbFilhosFuncionarios
            // 
            this.tbFilhosFuncionarios.Location = new System.Drawing.Point(170, 232);
            this.tbFilhosFuncionarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFilhosFuncionarios.Name = "tbFilhosFuncionarios";
            this.tbFilhosFuncionarios.Size = new System.Drawing.Size(788, 26);
            this.tbFilhosFuncionarios.TabIndex = 20;
            // 
            // tbSalarioFaturamento
            // 
            this.tbSalarioFaturamento.Location = new System.Drawing.Point(170, 285);
            this.tbSalarioFaturamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSalarioFaturamento.Name = "tbSalarioFaturamento";
            this.tbSalarioFaturamento.Size = new System.Drawing.Size(788, 26);
            this.tbSalarioFaturamento.TabIndex = 21;
            // 
            // tbNomeFantasia
            // 
            this.tbNomeFantasia.Location = new System.Drawing.Point(170, 337);
            this.tbNomeFantasia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNomeFantasia.Name = "tbNomeFantasia";
            this.tbNomeFantasia.Size = new System.Drawing.Size(788, 26);
            this.tbNomeFantasia.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 727);
            this.Controls.Add(this.tbNomeFantasia);
            this.Controls.Add(this.tbSalarioFaturamento);
            this.Controls.Add(this.tbFilhosFuncionarios);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lvPj);
            this.Controls.Add(this.lvPf);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lblNomeFantasia);
            this.Controls.Add(this.lblSalarioFaturamento);
            this.Controls.Add(this.LblFilhosFuncionarios);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.mtbCpfCnpj);
            this.Controls.Add(this.lblCpfCnpj);
            this.Controls.Add(this.rbPJ);
            this.Controls.Add(this.rbPF);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sistema de Gestão";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPF;
        private System.Windows.Forms.RadioButton rbPJ;
        private System.Windows.Forms.Label lblCpfCnpj;
        private System.Windows.Forms.MaskedTextBox mtbCpfCnpj;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label LblFilhosFuncionarios;
        private System.Windows.Forms.Label lblSalarioFaturamento;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ListView lvPf;
        private System.Windows.Forms.ListView lvPj;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbFilhosFuncionarios;
        private System.Windows.Forms.TextBox tbSalarioFaturamento;
        private System.Windows.Forms.TextBox tbNomeFantasia;
    }
}

