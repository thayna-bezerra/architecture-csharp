using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.SOLID.OCP.Solucao_Extension_Methods
{
    public class DebitoConta
    {
        public string NumeroConta { get; set; }
        public string Valor { get; set; }
        public string NumeroTransacao { get; set; }

        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMENOPQRSTUVWXYZ123456789";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            // numero de transacao formatado
            return NumeroTransacao;
        }
    }
}
