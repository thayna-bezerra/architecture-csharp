using System;

namespace Arquitetura.SOLID.OCP.Solucao_Extension_Methods
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta) //alternativa para dependencia em debito conta sem ser por herança
        {
            // logica de negocio para debito em conta corrente
            return debitoConta.FormatarTransacao();
        }
    }
}
