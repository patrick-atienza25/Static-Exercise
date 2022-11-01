using System.Security.Cryptography.X509Certificates;

namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(99);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(21);
            Console.WriteLine($"99 degrees fahrenheit converted to celsius is {celsius}.");
            Console.WriteLine();
            Console.WriteLine($"21 degrees celsius converted to fahrenheit is {fahrenheit}");
        }
    }
}
