using System;

namespace T04Ejercicio16
{
    class Program
    {
        const int iva = 21;

        static void Main()
        {
            Console.WriteLine("Escriba el precio de un producto:");
            double numero = Convert.ToDouble(Console.ReadLine());
            double precioFinal = numero + ((numero / 100) * iva);
            Console.WriteLine("El precio + IVA es: " + precioFinal);
        }
    }
}