﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atacado.Service.Estoque
{
    public interface IAcaoListarSrv<T>

    {
        List<T> Listar();
    }
}
