using System;

namespace Arquitetura.SOLID.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if(tipoConta == TipoConta.Corrente)
            {
                //debita conta corrente
            }

            if(tipoConta == TipoConta.Poupanca)
            {
                //valida aniversario da conta
                //debita conta poupança
            }
        }
    }
}
