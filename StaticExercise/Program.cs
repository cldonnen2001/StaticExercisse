using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(73);  // w/out readline
            var fahrenheit = TempConverter.CelsiusToFahrenheit(12);  // w/out readline

            Console.WriteLine($"Fahrenheit to Celcius is {celsius}");
            Console.WriteLine($"Celsius to Fahrenheit is {fahrenheit}");

            //  John way

            // Console.WriteLine(TempConverter.FahrenheitToCelsius(32));
            // Console.WriteLine(empConverter.CelsiusToFahrenheit(0));
            // Console.WriteLine(empConverter.CelsiusToFahrenheit(100));
            //  Console.WriteLine(TempConverter.FahrenheitToCelsius(212));
        }
    }
}
