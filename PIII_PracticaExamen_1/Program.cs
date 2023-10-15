using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PIII_PracticaExamen_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Inicializar Vectores");
                Console.WriteLine("2. Incluir Estudiantes");
                Console.WriteLine("3. Consultar  Estudiantes");
                Console.WriteLine("4. Modificar Estudiantes");
                Console.WriteLine("5. Eliminar Estudiantes");
                Console.WriteLine("6. Submenú Reportes");
                Console.WriteLine("7. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        ClsEstudiante.InicializarVectores();

                        ClsEstudiante.cedula[0] = 402440919;
                        ClsEstudiante.nombre[0] = "Jose Antonio Valerio Chaves";
                        ClsEstudiante.promedio[0] = 100;
                        ClsEstudiante.condicion[0] = ClsEstudiante.CondicionEst(ClsEstudiante.promedio[0]);

                        ClsEstudiante.cedula[1] = 20202020;
                        ClsEstudiante.nombre[1] = "Maria Teresa Rodriguez Zamora";
                        ClsEstudiante.promedio[1] = 65;
                        ClsEstudiante.condicion[1] = ClsEstudiante.CondicionEst(ClsEstudiante.promedio[1]);

                        ClsEstudiante.cedula[2] = 30303030;
                        ClsEstudiante.nombre[2] = "Rafael Calderon";
                        ClsEstudiante.promedio[2] = 40;
                        ClsEstudiante.condicion[2] = ClsEstudiante.CondicionEst(ClsEstudiante.promedio[2]);

                        break;
                    case 2:
                        ClsEstudiante.RegistrarEstudiante();
                        break;
                    case 3:
                        ClsEstudiante.ConsultarEstudiante();
                        break;
                    case 4:
                        ClsEstudiante.ModificarEstudiante();
                        break;
                    case 5:
                        ClsEstudiante.EliminarEstudiante();
                        break;
                    case 6:
                        int opc2 = 0;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("1. Ver estudiantes por condicion academica.");
                            Console.WriteLine("2. Reporte con todos los datos.");
                            Console.WriteLine("3. Regresar al menu principal.");
                            opc2 = int.Parse(Console.ReadLine());
                            switch (opc2)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el numero de la condicion a visualizar:");
                                    Console.WriteLine("1. Aprobado");
                                    Console.WriteLine("2. Aplazado");
                                    Console.WriteLine("3. Reprobado");
                                    int opcCondicion = int.Parse( Console.ReadLine());
                                    ClsReportes.ReporteCondicion(opcCondicion);
                                    break;
                                case 2:
                                    ClsReportes.ReporteGeneral();
                                    break;
                                case 3: 
                                    break;
                                default:
                                    Console.WriteLine("Opcion invalida, intente de nuevo.");
                                    break;
                            }

                        } while (opc2 != 3);
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Opcion invalida, intente de nuevo.");
                        break;
                }

            } while (opcion != 7);
        }
    }
}
