using Arquitetura.SOLID.ISP.Solucao.Interfaces;

namespace Arquitetura.SOLID.ISP.Solucao
{
    public class CadastroCliente : ICadastroCliente
    {
        public void ValidarDados()
        {
            // Validar CPF, Email
        }

        public void SalvarBanco()
        {
            // Insert na tabela Cliente
        }

        public void EnviarEmail()
        {
            // enviar email para o cliente
        }
    }
}
