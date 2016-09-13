using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosConstrutoresAula06
{
    class Proprietario
    {
        public int codigo;
        public string nome;
        public string rg;
        public string cpf;
        public Proprietario(int codigo, string nome, string rg, string cpf)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
        }
    }
}
