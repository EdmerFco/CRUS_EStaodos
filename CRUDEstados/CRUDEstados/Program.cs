using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion = null;
            string opcion2 = null;
            CRUDEstados cRUDEstados = new CRUDEstados();
            Estados estados = new Estados();
            do
            {
                Console.WriteLine("1.-Consultar Todos");
                Console.WriteLine("2.-Consultar Solo uno");
                Console.WriteLine("3.-Agregar");
                Console.WriteLine("4.-Actualizar");
                Console.WriteLine("5.-Eliminar");
                Console.WriteLine("6.-Terminar");
                // opcion = Convert.ToInt32(Console.ReadLine());
                opcion = Console.ReadLine();
                /*  if (opcion == "F")
                  {
                      menu = false;
                  }*/
                // menu = (int.Parse(opcion) < 8 ? true : false);
                Console.Clear();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("1.-Consultar Todos");

                        Dictionary<int, Estados> _Estados = cRUDEstados.ConsultarTodos();
                        foreach (KeyValuePair< int, Estados> est in _Estados)
                        {
                            Console.WriteLine($"{est.Key} {est.Value.Nombre} " );
                        }
                        break;
                    case "2":
                        Console.WriteLine("2.-Consultar Solo uno");
                        estados.Id =Convert.ToInt32(Console.ReadLine());
                        estados = cRUDEstados.ConsultarUno(estados.Id);
                        Console.WriteLine($"{estados.Id} {estados.Nombre} ");
                        break;
                    case "3":

                        Console.WriteLine("Coloca el Id  de tu Estado");

                        estados.Id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Coloca el nombre del tu Estado");
                        estados.Nombre = Console.ReadLine();

                        CRUDEstados.Agregar(estados);

                        break;
                    case "4":
                        Console.WriteLine("4.-Coloca el Id del estado que quieres Actualizar");
                        estados.Id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Coloca el nombre del tu Estado");
                        estados.Nombre = Console.ReadLine();

                        cRUDEstados.Actualizar(estados);
                        break;
                    case "5":
                        Console.WriteLine("5.-Eliminar");
                        Console.WriteLine("Coloca el id del estado que deces elimnar");
                        estados.Id = Convert.ToInt32(Console.ReadLine());
                        cRUDEstados.Elimar(estados); 
                        break;
                    case "6":
                        opcion = "F";
                        break;
                    default:
                        Console.WriteLine("No seleciono Opcion valida intentelo de Nuevo");
                        break;
                }
            }
            while (opcion != "F");
        }
    }
}
