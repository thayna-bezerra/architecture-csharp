using System;

namespace Arquitetura.SOLID.OCP.Solucao
{
    public class DebitoContaCorrente : DebitoConta //especialização da debito em conta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //debita conta corrente
            return FormatarTransacao();
        }
    }
}
