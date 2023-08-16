using System;

namespace Arquitetura.SOLID.SRP.Solucao
{
    public class Cliente
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool IsValid()
        { 
            //validando dados do cliente de forma terceirizada não dependendo da logica de negocio escrito na classe cliente
            return EmailServices.IsValid(Email) && CPFServices.Isvalid(CPF);
        }
    }
}
