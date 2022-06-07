using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.POCO
{
    public class MunicipioPOCO
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int CodigoUF { get; set; }
        public string SiglaUF { get; set; }
        public int CodigoMesoregiao { get; set; }
        public int CodigoMicroregiao { get; set; }
        public int CodigoIBGE6 { get; set; }
        public int CodigoIBGE7 { get; set; }
        public long PopulacaoMunicipio { get; set; }
        public long Cep { get; set; }
        public string PorteMunicipio { get; set; }
    }
}
