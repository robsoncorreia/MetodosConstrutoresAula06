using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosConstrutoresAula06
{
    class Carro
    {
        public int placa;
        public string marca;
        public string modelo;
        public string cor;
        public Proprietario proprietario;

        public Carro()
        {
            this.cor = "azul";
        }
        public Carro(int placa, string marca, string modelo, string cor)
        {
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }
    }
}
