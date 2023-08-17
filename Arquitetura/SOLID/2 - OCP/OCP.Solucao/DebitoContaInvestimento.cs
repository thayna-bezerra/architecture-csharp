using System;

namespace Arquitetura.SOLID.OCP.Solucao
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //debita conta investimento
            //insentar taxas
            return FormatarTransacao();
        }
    }
}
