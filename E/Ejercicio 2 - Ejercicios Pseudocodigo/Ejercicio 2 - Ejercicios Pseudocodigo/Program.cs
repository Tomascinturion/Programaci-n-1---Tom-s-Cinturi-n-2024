﻿using System;
using System.ComponentModel.Design;

Console.WriteLine("Ingrese el numero");
int numero = int.Parse(Console.ReadLine());
if (numero % 2 == 0) 
    {
      Console.WriteLine("Es Par");
    }
else
{
    Console.WriteLine("Es Impar");
}