using System;

namespace tp8_Punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int menosUno = -1;
            const int dias = 5;

            string[] diasSemana = {"Lunes", "Martes", "Miercoles", "jueves", "Viernes"};

            for (int i = dias-1; i > menosUno; i--)
            {
                Console.WriteLine("Elemento " + i + ": " + diasSemana[i]);

            }

            Console.WriteLine("Presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
