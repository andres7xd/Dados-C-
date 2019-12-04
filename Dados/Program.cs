using System;

namespace Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la aplicación en c#");
            Console.WriteLine("Presion ESC para terminar la aplicación");
            Console.WriteLine("Presione ENTER para obetener una nueva visualización");
            Console.WriteLine("------------------------------------------------------------");



            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                if(Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Nueva visualizacion");

                    DadoAleatorio();
                }
               
                

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

        static void DadoAleatorio()
        {
            int aux = 0;
            int x, y, z = 0;
            int suma=0;


           
            Random random = new Random();
          
            
           
               
                for(int i=0;i < 2; i++)
                {
                    while (aux == 0)
                    {
                    x = random.Next(1, 7);
                    y = random.Next(1, 7);
                    z = random.Next(1, 7);

                    if (x != y && x != z && y != z && x + y != 7 && x + z != 7 && y + z != 7)
                    {
                        DibujarDado(x, y, z);
                        aux = 1;
                        suma = suma + x;
                    }
                    }

                aux = 0;
               

                 }

            Console.WriteLine("La suma es: {0}",suma);
           



            
        }

    }
}
