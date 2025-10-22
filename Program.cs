using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace codigo_T3
{
    internal class Program
    {
        static void menu()
        {
            Console.WriteLine("Sistema contra insendios: ");
            Console.Write("\n1. Iniciar monitoreo: ");
            Console.Write("\n2. Mostrar historial de eventos: ");
            Console.Write("\n3. Salir \n");
        }
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                menu();
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear(); monitoreo();
                        break;
                    case 2:
                        Console.Clear(); historial();
                        break;
                    case 3: Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese opcion valida. ");
                            Console.WriteLine("");
                            break;
                        }
                }
            } while (opcion != 3);
        }       
        static void historial()
        {
            Console.Write("\n-------Historial de eventos-------\n");
            Console.WriteLine("");
            if (historialEventos.Count == 0)
            {
                Console.WriteLine("No hay eventos registrados aún.");
            }
            else
            {
                foreach (string evento in historialEventos)
                {
                    Console.WriteLine(evento);
                }
            }

            Console.WriteLine("\nPresiona una tecla para volver al menú...");
            Console.ReadKey();
            Console.Clear();
        }
        static void monitoreo()
        {
           float un, dos, tres, cuatro;
           Random num = new Random();
           un = num.Next(25, 101);
           dos = num.Next(25, 101);
           tres = num.Next(25, 101);
           cuatro = num.Next(25, 101); Console.Clear();




            if (un > 57)
            {
                Console.WriteLine("primer sensor: " + un + "°");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("peligro en el primer sensor...");
                historialEventos.Add($"[{DateTime.Now}] Peligro en el primer sensor: {un}°");
                alarma();
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("primer censor: " + un + "°");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Todo funciona correctamente");
                historialEventos.Add($"[{DateTime.Now}] Primer sensor OK: {un}°");
                Console.ResetColor();
            }
            if (dos > 57)
            {
                Console.WriteLine("segundo censor: " + dos + "°"); 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("peligro en el segundo sensor...");
                historialEventos.Add($"[{DateTime.Now}] Peligro en el primer sensor: {un}°");
                alarma();
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("segundo censor: " + dos + "°"); 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Todo funciona correctamente");
                historialEventos.Add($"[{DateTime.Now}] Primer sensor OK: {un}°");
                Console.ResetColor();
            }
            if (tres > 57)
            {
                Console.WriteLine("terser censor: " + tres + "°");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("peligro en el terser sensor...");
                historialEventos.Add($"[{DateTime.Now}] Peligro en el primer sensor: {un}°");
                alarma();
                Console.ResetColor();
            }
            else 
            {
                Console.WriteLine("terser censor: " + tres + "°"); 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Todo funciona correctamente");
                historialEventos.Add($"[{DateTime.Now}] Primer sensor OK: {un}°");
                Console.ResetColor();
            }
            if (cuatro > 57)
            {
                Console.WriteLine("cuarto censor: " + cuatro + "°"); 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("peligro en el cuarto sensor...");
                historialEventos.Add($"[{DateTime.Now}] Peligro en el primer sensor: {un}°");
                alarma();
                Console.ResetColor();
            }
            else 
            {
                Console.WriteLine("cuarto censor: " + cuatro + "°");
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.WriteLine("Todo funciona correctamente");
                historialEventos.Add($"[{DateTime.Now}] Primer sensor OK: {un}°");
                Console.ResetColor(); 
            }
            
        }
        static void alarma()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Beep(1200, 150);
                Console.Beep(1500, 150);
                Console.Beep(1200, 150);
                Console.Beep(1500, 150);
                Thread.Sleep(100);
            }

            Console.Beep(1000, 700);
        }
        static List<string> historialEventos = new List<string>();
    }
}
