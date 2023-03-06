using System;

namespace BMIcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ProMananger programManager = new ProMananger(); // Declerar objekt från ProManager klass
            programManager.Start(); // Ingångspunkt till applikationen
        }
    }
}
