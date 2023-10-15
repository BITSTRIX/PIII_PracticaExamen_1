using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PIII_PracticaExamen_1
{
    internal class ClsReportes
    {
        public static void ReporteCondicion(int opc)
        {
            Console.WriteLine("Cedula\t\tNombre\t\t\t\tPromedio\tCondicion");
            Console.WriteLine("========================================================================================");
            if (opc == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (ClsEstudiante.condicion[i] == "Aprobado")
                    {
                        Console.WriteLine($"{ClsEstudiante.cedula[i]}\t{ClsEstudiante.nombre[i]}\t\t{ClsEstudiante.promedio[i]}\t\t{ClsEstudiante.condicion[i]}");
                    }
                }
                Console.WriteLine("========================================================================================");
                Console.WriteLine("\t\t   <PULSE CUALQUIER TECLA PARA CONTINUAR>");
                Console.ReadKey();
            }
            else if (opc == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (ClsEstudiante.condicion[i] == "Aplazado")
                    {
                        Console.WriteLine($"{ClsEstudiante.cedula[i]}\t{ClsEstudiante.nombre[i]}\t\t{ClsEstudiante.promedio[i]}\t\t{ClsEstudiante.condicion[i]}");
                    }
                }
                Console.WriteLine("========================================================================================");
                Console.WriteLine("\t\t   <PULSE CUALQUIER TECLA PARA CONTINUAR>");
                Console.ReadKey();
            }
            else if (opc == 3)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (ClsEstudiante.condicion[i] == "Reprobado")
                    {
                        Console.WriteLine($"{ClsEstudiante.cedula[i]}\t{ClsEstudiante.nombre[i]}\t\t{ClsEstudiante.promedio[i]}\t\t{ClsEstudiante.condicion[i]}");
                    }
                }
                Console.WriteLine("========================================================================================");
                Console.WriteLine("\t\t   <PULSE CUALQUIER TECLA PARA CONTINUAR>");
                Console.ReadKey();
            }
        }

        public static void ReporteGeneral()
        {
            int cantidadEst = 0;
            double notaMinima = 100; double notaMaxima = -1;
            Console.WriteLine("Cedula\t\tNombre\t\t\t\tPromedio\tCondicion");
            Console.WriteLine("========================================================================================");
            for (int i = 0; i < 10; i++)
            {
                if (ClsEstudiante.cedula[i] != 0)
                {
                    Console.WriteLine($"{ClsEstudiante.cedula[i]}\t{ClsEstudiante.nombre[i]}\t\t{ClsEstudiante.promedio[i]}\t\t{ClsEstudiante.condicion[i]}");
                    cantidadEst += 1;
                    if (ClsEstudiante.promedio[i] < notaMinima)
                    {
                        notaMinima = ClsEstudiante.promedio[i];
                    }
                    if (ClsEstudiante.promedio[i] > notaMaxima)
                    {
                        notaMaxima = ClsEstudiante.promedio[i];
                    }
                }
            }

            Console.WriteLine("========================================================================================");
            Console.WriteLine("\t\t   <PULSE CUALQUIER TECLA PARA CONTINUAR>");
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.WriteLine($"La cantidad de estudiantes es de: {cantidadEst}");
            Console.WriteLine(" ");
            Console.WriteLine("Los estudiantes con el promedio minimo son: ");
            Console.WriteLine(" ");
            Console.WriteLine("Cedula\t\tNombre\t\t\t\tPromedio\tCondicion");
            Console.WriteLine("========================================================================================");
            for (int i = 0; i < 10; i++)
            {
                if (ClsEstudiante.promedio[i] == notaMinima)
                {
                    ClsEstudiante.ExtraerEstudiante(i);
                }
            }
            Console.WriteLine("========================================================================================");
            Console.WriteLine(" ");
            Console.WriteLine("Los estudiantes con el promedio Maximo son: ");
            Console.WriteLine(" ");
            Console.WriteLine("Cedula\t\tNombre\t\t\t\tPromedio\tCondicion");
            Console.WriteLine("========================================================================================");
            for (int i = 0; i < 10; i++)
            {
                if (ClsEstudiante.promedio[i] == notaMaxima)
                {
                    ClsEstudiante.ExtraerEstudiante(i);
                }
            }
            Console.WriteLine("========================================================================================");
            Console.ReadLine();

        }
    }
}
