using System;

namespace Arquitetura.OOP
{
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var expresso = new CafeteiraExpressa(); //instancia> acoplamento
            expresso.Ligar();
            expresso.FazerCafe();
            expresso.Desligar();
        }
    }
}
