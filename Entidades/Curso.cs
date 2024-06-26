﻿using CoreEscuela.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Curso: ObjetoEscuelaBase, ILugar
    {
        

        public TiposJornada Jornada { get; set; }

        public List<Asignatura> Asignaturas { get; set; }

        public List<Alumno> Alumnos { get; set; }
        public string Direccion { get; set; }

        public void LimpiarLugar()
        {
            
            Printer.DibujarLinea();
            Console.WriteLine("Limpiando establecimiento....");
            Console.WriteLine($"Curso {Nombre} Limpio");
        }
    }
}
