using System;

namespace Arquitetura.SOLID.OCP.Solucao
{
    public class DebitoContaPoupança : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //Valida Aniversário da conta
            // debita conta corrente
            return FormatarTransacao();
        }
    }
}
