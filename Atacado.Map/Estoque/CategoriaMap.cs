using Atacado.Domain.Estoque;
using Atacado.POCO.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Map.Estoque
{
    public static class CategoriaMap
    {
        public static CategoriaPOCO ConverterParaPoco(Categoria dom)
        {
            CategoriaPOCO poco = new CategoriaPOCO();
            poco.Codigo = dom.Codigo;
            poco.Descricao = dom.Descricao;
            poco.Situacao = dom.Situacao;
            return poco;
        }
        public static Categoria ConverterParaDomain(CategoriaPOCO poco)
        {
            return new Categoria(poco.Codigo, poco.Descricao, poco.Situacao);            
        }
    }
}
