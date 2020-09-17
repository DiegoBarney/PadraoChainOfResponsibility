using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class DescontoPorMaisDeCincoItens: Desconto
    {
        private Desconto proximo;

        public DescontoPorMaisDeCincoItens(Desconto proximo)
        {
            this.proximo = proximo;
        }

        public double desconta(Orcamento orcamento)
        {
            if (orcamento.getItens().Count > 5)
            {
                return orcamento.getValor() * 0.1;
            }
            else
            {
                if (proximo == null)
                    return 0;
                else
                    return proximo.desconta(orcamento);
            }
        }
    }
}
