﻿using System;

namespace SystemBancario
{
    class Inversionistas : IDivisasUSA
    {
        public void Actualizar()
        {

            if (DivisasUSA.Acciones >= 54 && DivisasUSA.Acciones <= 58)
            {
                double dolaractual = 58.30;
                int multi = 2;
                double total = dolaractual * multi;
                Console.WriteLine("Las acciones estan subiendo!!");
                Console.WriteLine($"vendiendo dolares  {total}");

            }
        }
    }
}
