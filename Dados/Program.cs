using System;

namespace Dados
{
    class Program
    {
        static void Main(string[] args)
        {   while(Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Nueva visualizacion");
                DibujarDado(4, 5, 1);
                
            }

           
            
            
        
        }

        static void DibujarDado(int caraSuperior, int caraFrontal, int caraIsquierda)
        {

            Console.WriteLine("                     ###########            ");
            Console.WriteLine("                     #         #");
            Console.WriteLine("                     #    {0}    #", caraSuperior);
            Console.WriteLine("                     #         #");
            Console.WriteLine("#########################################");
            Console.WriteLine("#         #          #          #       #");
            Console.WriteLine("#   {1}     #     {2}    #    {0}     #   {3}   #", caraFrontal, Math.Abs(caraFrontal - 7), caraIsquierda, Math.Abs(caraIsquierda - 7));
            Console.WriteLine("#         #          #          #       #");
            Console.WriteLine("#########################################");
            Console.WriteLine("                     #         #");
            Console.WriteLine("                     #    {0}    #", Math.Abs(caraSuperior - 7));
            Console.WriteLine("                     #         #");
            Console.WriteLine("                     ###########            ");
        }

    }
}
