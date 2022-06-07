using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Ancestral
{
    internal interface IAncestralSrv : Estoque.IAcaoExcluirTodosSrv<object>, Estoque.IAcaoAdicionarSrv<object>, Estoque.IAcaoValidarSrv<object>, Estoque.IAcaoAlterarSrv<object>, Estoque.IAcaoSelecionarSrv<object>, Estoque.IAcaoListarSrv<object>
    {
    }
}
