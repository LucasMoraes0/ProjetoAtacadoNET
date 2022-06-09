using Atacado.Service.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Ancestral
{
    public interface IAncestralSrv<T> : 
        IAcaoExcluirTodosSrv<T>,
        IAcaoAdicionarSrv<T>, 
        IAcaoValidarSrv<T>, 
        IAcaoAlterarSrv<T>, 
        IAcaoSelecionarSrv<T>, 
        IAcaoListarSrv<T>
    {
    }
}
