using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        public enum Menu
        {
            Consultar=1, Agregar, Actualizar, Eliminar
        }
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();
            while(true)
            {
                switch (Men())
                { 
                    case Menu.Consultar:
                        var lista = acciones.Consultar();
                        foreach (var l in lista)
                        {
                            Console.WriteLine($"Nombre:{l.Nombre}");
                            Console.WriteLine($"Edad:{l.Edad}");
                            Console.WriteLine($"Matricula:{l.Matricula}");
                        }
                        break;
                        case Menu.Agregar:
                        Console.WriteLine("Nombre:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Edad");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Matricula");
                        int matricula = Convert.ToInt32(Console.ReadLine());
                        acciones.Agregar(matricula, nombre, edad);
                        break;
                        case Menu.Actualizar:
                        break;
                        case Menu.Eliminar:
                        Console.WriteLine("Dame matricula a eliminar");
                        int matriculaeliminar = Convert.ToInt32(Console.ReadLine());
                        acciones.Eliminar(matriculaeliminar);
                        break;
                        default:
                        break;
                }


            }
        }
        static Menu Men()
        {
            Console.WriteLine("1)Consultar");
            Console.WriteLine("2)Agregar");
            Console.WriteLine("3)Actualizar");
            Console.WriteLine("4)Eliminar");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());

            return opc;
        }
    }
}
