using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosConstrutoresAula06
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro pedroCarro = new Carro(1235, "Ferrari", "F50", "Vermelha");
            Carro joaoCarro = new Carro(5321, "Volkswagen", "Fusca", "Preta");

            Proprietario pedro = new Proprietario(1234, "Pedro", "12.345.678-65", "874.342.242-42");
            Proprietario joao = new Proprietario(5432, "João", "55.345.678-67", "698.342.242-42");

            pedroCarro.proprietario = pedro;
            joaoCarro.proprietario = joao;

            Exibir(pedroCarro, pedroCarro.proprietario);
            Exibir(joaoCarro, joaoCarro.proprietario);

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }

        public static void Exibir(Carro carro, Proprietario proprietario)
        {
            Asterisco();
            Console.WriteLine("Nome do proprietário: {0}\nRG: {1}\nCPF: {2}\nMarca: {3}\nModelo: {4}\nCor: {5}", carro.proprietario.nome, carro.proprietario.rg, carro.proprietario.cpf, carro.marca, carro.modelo, carro.cor);
            Asterisco();
        }

        public static void Asterisco()
        {
            Console.WriteLine("***********************************");

        }
    }
}
