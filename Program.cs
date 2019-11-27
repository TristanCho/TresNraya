using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresNraya
{
    class Program
    {
        int car = -1;
        static char[,] matriz;
        static void Main(string[] args)
        {
            int car = -1;
            bool continuar = true;
            int estadoPartida; // 0 - Partida en curso, 1 Victoria, 2 Derrota
            do {
                estadoPartida = 0;
                matriz = new char[3, 3];

                IniciarTablero();
                while (estadoPartida == 0)
                {
                    mueve_player();
                    mueve_maquina();

                    Console.WriteLine("\n ¿Nueva partida? [Y/N]");
                    car = Console.Read();
                }
            } 
            while (car != 89 && car != 78);
            if (car == 78)
            {
                continuar = false;
            }
            while (continuar) ;
            
        }

        static void IniciarTablero()
        {
            Console.WriteLine("TRES EN RAYA:\n");
            Console.WriteLine("   " + " A" + "  " + " B " + "  " + "C ");
            Console.WriteLine("1   " + matriz[0, 0] + " | " + matriz[0, 1] + "  | " + matriz[0, 2] + " ");
            Console.WriteLine("  ----+----+----");
            Console.WriteLine("2   " + matriz[1, 0] + " | " + matriz[1, 1] + "  | " + matriz[1, 2] + " ");
            Console.WriteLine("  ----+----+----");
            Console.WriteLine("3   " + matriz[2, 0] + " | " + matriz[2, 1] + "  | " + matriz[2, 2] + " ");
        }
        static void mueve_player()
        {
            Console.WriteLine("Introduce Posición");
           
        }
        static void mueve_maquina()
        {
            Console.WriteLine("Maquina moviendo...");
        }
               
    }
}

