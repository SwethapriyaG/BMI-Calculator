using System;
using System.Collections.Generic;
using System.Text;

namespace BMIcalculator
{
    class ProMananger
    {
        public void Start() // Metod att börja och fungerar meny
        {
            MenuManager menuManager = new MenuManager(); // declerar objekt från MenuManager klass
            InputManager inputManager = new InputManager(); // declerar objekt från InputManager klass
            bool programOn = true;  // Declerar variable
            int choice, minChoice, maxChice;
            minChoice = 1; // Ger värde
            maxChice = 2;
            while (programOn == true) // while loop för reparera meny 
            {
                menuManager.StartMenu(); // Kallar metod att skriv ut meny
                choice = inputManager.userInputNumber(minChoice, maxChice); // kallar metod eftersom användas val ska ha bara mindre och max val 
                switch (choice) // switch case att fungera några endast utvalda saker 
                {
                    case 1: // beräknande en persons BMI
                        string name; // declerar variable
                        int age;
                        float length, weight;
                        Person person; // använder variable från person klass
                        BMIcal bmiCalculator = new BMIcal(); // Declerar objekt från annan klass
                        menuManager.StartCreatePerson(); // Kallar metod och initierar till objekt
                        name = inputManager.userInputText(); // Kallar metod från annan klass och initierar till variable
                        age = inputManager.userInputNumber(1, 200);// Kallar metod från annan klass och initierar till variablerna sedan paserar arguments val
                        length = inputManager.userInputFloat(); // Kallar metod från annan klass och initierar till variable
                        weight = inputManager.userInputFloat(); // Kallar metod från annan klass och initierar till variable

                        person = new Person(name, age, length, weight); // passerar variablerna till objekt 
                        
                        Console.WriteLine("Name:" + person.Name); // visar person namn 
                        Console.WriteLine("Ålder:" + person.Age); // visar person ålder 
                        Console.WriteLine("Längd:" + person.Length); // visar person längd 
                        Console.WriteLine("Vikt:" + person.Weight); // visar person vikt 

                        Console.WriteLine(bmiCalculator.BMICalculatorStart(person.Length, person.Weight)); // visar BMI
                        break;
                    case 2: // andra case
                        menuManager.QuitProgram(); // Kallar metod för sluta program
                        programOn = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
