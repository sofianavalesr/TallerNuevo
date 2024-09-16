using System;

namespace Conversor_Unidades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menú de opciones
            Console.WriteLine("Conversor de Unidades");
            Console.WriteLine("1. Convertir metros a pies");
            Console.WriteLine("2. Convertir pies a metros");
            Console.WriteLine("Selecciona una opción: ");
            
            // Lee la opción seleccionada por el usuario y la convierte a un entero
            int opcion = Convert.ToInt32(Console.ReadLine());
            
            // Solicita al usuario que ingrese una medida para hacer la conversión
            Console.WriteLine("Ingresa la medida: ");
            string medida = Console.ReadLine();
            
            // Almacena el valor numérico de la medida ingresada
            double valor;
            
            // Verifica si la medida ingresada puede convertirse a un double
            if (double.TryParse(medida, out valor))
            {
                // Ejecuta la opción seleccionada por el usuario
                switch (opcion)
                {
                    // Caso 1: convertir de metros a pies
                    case 1:
                        Console.WriteLine($"Resultado: {MetrosAPies(valor):F2} pies");
                        break;
                    
                    // Caso 2: convertir de pies a metros
                    case 2:
                        Console.WriteLine($"Resultado: {PiesAMetros(valor):F2} metros");
                        break;

                    // Si se ingresa una opción inválida
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
            else
            {
                // Muestra un mensaje de error si la medida ingresada no es válida
                Console.WriteLine("Medida inválida. Debe ser un número.");
            }
        }

        // Método para convertir metros a pies
        static double MetrosAPies(double metros)
        {
            return metros * 3.28084; // 1 metro = 3.28084 pies
        }

        // Método para convertir pies a metros
        static double PiesAMetros(double pies)
        {
            return pies * 0.3048; // 1 pie = 0.3048 metros
        }
    }
}
