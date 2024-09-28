using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfa___TestePfPj
{
    class PessoaJuridica:Pessoa
    {
        private string cnpj;
        private int qtdFunc;
        private double faturamento;
        private string nomeFantasia;

        public PessoaJuridica(string cnpj,string nome, string cidade, int qtdFunc, double faturamento, string nomeFantasia):base(nome, cidade)
        {
            this.cnpj = cnpj;
            this.qtdFunc = qtdFunc;
            this.faturamento = faturamento;
            this.nomeFantasia = nomeFantasia;
        }

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public int QtdFunc { get => qtdFunc; set => qtdFunc = value; }
        public double Faturamento { get => faturamento; set => faturamento = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }

        public override double CalcCredito()
        {
            double credito;
            credito = faturamento * qtdFunc * 1000.0211;
            return credito;
        }
    }

}
