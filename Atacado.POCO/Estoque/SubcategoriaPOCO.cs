using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.POCO.Estoque
{
    internal class SubcategoriaPOCO
    {
        public int Codigo { get; set; }
        public int CodigoCategoria { get; set; }
        public string Descricao { get; set; }
        public int Situacao { get; set; }
    }
}
