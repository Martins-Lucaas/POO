using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfa___TestePfPj
{
    class PessoaFisica:Pessoa
    {
        private string cpf;
        private int qtdFilhos;
        private double salario;

        public string Cpf { get => cpf; set => cpf = value; }
        public int QtdFilhos { get => qtdFilhos; set => qtdFilhos = value; }
        public double Salario { get => salario; set => salario = value; }

        public PessoaFisica(string cpf,string nome, string cidade, int qtdFilhos, double salario):base(nome, cidade)
        {   
            this.cpf = cpf;
            this.qtdFilhos = qtdFilhos;
            this.salario = salario;
        }

        public override double CalcCredito()
        {
            double credito;
            credito = (salario / qtdFilhos) * 5;
            return credito;

        }

        public double test()
        {
            double teste;
            teste = (salario * 10);
            return teste;
        }

    }
}
