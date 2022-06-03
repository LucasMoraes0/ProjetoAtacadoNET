using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.DAL.Ancestral
{
    public interface IActionCreateDAO<T>
    {
        T Create(T entity);
    }
}
