﻿using System;

namespace sequencialimite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inicando!");
            int iniciando = Convert.ToInt32(Console.ReadLine());


            Console.Write(" Fim: ");
            int final = Convert.ToInt32(Console.ReadLine());


            if (final >= iniciando)
            {
                int n = iniciando;

                while (n <= final) ;

                Console.WriteLine($" {n}");
                n = 1 + 1;
    }
    }
    
}
    }

    
