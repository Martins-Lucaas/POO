namespace Wfa___TestePfPj
{
    partial class Cadastro
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
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.mtbCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbQtdFilhosFunc = new System.Windows.Forms.TextBox();
            this.tbSalarioFaturamento = new System.Windows.Forms.TextBox();
            this.tbFantasia = new System.Windows.Forms.TextBox();
            this.LbCpfCnpj = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.LbQtdFilhosQtdfunc = new System.Windows.Forms.Label();
            this.LbSalarioFaturamento = new System.Windows.Forms.Label();
            this.lbFantasia = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lv1 = new System.Windows.Forms.ListView();
            this.lv2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(116, 76);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(125, 24);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Pessoa Fisica";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(324, 76);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(138, 24);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "Pessoa Juridica";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // mtbCpfCnpj
            // 
            this.mtbCpfCnpj.Location = new System.Drawing.Point(235, 174);
            this.mtbCpfCnpj.Mask = "000,000,000-00";
            this.mtbCpfCnpj.Name = "mtbCpfCnpj";
            this.mtbCpfCnpj.Size = new System.Drawing.Size(227, 26);
            this.mtbCpfCnpj.TabIndex = 2;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(235, 235);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(227, 26);
            this.tbNome.TabIndex = 3;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(235, 294);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(227, 26);
            this.tbCidade.TabIndex = 4;
            // 
            // tbQtdFilhosFunc
            // 
            this.tbQtdFilhosFunc.Location = new System.Drawing.Point(235, 359);
            this.tbQtdFilhosFunc.Name = "tbQtdFilhosFunc";
            this.tbQtdFilhosFunc.Size = new System.Drawing.Size(227, 26);
            this.tbQtdFilhosFunc.TabIndex = 5;
            this.tbQtdFilhosFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtdFilhosFunc_TextChanged);
            // 
            // tbSalarioFaturamento
            // 
            this.tbSalarioFaturamento.Location = new System.Drawing.Point(235, 435);
            this.tbSalarioFaturamento.Name = "tbSalarioFaturamento";
            this.tbSalarioFaturamento.Size = new System.Drawing.Size(227, 26);
            this.tbSalarioFaturamento.TabIndex = 6;
            this.tbSalarioFaturamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQtdFilhosFunc_TextChanged);
            // 
            // tbFantasia
            // 
            this.tbFantasia.Location = new System.Drawing.Point(235, 513);
            this.tbFantasia.Name = "tbFantasia";
            this.tbFantasia.Size = new System.Drawing.Size(227, 26);
            this.tbFantasia.TabIndex = 7;
            // 
            // LbCpfCnpj
            // 
            this.LbCpfCnpj.AutoSize = true;
            this.LbCpfCnpj.Location = new System.Drawing.Point(112, 177);
            this.LbCpfCnpj.Name = "LbCpfCnpj";
            this.LbCpfCnpj.Size = new System.Drawing.Size(34, 20);
            this.LbCpfCnpj.TabIndex = 8;
            this.LbCpfCnpj.Text = "Cpf";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(112, 238);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(51, 20);
            this.lbNome.TabIndex = 9;
            this.lbNome.Text = "Nome";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(112, 294);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(59, 20);
            this.lbCidade.TabIndex = 10;
            this.lbCidade.Text = "Cidade";
            // 
            // LbQtdFilhosQtdfunc
            // 
            this.LbQtdFilhosQtdfunc.AutoSize = true;
            this.LbQtdFilhosQtdfunc.Location = new System.Drawing.Point(112, 359);
            this.LbQtdFilhosQtdfunc.Name = "LbQtdFilhosQtdfunc";
            this.LbQtdFilhosQtdfunc.Size = new System.Drawing.Size(81, 20);
            this.LbQtdFilhosQtdfunc.TabIndex = 11;
            this.LbQtdFilhosQtdfunc.Text = "Qtd Filhos";
            // 
            // LbSalarioFaturamento
            // 
            this.LbSalarioFaturamento.AutoSize = true;
            this.LbSalarioFaturamento.Location = new System.Drawing.Point(112, 435);
            this.LbSalarioFaturamento.Name = "LbSalarioFaturamento";
            this.LbSalarioFaturamento.Size = new System.Drawing.Size(58, 20);
            this.LbSalarioFaturamento.TabIndex = 12;
            this.LbSalarioFaturamento.Text = "Salario";
            // 
            // lbFantasia
            // 
            this.lbFantasia.AutoSize = true;
            this.lbFantasia.Location = new System.Drawing.Point(112, 513);
            this.lbFantasia.Name = "lbFantasia";
            this.lbFantasia.Size = new System.Drawing.Size(117, 20);
            this.lbFantasia.TabIndex = 13;
            this.lbFantasia.Text = "Nome Fantasia";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(856, 691);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(92, 31);
            this.btLimpar.TabIndex = 14;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(856, 566);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(92, 38);
            this.btCadastrar.TabIndex = 15;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lv1
            // 
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(116, 566);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(662, 97);
            this.lv1.TabIndex = 16;
            this.lv1.UseCompatibleStateImageBehavior = false;
            // 
            // lv2
            // 
            this.lv2.HideSelection = false;
            this.lv2.Location = new System.Drawing.Point(116, 691);
            this.lv2.Name = "lv2";
            this.lv2.Size = new System.Drawing.Size(662, 97);
            this.lv2.TabIndex = 17;
            this.lv2.UseCompatibleStateImageBehavior = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 836);
            this.Controls.Add(this.lv2);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.lbFantasia);
            this.Controls.Add(this.LbSalarioFaturamento);
            this.Controls.Add(this.LbQtdFilhosQtdfunc);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.LbCpfCnpj);
            this.Controls.Add(this.tbFantasia);
            this.Controls.Add(this.tbSalarioFaturamento);
            this.Controls.Add(this.tbQtdFilhosFunc);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.mtbCpfCnpj);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.MaskedTextBox mtbCpfCnpj;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbQtdFilhosFunc;
        private System.Windows.Forms.TextBox tbSalarioFaturamento;
        private System.Windows.Forms.TextBox tbFantasia;
        private System.Windows.Forms.Label LbCpfCnpj;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label LbQtdFilhosQtdfunc;
        private System.Windows.Forms.Label LbSalarioFaturamento;
        private System.Windows.Forms.Label lbFantasia;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.ListView lv2;
    }
}

