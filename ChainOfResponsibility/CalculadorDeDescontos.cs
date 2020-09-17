using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class CalculadorDeDescontos
    {
        public static double calcula(Orcamento orcamento)
        {
            Desconto d2 = new DescontoPorMaisDeQuinhentosReais(null);
            Desconto d1 = new DescontoPorMaisDeCincoItens(d2);

            return d1.desconta(orcamento);
        }
    }
}
