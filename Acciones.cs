using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Acciones : IAcciones
    {
        Alumno l = new Alumno();
        public List<Alumno> listaalumnos = new List<Alumno>()
        {new Alumno("Angela",20,113149)
        };

        public void Actualizar(int matricula, string nombre, int edad)
        {
            throw new NotImplementedException();
        }

        public void Agregar(int matricula, string nombre, int edad)
        {
            listaalumnos.Add(new Alumno(l.Nombre = nombre, l.Edad = edad, l.Matricula = matricula));
        }

     
        public List<Alumno> Consultar()
        { 
            return listaalumnos; 
        }

        public void Eliminar(int matricula)
        {
            var objetoeliminar = listaalumnos.FirstOrDefault(x => x.Matricula == matricula);
            if (objetoeliminar != null)
                listaalumnos.Remove(objetoeliminar);

            else
                Console.WriteLine("No se pudo eliminar, no hay nada");
        }

        public void ExportarExcel()
        {
            throw new NotImplementedException();
        }
    }
}
