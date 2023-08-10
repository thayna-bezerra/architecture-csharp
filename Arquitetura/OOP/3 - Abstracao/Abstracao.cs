using System;

namespace Arquitetura.OOP
{
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;
        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        //A classe que herdar a classe Eletrodomestico necessariamente precisará implementar os métodos 
        public abstract void Ligar();
        public abstract void Desligar();
    }
}
