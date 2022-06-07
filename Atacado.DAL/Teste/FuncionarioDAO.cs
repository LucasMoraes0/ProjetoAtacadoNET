using Atacado.DAL.Ancestral;
using Atacado.Domain.Ancestral;
using Atacado.Domain.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.Teste
{
    internal class FuncionarioDAO : IActionReadDAO<Funcionario>
    {
        public Funcionario Read(int id)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> ReadAll()
        {
            throw new NotImplementedException();
        }
    }
}
