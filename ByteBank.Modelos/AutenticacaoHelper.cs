using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class AutenticacaoHelper
    {
        public static bool CompararSenha(string senhaVerdadeira, string senhaParaComparacao)
        {
            return senhaVerdadeira.Equals(senhaParaComparacao);
        }
    }
}
