using System;

namespace Arquitetura.OOP
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                //Propriedades herdadas da classe Pessoa:
                Nome = "João da Silva",
                DataNascimento = Convert.ToDateTime("1990/01/01"),
                //Propriedades da classe Funcionario:
                DataAdmissao = DateTime.Now,
                Registro = "0123456",
            };
        }
    }
}
