﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Alumno : Persona
    {
        public Alumno () { }

        public Alumno(string nombre, int edad, int matricula)
            :base(nombre, edad)
        {
            Matricula = matricula;
        }

        public int Matricula { get; set; }
    }
}
