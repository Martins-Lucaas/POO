using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfa_CadastroPFPJ
{
    class PessoaFisica:Pessoa
    {
        private string cpf;
        private int qtdFilhos;
        private double salario;

        public PessoaFisica(string cpf, string nome, string cidade, int qtdFilhos, double salario):base(nome,cidade)
        {
            this.cpf = cpf;
            this.qtdFilhos = qtdFilhos;
            this.salario = salario;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public int QtdFilhos { get => qtdFilhos; set => qtdFilhos = value; }
        public double Salario { get => salario; set => salario = value; }

        public override double CalcCredito()
        {
            double credito;
            credito = salario*12 - qtdFilhos*10;
            return credito;
        }


    }//Fim Classe
}
