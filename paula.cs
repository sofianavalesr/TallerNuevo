using System;

class ConversorTemperatura
{
    // Función para convertir de Celsius a Fahrenheit
    public static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    // Función para convertir de Fahrenheit a Celsius
    public static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Función para validar que el dato ingresado sea un número válido
    public static double ObtenerTemperatura(string mensaje)
    {
        double temperatura;
        bool esValido;

        do
        {
            Console.WriteLine(mensaje);
            string entrada = Console.ReadLine();
            esValido = double.TryParse(entrada, out temperatura);

            if (!esValido)
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
        }
        while (!esValido);

        return temperatura;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Conversor de Temperaturas");
        Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
        Console.WriteLine("2. Convertir de Fahrenheit a Celsius");
        Console.Write("Selecciona la conversión deseada (1 o 2): ");
        
        string opcion = Console.ReadLine();
        
        switch (opcion)
        {
            case "1":
                // Convertir de Celsius a Fahrenheit
                double celsius = ObtenerTemperatura("Ingresa la temperatura en grados Celsius: ");
                double resultadoF = CelsiusAFahrenheit(celsius);
                Console.WriteLine($"La temperatura en Fahrenheit es: {resultadoF:F2}°F");
                break;

            case "2":
                // Convertir de Fahrenheit a Celsius
                double fahrenheit = ObtenerTemperatura("Ingresa la temperatura en grados Fahrenheit: ");
                double resultadoC = FahrenheitACelsius(fahrenheit);
                Console.WriteLine($"La temperatura en Celsius es: {resultadoC:F2}°C");
                break;

            default:
                Console.WriteLine("Opción no válida. Por favor, selecciona 1 o 2.");
                break;
        }
    }
}
