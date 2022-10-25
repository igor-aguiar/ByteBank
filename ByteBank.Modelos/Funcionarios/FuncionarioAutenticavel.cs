using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.Modelos.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {
        }

        public bool Autenticar(string senha)
        {
            return AutenticacaoHelper.CompararSenha(Senha, senha);
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.11;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.4;
        }
    }
}
