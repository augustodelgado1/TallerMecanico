﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Negocio
    {
        static List<Cliente> listaDeClientes;
        static List<Producto> listaDeProductos;
        static Negocio()
        {
            listaDeProductos = new List<Producto>() { };
        }
    }
}
