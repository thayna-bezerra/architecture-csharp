using System;

namespace Arquitetura.OOP
{ 
    public class CafeteiraExpressa : Eletrodomestico
    {
        public CafeteiraExpressa(string nome, int voltagem)
            :base(nome, voltagem) 
        {

        }

        public CafeteiraExpressa()
            :base("Padrao", 220) //construtor vazio
        {

        }

        private static void AquecerAgua()
        {

        }

        private static void MoerGraos()
        {

        }

        public void FazerCafe()
        {
            AquecerAgua();
            MoerGraos();
        }

        public override void Ligar()
        {
            //verificar recipiente de água
        }

        public override void Desligar()
        {
            //resfriar aquecedor
        }
    }
}
