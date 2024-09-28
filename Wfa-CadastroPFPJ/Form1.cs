using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using

namespace Wfa_CadastroPFPJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblNomeFantasia.Visible = false;
            tbNomeFantasia.Visible = false;

            gerarGradeGridViewPF();
            gerarGradeGridViewPJ();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Mask = "000.000.000-00";
            lblCpfCnpj.Text = "CNPJ";
            LblFilhosFuncionarios.Text = "QTD Funcionarios";
            lblSalarioFaturamento.Text = "Faturamento";
            lblNomeFantasia.Visible = true;
            tbNomeFantasia.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rbPF.Checked == true)
            {
                //objeto Pessoa Física
                PessoaFisica pessoaFisica = new PessoaFisica(mtbCpfCnpj.Text,tbNome.Text,Convert.ToInt32(tbFilhosFuncionarios.Text),Convert.ToDouble(tbSalarioFaturamento));

            }else if(rbPJ.Checked== true){
                
                //Objeto Pessoa Juridica

            }
        }

        private void rbPF_CheckedChanged(object sender, EventArgs e)
        {
            lblCpfCnpj.Text = "CPF";
            LblFilhosFuncionarios.Text = "QTD Filhos";
            lblSalarioFaturamento.Text = "Salario";
            lblNomeFantasia.Visible = false;
            tbNomeFantasia.Visible = false;
        }

        public void gerarGradeGridViewPF()
        {
            lvPf.Columns.Add("CPF", 100).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("Cidade", 100).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("Qtd Filhos", 80).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("Credito", 150).TextAlign = HorizontalAlignment.Center;
            lvPf.View = View.Details;

        }
        public void gerarGradeGridViewPJ()
        {
            lvPj.Columns.Add("CNPJ", 100).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Cidade", 100).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Qtd Funcionarios", 80).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Faturamento", 150).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Credito", 150).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Nome Fantasia", 150).TextAlign = HorizontalAlignment.Center;
            lvPj.View = View.Details;
        }
    }
}
