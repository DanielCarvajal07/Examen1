using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Clsmenu
    {
        // Atributos

        static int opcion = 0;
        //Metodo

        public static void Desplegar()
        {
            do
            {
                Console.WriteLine("1-Agregar_Empleados");
                Console.WriteLine("2-Consultar_Empleados");
                Console.WriteLine("3-Modificar_Empleados");
                Console.WriteLine("4-Borrar_Empleados");
                Console.WriteLine("5-Inicializar_Arreglos");
                Console.WriteLine("6-Reportes");
                Console.WriteLine("Digite una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: Clsempleado.Agregar_Empleados(); break;
                    case 2: Clsempleado.Consultar_Empleados(); break;
                    case 3: Clsempleado.Modificar_Empleados(); break;
                    case 4: Clsempleado.Borrar(); break;
                    case 5: Clsempleado.Inicializar_Arreglos(); break;
                    case 6: submenu(); break;
                    default:
                        break;

                }

            } while (opcion != 7);

        }
        public static void submenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1-Consultar_Empleados");
                Console.WriteLine("2-Listar_todos_los_empleados");
                Console.WriteLine("3-Promedio_de_los_salarios");
                Console.WriteLine("4-salario_más_alto_y_más_bajo");
                Console.WriteLine("Digite una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: Clsempleado.reporte(); break;
                    case 2: break;
                    case 3: break;
                    case 4: Clsempleado.salario_más_alto_y_más_bajo(); break;


                }

            } while (opcion != 7);





        }
    }
}
