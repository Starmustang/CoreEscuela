﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    internal interface ILugar
    {
        string Direccion { get; set; }

        void LimpiarLugar();
    }
}
