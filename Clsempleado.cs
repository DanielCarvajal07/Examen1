using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Clsempleado
    {
        //Atributos

        static int cant = 10;

        static byte indice = 0;

        static int posicion = 1;
        private static string[] cedula = new string[cant];

        private static string[] nombre = new string[cant];

        private static string[] direccion = new string[cant];

        private static int[] telefono = new int[cant];

        private static int[] salario = new int[cant];



        //Metodos

        public static void Agregar_Empleados()
        {
            char respuesta = ' ';
            do
            {
                Console.WriteLine("Digite su numero de cedula: {0}", posicion);
                cedula[indice] = Console.ReadLine();
                Console.WriteLine("Digite su Nombre: {0}", posicion);
                nombre[indice] = Console.ReadLine();
                Console.WriteLine("Digite su direccion: {0}", posicion);
                direccion[indice] = Console.ReadLine();
                Console.WriteLine("Digite su numero telefonico: {0}", posicion);
                int.TryParse(Console.ReadLine(), out telefono[indice]);
                Console.WriteLine("Digite su salario: {0}", posicion);
                int.TryParse(Console.ReadLine(), out salario[indice]);
                Console.WriteLine("Empleado Agregado Correctamente!");
                indice++;
                posicion++;
                Console.WriteLine("Desea ingresar otro Empleado S/N ");
                respuesta = char.Parse(Console.ReadLine().ToUpper());
            } while (respuesta.Equals('S'));


        }

        public static void Consultar_Empleados()
        {
            Console.WriteLine("########## Consulta Empleados #########");
            for (int i = 0; i < posicion - 1; i++)
            {
                Console.WriteLine($"Cedula: {cedula[i]}---- Nombre: {nombre[i]}---- Direccion: {direccion[i]}---- Telefono: {telefono[i]}---- Salario: {salario[i]}");
                Console.WriteLine("########## Fin de Consulta ##########");
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Digite un numero de cedula");
            string ced = Console.ReadLine();
            Boolean existe = false;

            for (int i = 0; i < cant; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.WriteLine($"Cedula: {cedula[i]}---- Nombre: {nombre[i]}---- Direccion: {direccion[i]}---- Telefono: {telefono[i]}---- Salario: {salario[i]}");
                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El Empleado no existe");
            }
            Console.ReadLine();
            Console.Clear();
        }


        public static void Modificar_Empleados()
        {
            Console.WriteLine("Digite un numero de cedula");
            string ced = Console.ReadLine();
            Boolean existe = false;

            for (int i = 0; i < cant; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.WriteLine("introduce el nuevo nombre");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("introduce la nueva direccion");
                    direccion[i] = Console.ReadLine();
                    Console.WriteLine("introduce el nuevo numero de telefono");

                    Console.WriteLine("introduce el nuevo salario ");

                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El Empleado se elimino de la lista");
            }
            Console.ReadLine();
            Console.Clear();
        }

        public static void Borrar()
        {
            Console.WriteLine("Digite un numero de cedula");
            string ced = Console.ReadLine();
            Boolean existe = false;

            for (int i = 0; i < cant; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    cedula[i] = "";
                    nombre[i] = "";
                    direccion[i] = "";
                    telefono[i] = 0;
                    salario[i] = 0;
                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El Empleado se elimino de la lista");
            }
            Console.ReadLine();
            Console.Clear();
        }

        public static void Inicializar_Arreglos()
        {
            cedula = Enumerable.Repeat("", cant).ToArray();
            nombre = Enumerable.Repeat("", cant).ToArray();
            direccion = Enumerable.Repeat("", cant).ToArray();
            telefono = Enumerable.Repeat(0, cant).ToArray();
            salario = Enumerable.Repeat(0, cant).ToArray();
            posicion = 1;
            indice = 0;
            Console.Clear();
            Console.WriteLine("Arreglos inicializados");
            Console.ReadLine();
        }
        public static void reporte() // consulta
        {
            Console.WriteLine("Digite un numero de cedula");
            string ced = Console.ReadLine();
            Boolean existe = false;

            for (int i = 0; i < cant; i++)
            {
                if (ced.Equals(cedula[i]))
                {
                    Console.WriteLine($"Cedula: {cedula[i]}---- Nombre: {nombre[i]}---- Direccion: {direccion[i]}---- Telefono: {telefono[i]}---- Salario: {salario[i]}");
                    existe = true;
                    break;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El Empleado no existe");
            }
            Console.ReadLine();
            Console.Clear();
        }

        public static void Listar_todos_los_empleados()
        {
           
        }

        public static void Promedio_de_los_salarios()
        {
            Console.WriteLine(salario.Average());
            Console.ReadLine();
        }

        public static void salario_más_alto_y_más_bajo()
        {
            Console.WriteLine(salario.Max()); 
            Console.ReadLine() ;
            Console.WriteLine(salario.Min());
            Console.ReadLine();

        }
    }
}


           
          
