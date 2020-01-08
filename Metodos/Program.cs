using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = Sumar(10, 12);
            Console.WriteLine(resultado / 2);

            Console.ReadLine();
            ////Console.WriteLine("Hola Mundo");
            ////BorrarConsola();
            ////Console.WriteLine();
            ////Console.WriteLine("Hector");
            //string nombre = Console.ReadLine();
            //Saludar(nombre);
            //Console.ReadLine();
        }

        // Tipo de dato a retornar mas nombre del metodo mas parametro

        static int Sumar(int numero1, int numero2) 
        {

            return (numero1 + numero2);
        }
        static void BorrarConsola(string nombre) 
        {
            Console.WriteLine("Hola " + nombre);
            Console.Beep();
            Console.Clear();
           
        
        }

        static void Saludar(string nombre) 
        {

            Console.WriteLine("Hola" + nombre);
        
        }

        // Body Expression Method - Solo sirve cuando se ejecuta solo unica opcion. Como el siguiente metodo saludar

        static void Saludar() => Console.WriteLine("Hola Raul");
        static int Sumar2(int numero1, int numero2) => numero1 + numero2 ;



    }
}
