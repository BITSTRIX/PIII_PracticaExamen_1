using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PIII_PracticaExamen_1
{
    internal class ClsEstudiante
    {
        static public int[] cedula = new int[10];
        static public string[] nombre = new string[10];
        static public double[] promedio = new double[10];
        static public string[] condicion = new string[10];

        public ClsEstudiante()
        {

        }

        public static void InicializarVectores()
        {
            cedula = Enumerable.Repeat(0, 10).ToArray();
            nombre = Enumerable.Repeat(" ", 10).ToArray();
            promedio = Enumerable.Repeat(0.0, 10).ToArray();
            condicion = Enumerable.Repeat(" ", 10).ToArray();

            foreach (int i in cedula)
            {
                Console.WriteLine(i);
            }

            foreach (string i in nombre)
            {
                Console.WriteLine(i);
            }

            foreach (double i in promedio)
            {
                Console.WriteLine(i);
            }
            foreach (string i in condicion)
            {
                Console.WriteLine(i);
            }

            Console.Clear();
            Console.WriteLine("****** Vectores Inicializados ******");
            Console.ReadLine();
        }

        public static void RegistrarEstudiante()
        {

            int cedulaTemp = 0;
            string nombreTemp = " ";
            double promedioTemp = 0.0;
            string condicionTemp = " ";
            Boolean almacenar;
            string opc;


            Console.WriteLine("Ingrese el numero de cedula: ");
            cedulaTemp = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre completo del estudiante: ");
            nombreTemp = Console.ReadLine();
            Console.WriteLine("Ingrese el promedio del estudiante: " + nombreTemp);
            promedioTemp = double.Parse(Console.ReadLine());
            condicionTemp = CondicionEst(promedioTemp);
            if (condicionTemp == null)
            {
                Console.WriteLine("Error al calcular condicion, valor de promedio incorrecto.");
                almacenar = false;
            }
            else
            {
                Console.WriteLine("Cedula\t\tNombre\t\t\t\tPromedio\tCondicion");
                Console.WriteLine("========================================================================================");
                Console.WriteLine($"{cedulaTemp}\t{nombreTemp}\t\t{promedioTemp}\t\t{condicionTemp}");
                Console.WriteLine("========================================================================================");
                Console.WriteLine("\t\t   <PULSE CUALQUIER TECLA PARA CONTINUAR>");
                Console.ReadKey();

                Console.WriteLine("Desea almancer los datos(Y/N)?");
                opc = Console.ReadLine();

                if (opc == "Y" || opc == "y")
                {
                    int valid = BuscarEstudiante(cedulaTemp);
                    if (valid == -1)
                    {
                        almacenar = true;

                        for (int i = 0; i < cedula.Length; i++)
                        {

                            if (cedula[i] == 0 & almacenar == true)
                            {
                                cedula[i] = cedulaTemp;
                                nombre[i] = nombreTemp;
                                promedio[i] = promedioTemp;
                                condicion[i] = condicionTemp;

                                Console.WriteLine("Los datos han sido almacenado correctamente.");
                                Console.ReadLine();
                                i = 11;

                                if (cedula[9] != 0)
                                {
                                    Console.WriteLine("No hay espacio suficiente para almancenar los datos.");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("La cedula ingresada ya existe.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    almacenar = false;
                    Console.WriteLine("Los datos no se almacenaran.");
                    Console.ReadLine();
                }
            }
        }

        public static string CondicionEst(double prom)
        {
            string condicionTemp = "";
            if (prom >= 70)
            {
                condicionTemp = "Aprobado";
                return condicionTemp;

            }
            else if (prom >= 60 && prom < 70)
            {
                condicionTemp = "Aplazado";
                return condicionTemp;
            }
            else if (prom < 60)
            {
                condicionTemp = "Reprobado";
                return condicionTemp;
            }
            else
            {
                Console.WriteLine("Error al calcular, valor de promedio incorrecto.");
                return null;
            }

        }

        public static int BuscarEstudiante(int id)
        {
            for (int i = 0; i < cedula.Length; i++)
            {
                if (cedula[i] == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void ConsultarEstudiante()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cedula del estudiante al consultar:");
            int ced = int.Parse(Console.ReadLine());
            int pos = BuscarEstudiante(ced);
            if (pos != -1)
            {
                for (int i = pos; i < pos + 1; i++)
                {
                    int cedulaTemp = cedula[i];
                    string nombreTemp = nombre[i];
                    double promedioTemp = promedio[i];
                    string condicionTemp = condicion[i];

                    Console.WriteLine("Los datos del estudiante son los siguientes:");
                    Console.WriteLine(" ");
                    Console.WriteLine("Cedula\t\tNombre\t\t\t\tPromedio\tCondicion");
                    Console.WriteLine("========================================================================================");
                    Console.WriteLine($"{cedulaTemp}\t{nombreTemp}\t\t{promedioTemp}\t\t{condicionTemp}");
                    Console.WriteLine("========================================================================================");
                    Console.WriteLine("\t\t   <PULSE CUALQUIER TECLA PARA CONTINUAR>");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("La cedula ingresada no existe. Presione una tecla para continuar"); Console.ReadKey();
            }

        }

        public static void ModificarEstudiante()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cedula del estudiante al consultar:");
            int ced = int.Parse(Console.ReadLine());
            int pos = BuscarEstudiante(ced);
            if (pos != -1)
            {
                for (int i = pos; i < pos + 1; i++)
                {
                    int cedulaTemp = cedula[i];
                    string nombreTemp = nombre[i];
                    double promedioTemp = promedio[i];
                    string condicionTemp = condicion[i];

                    Console.WriteLine("Los datos registrados son los siguientes:");
                    Console.WriteLine(" ");
                    Console.WriteLine("Cedula\t\tNombre\t\t\t\tPromedio\tCondicion");
                    Console.WriteLine("========================================================================================");
                    Console.WriteLine($"{cedulaTemp}\t{nombreTemp}\t\t{promedioTemp}\t\t{condicionTemp}");
                    Console.WriteLine("========================================================================================");
                    Console.WriteLine("\t   <PULSE CUALQUIER TECLA PARA INGRESAR LOS NUEVOS DATOS");
                    Console.ReadKey();
                    Console.WriteLine("Ingrese la cedula: ");
                    cedulaTemp = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nombre completo del estudiante: ");
                    nombreTemp = Console.ReadLine();
                    Console.WriteLine("Ingrese el promedio del estudiante: " + nombreTemp);
                    promedioTemp = double.Parse(Console.ReadLine());
                    condicionTemp = CondicionEst(promedioTemp);
                    Console.WriteLine("Los nuevos datos son los siguientes:");
                    Console.WriteLine(" ");
                    Console.WriteLine("Cedula\t\tNombre\t\t\t\tPromedio\tCondicion");
                    Console.WriteLine("========================================================================================");
                    Console.WriteLine($"{cedulaTemp}\t{nombreTemp}\t\t{promedioTemp}\t\t{condicionTemp}");
                    Console.WriteLine("========================================================================================");
                    Console.WriteLine("\t\t   <PULSE CUALQUIER TECLA PARA CONTINUAR>");
                    Console.ReadKey();

                    Console.WriteLine("Desea almancer los datos(Y/N)?");
                    string opc = Console.ReadLine();

                    if (opc == "Y" || opc == "y")
                    {
                        int valid = BuscarEstudiante(cedulaTemp);
                        if (valid == -1 || pos == valid)
                        {
                            Boolean almacenar = true;
                            if (almacenar == true)
                            {
                                cedula[i] = cedulaTemp;
                                nombre[i] = nombreTemp;
                                promedio[i] = promedioTemp;
                                condicion[i] = condicionTemp;
                                Console.WriteLine("Los datos han sido almacenado correctamente.");
                                Console.ReadLine();
                            }
                            else
                            {
                                almacenar = false;
                                Console.WriteLine("Los datos no se almacenaran.");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("La cedula ingresada ya existe.");
                            Console.ReadKey();
                        }
                    }


                }
            }

        }

        public static void EliminarEstudiante()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cedula del estudiante a eliminar:");
            int ced = int.Parse(Console.ReadLine());
            int pos = BuscarEstudiante(ced);
            if (pos != -1)
            {
                for (int i = pos; i < pos + 1; i++)
                {
                    int cedulaTemp = cedula[i];
                    string nombreTemp = nombre[i];
                    double promedioTemp = promedio[i];
                    string condicionTemp = condicion[i];

                    Console.WriteLine("Los datos registrados son los siguientes:");
                    Console.WriteLine(" ");
                    Console.WriteLine("Cedula\t\tNombre\t\t\t\tPromedio\tCondicion");
                    Console.WriteLine("========================================================================================");
                    Console.WriteLine($"{cedulaTemp}\t{nombreTemp}\t\t{promedioTemp}\t\t{condicionTemp}");
                    Console.WriteLine("========================================================================================");
                    Console.WriteLine("\t   <PULSE CUALQUIER TECLA PARA CONFIRMAR LA ELIMINACION>");
                    Console.ReadKey();
                    Console.WriteLine("Desea eliminar los datos(Y/N)?");
                    string opc = Console.ReadLine();
                    if (opc == "Y" || opc == "y")
                    {
                        cedula[i] = 0;
                        nombre[i] = "";
                        promedio[i] = 0.0;
                        condicion[i] = "";


                        Console.WriteLine("Los datos han sido eliminados correctamente.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Los datos no se eliminaran.");
                        Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("La cedula ingresada no existe en la base de datos.");
                Console.Read();
            }
        }

        public static void ExtraerEstudiante(int pos)
        {
            if (pos != -1)
            {
                for (int i = pos; i < pos + 1; i++)
                {
                    int cedulaTemp = cedula[i];
                    string nombreTemp = nombre[i];
                    double promedioTemp = promedio[i];
                    string condicionTemp = condicion[i];
                    Console.WriteLine($"{cedulaTemp}\t{nombreTemp}\t\t{promedioTemp}\t\t{condicionTemp}");

                }
            }

        }
    }
}
