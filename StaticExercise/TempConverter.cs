using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double number)
        {
            var number2 = number - 32;
            return number2 *= .5556;
        }

        public static double CelsiusToFahrenheit(double number)
        {
            return number * 1.8 + 32;
        }
    }
}
