namespace ChainOfResponsibility
{
    public class DescontoPorMaisDeQuinhentosReais : Desconto
    {

        private Desconto proximo;

    public DescontoPorMaisDeQuinhentosReais(Desconto proximo)
    {
        this.proximo = proximo;
    }

    public double desconta(Orcamento orcamento)
    {
        if (orcamento.getValor() > 500)
        {
            return orcamento.getValor() * 0.07;
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
