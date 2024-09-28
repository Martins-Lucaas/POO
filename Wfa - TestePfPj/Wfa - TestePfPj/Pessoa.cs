using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wfa___TestePfPj
{
    public abstract class Pessoa
    {
        protected string nome;
        protected string cidade;

        public string Nome { get => nome; set => nome = value; }
        public string Cidade { get => cidade; set => cidade = value; }

        public Pessoa(string nome, string cidade)
        {
            this.nome = nome;
            this.cidade = cidade;
        }

        public abstract double CalcCredito();
    }//TERMINOUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU
}
