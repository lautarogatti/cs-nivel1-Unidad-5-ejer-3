using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años. */
            
            int acu = 0, con = 0, resultado, n;
            for (int i = 0; i < 20; i++)
            {
             Console.WriteLine("Ingrese una edad"); 
             n = int.Parse(Console.ReadLine());
             if(n > 18){
                con ++;
                acu += n;
                }  
            }
            resultado = acu / con; 
            Console.WriteLine("El promedio es " + resultado);
        }
    }
}
