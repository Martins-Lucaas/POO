using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfa_CadastroPFPJ
{
    class PessoaJuridica:Pessoa
    {
        private string cnpj;
        private int qtdFuncionarios;
        private double faturamento;
        private string nomeFantasia;

        public PessoaJuridica(string cnpj, string nome, string cidade, int qtdFuncionarios, double faturamento, string nomeFantasia):base(nome,cidade)
        {
            this.cnpj = cnpj;
            this.qtdFuncionarios = qtdFuncionarios;
            this.faturamento = faturamento;
            this.nomeFantasia = nomeFantasia;
        }

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public int QtdFuncionarios { get => qtdFuncionarios; set => qtdFuncionarios = value; }
        public double Faturamento { get => faturamento; set => faturamento = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }

        public override double CalcCredito()
        {
            double credito;
            credito = faturamento * 12 + qtdFuncionarios * 10;
            return credito;

        }

    }//Fim Classe
}
