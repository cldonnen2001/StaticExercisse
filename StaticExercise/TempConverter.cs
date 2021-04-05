using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
       public static double FahrenheitToCelsius(double fahrenheit)
       {
          var result = (fahrenheit-32) / 1.8;
            return result;
       }
       public static double CelsiusToFahrenheit(double celsius)
       {
            var result = (celsius * 9) / 5 + 32;
            return result;
        }

        //John way

        // public static double F = 0;
        // public static double C = 0;
        // public static double FahrenheitToCelsius(double fTemp) 
        // {
        // C = (fTemp - 32) / 1.8000;
        // return C;
        // }

        // public static double CelsiusToFahrenheit(double cTemp)
        // {
        // F = (cTemp * (9/5)) + 32;;
        // return F;
        // }



    }
}
