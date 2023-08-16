using System;

namespace Arquitetura.SOLID.SRP.Solucao
{
    public class ClienteService //classe que vai executar os serviços para o cliente
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailServices.Enviar("empresa@empresa.com", cliente.Email, "Bem Vindo");

            return "CLiente cadastrado com sucesso";
        }
    }
}
