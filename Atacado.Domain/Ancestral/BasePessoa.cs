using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Domain.Ancestral

{
    public abstract class BasePessoa : BaseCampoPadronizado

    {
        protected string telefone;

        protected string email;

        protected string endereco;

        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Endereco { get => endereco; set => endereco = value; }

        public BasePessoa(int codigo, string telefone, string email)
           : base(codigo)
        {
            this.codigo = codigo;
            this.telefone = telefone;
            this.email = email;
            
        }
        public BasePessoa(int codigo, string telefone, string email, string endereco)
            : base(codigo)
        {
            this.codigo = codigo;
            this.telefone = telefone;
            this.email = email;
            this.endereco = endereco;
        }
    }
}

