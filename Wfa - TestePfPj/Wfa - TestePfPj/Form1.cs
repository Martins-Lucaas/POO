using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace Wfa___TestePfPj
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            lbFantasia.Visible = false;//NÂO APARECEEEEEEEEEEEEEEEEE
            tbFantasia.Visible = false;
            ListaPF();
            ListaPJ();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Mask = "000,000,000-00";

            //Alterar os bagui
            LbCpfCnpj.Text = "CPF";
            LbQtdFilhosQtdfunc.Text = "Qtd Filhos";
            LbSalarioFaturamento.Text = "Salario";

            //Tirar o bagui
            lbFantasia.Visible = false;
            tbFantasia.Visible = false;

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Mask = "00,000,000/0000-00";

            //Alterar os bagui
            LbCpfCnpj.Text = "CNPJ";
            LbQtdFilhosQtdfunc.Text = "Qtd Func";
            LbSalarioFaturamento.Text = "Faturamento";

            //Aparecer os bagui
            lbFantasia.Visible = true;
            tbFantasia.Visible = true;
        }
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            bool resultado = validainfo(); //vê se ta tudo certo
            if (rb1.Checked == true && resultado == true)
            {
                PessoaFisica pessoaFisica = new PessoaFisica(mtbCpfCnpj.Text, tbNome.Text, tbCidade.Text, Convert.ToInt32(tbQtdFilhosFunc.Text), Convert.ToDouble(tbSalarioFaturamento.Text));
                string[] clientPF = new string[6]; //Cria vetor espaço 6

                clientPF[0] = pessoaFisica.Cpf;
                clientPF[1] = pessoaFisica.Nome;
                clientPF[2] = pessoaFisica.Cidade;
                clientPF[3] = Convert.ToString(pessoaFisica.QtdFilhos);
                clientPF[4] = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaFisica.Salario*10);
                clientPF[5] = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaFisica.CalcCredito()); //{0:C} = $


                //Bota na lista
                lv1.Items.Add(new ListViewItem(clientPF));


                //Mostra que tá tudo certo
                mensagem();
                Limpar();
            }
            else if(rb2.Checked == true && resultado == true)
            {
                PessoaJuridica pessoaJuridica = new PessoaJuridica(mtbCpfCnpj.Text, tbNome.Text, tbCidade.Text, Convert.ToInt32(tbQtdFilhosFunc.Text), Convert.ToDouble(tbSalarioFaturamento.Text), tbFantasia.Text);
                string[] clientPJ = new string[6+1]; //Cria vetor espaço 7

                clientPJ[0] = pessoaJuridica.Cnpj;
                clientPJ[1] = pessoaJuridica.Nome;
                clientPJ[2] = pessoaJuridica.Cidade;
                clientPJ[3] = Convert.ToString(pessoaJuridica.QtdFunc);
                clientPJ[4] = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaJuridica.Faturamento);
                clientPJ[5] = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaJuridica.CalcCredito()); //{0:C} = $
                clientPJ[5 + 1] = pessoaJuridica.NomeFantasia;

                //Bota na lista
                lv2.Items.Add(new ListViewItem(clientPJ));


                //Mostra que tá tudo certo
                mensagem();
                Limpar();
            }
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void Limpar()
        {
            mtbCpfCnpj.Text = string.Empty;
            tbNome.Text = string.Empty;
            tbCidade.Text = string.Empty;
            tbQtdFilhosFunc.Text = string.Empty;
            tbSalarioFaturamento.Text = string.Empty;
            tbFantasia.Text = string.Empty;
        }
        private void tbQtdFilhosFunc_TextChanged(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 202)
            {
                e.Handled = true;
            }
        }

        private void tbSalarioFaturamento_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 202)
            {
                e.Handled = true;
            }
        }
        private void mensagem()
        {
            MessageBox.Show("BOA!!!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mensagem(string nomelabel)
        {
            MessageBox.Show("burro digita o " + nomelabel + " CERTO KRALHO!!", this.Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        public bool validainfo()
        {
            bool resultado = true;

            if (mtbCpfCnpj.MaskCompleted == false) //Vê se ta certo!!!!!
            {
                mensagem(LbCpfCnpj.Text);
                resultado = false;
            }
            else if (tbNome.Text.Trim() == string.Empty) //TRIM() Tira os espaços
            {
                mensagem(lbNome.Text);
                resultado = false;
            }
            else if (tbCidade.Text.Trim() == string.Empty) //TRIM() Tira os espaços
            {
                mensagem(lbCidade.Text);
                resultado = false;
            }
            else if (tbQtdFilhosFunc.Text.Trim() == string.Empty)
            {
                mensagem(LbQtdFilhosQtdfunc.Text);
                resultado = false;
            }
            else if (tbSalarioFaturamento.Text.Trim() == string.Empty)
            {
                mensagem(LbSalarioFaturamento.Text);
                resultado = false;
            }
            else if (tbSalarioFaturamento.Text.Trim() == string.Empty)
            {
                mensagem(LbSalarioFaturamento.Text);
                resultado = false;
            }

            if(rb2.Checked == true && resultado != false)
            {
                if (tbFantasia.Text.Trim() == string.Empty)
                {
                    mensagem(lbFantasia.Text);
                    resultado = false;
                }
            }

            return resultado;
        }

        public void ListaPF()//Faz lista!!
        {
            lv1.Columns.Add("CPF", 150).TextAlign = HorizontalAlignment.Center;
            lv1.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            lv1.Columns.Add("Cidade", 100).TextAlign = HorizontalAlignment.Center;
            lv1.Columns.Add("Qtd. Filhos", 80).TextAlign = HorizontalAlignment.Center;
            lv1.Columns.Add("Salario", 150).TextAlign = HorizontalAlignment.Center;
            lv1.Columns.Add("Crédito", 150).TextAlign = HorizontalAlignment.Center;
            lv1.View = View.Details;
        }
        public void ListaPJ()//Faz lista!!
        {
            lv2.Columns.Add("CNPJ", 150).TextAlign = HorizontalAlignment.Center;
            lv2.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            lv2.Columns.Add("Cidade", 100).TextAlign = HorizontalAlignment.Center;
            lv2.Columns.Add("Qtd. Func", 80).TextAlign = HorizontalAlignment.Center;
            lv2.Columns.Add("Faturamento", 150).TextAlign = HorizontalAlignment.Center;
            lv2.Columns.Add("Credito", 150).TextAlign = HorizontalAlignment.Center;
            lv2.Columns.Add("Fantasia", 150).TextAlign = HorizontalAlignment.Center;
            lv2.View = View.Details;
        }
    }
}
