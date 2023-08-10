using System;

namespace Arquitetura.OOP
{ 
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
            :base(nome, voltagem) 
        {

        }

        public CafeteiraEspressa()
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
