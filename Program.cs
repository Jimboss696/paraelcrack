using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paraelcrack
{
    // Clase principal para ejecutar el programa
    class Program
    {
        static void Main()
        {
            ListaEnlazadaNumeros listaNumeros = new ListaEnlazadaNumeros();
            ListaEnlazadaEstudiantes listaEstudiantes = new ListaEnlazadaEstudiantes();

            while (true)
            {
                Console.WriteLine("\nMenu Principal:");
                Console.WriteLine("1. Problema 1: Manejo de lista enlazada de números aleatorios");
                Console.WriteLine("2. Problema 2: Registro de estudiantes de Redes III");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                int opcionPrincipal = int.Parse(Console.ReadLine());

                switch (opcionPrincipal)
                {
                    case 1:
                        // Menú del Problema 1
                        while (true)
                        {
                            Console.WriteLine("\nMenu Problema 1:");
                            Console.WriteLine("1. Crear lista enlazada con números aleatorios");
                            Console.WriteLine("2. Eliminar nodos fuera de un rango");
                            Console.WriteLine("3. Imprimir lista");
                            Console.WriteLine("4. Volver al menú principal");
                            Console.Write("Seleccione una opción: ");
                            int opcion1 = int.Parse(Console.ReadLine());

                            if (opcion1 == 1)
                            {
                                Random rand = new Random();
                                listaNumeros = new ListaEnlazadaNumeros(); // Reiniciar la lista
                                for (int i = 0; i < 50; i++)
                                {
                                    listaNumeros.Insertar(rand.Next(1, 1000));
                                }
                                Console.WriteLine("Lista creada con 50 números aleatorios.");
                            }
                            else if (opcion1 == 2)
                            {
                                Console.Write("Ingrese el valor mínimo del rango: ");
                                int min = int.Parse(Console.ReadLine());
                                Console.Write("Ingrese el valor máximo del rango: ");
                                int max = int.Parse(Console.ReadLine());
                                listaNumeros.EliminarNodosFueraDeRango(min, max);
                                Console.WriteLine("Nodos fuera del rango eliminados.");
                            }
                            else if (opcion1 == 3)
                            {
                                Console.WriteLine("Lista actual:");
                                listaNumeros.Imprimir();
                            }
                            else if (opcion1 == 4)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida.");
                            }
                        }
                        break;

                    case 2:
                        // Menú del Problema 2
                        while (true)
                        {
                            Console.WriteLine("\nMenu Problema 2:");
                            Console.WriteLine("1. Agregar estudiante");
                            Console.WriteLine("2. Buscar estudiante por cédula");
                            Console.WriteLine("3. Eliminar estudiante");
                            Console.WriteLine("4. Total estudiantes aprobados");
                            Console.WriteLine("5. Total estudiantes reprobados");
                            Console.WriteLine("6. Imprimir todos los estudiantes");
                            Console.WriteLine("7. Volver al menú principal");
                            Console.Write("Seleccione una opción: ");
                            int opcion2 = int.Parse(Console.ReadLine());

                            if (opcion2 == 1)
                            {
                                Console.Write("Ingrese la cédula: ");
                                string cedula = Console.ReadLine();
                                Console.Write("Ingrese el nombre: ");
                                string nombre = Console.ReadLine();
                                Console.Write("Ingrese el apellido: ");
                                string apellido = Console.ReadLine();
                                Console.Write("Ingrese el correo: ");
                                string correo = Console.ReadLine();
                                Console.Write("Ingrese la nota definitiva (1-10): ");
                                double nota = double.Parse(Console.ReadLine());
                                Estudiante nuevoEstudiante = new Estudiante(cedula, nombre, apellido, correo, nota);
                                listaEstudiantes.AgregarEstudiante(nuevoEstudiante);
                                Console.WriteLine("Estudiante agregado exitosamente.");
                            }
                            else if (opcion2 == 2)
                            {
                                Console.Write("Ingrese la cédula del estudiante a buscar: ");
                                string cedula = Console.ReadLine();
                                Estudiante estudianteEncontrado = listaEstudiantes.BuscarEstudiante(cedula);
                                if (estudianteEncontrado != null)
                                {
                                    Console.WriteLine($"Estudiante encontrado: {estudianteEncontrado.Nombre} {estudianteEncontrado.Apellido}, Correo: {estudianteEncontrado.Correo}, Nota: {estudianteEncontrado.Nota}");
                                }
                                else
                                {
                                    Console.WriteLine("Estudiante no encontrado.");
                                }
                            }
                            else if (opcion2 == 3)
                            {
                                Console.Write("Ingrese la cédula del estudiante a eliminar: ");
                                string cedula = Console.ReadLine();
                                bool eliminado = listaEstudiantes.EliminarEstudiante(cedula);
                                if (eliminado)
                                {
                                    Console.WriteLine("Estudiante eliminado exitosamente.");
                                }
                                else
                                {
                                    Console.WriteLine("Estudiante no encontrado.");
                                }
                            }
                            else if (opcion2 == 4)
                            {
                                Console.WriteLine($"Total de estudiantes aprobados: {listaEstudiantes.TotalAprobados()}");
                            }
                            else if (opcion2 == 5)
                            {
                                Console.WriteLine($"Total de estudiantes reprobados: {listaEstudiantes.TotalReprobados()}");
                            }
                            else if (opcion2 == 6)
                            {
                                Console.WriteLine("Lista de todos los estudiantes:");
                                listaEstudiantes.ImprimirEstudiantes();
                            }
                            else if (opcion2 == 7)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida.");
                            }
                        }
                        break;

                    case 3:
                        // Salir del programa
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
