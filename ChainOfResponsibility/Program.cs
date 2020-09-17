using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(500);
            double totalDesconto = CalculadorDeDescontos.calcula(orcamento);

            Console.WriteLine("Desconto total do Orcamento: " + totalDesconto);
            Console.ReadLine();
        }
    }
}
