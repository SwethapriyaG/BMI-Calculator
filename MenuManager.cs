using System;
using System.Collections.Generic;
using System.Text;

namespace BMIcalculator
{
    class MenuManager
    {
        private int breakLineLength; // Declerar int variable 
        public MenuManager() // konstruktor 
        {
            breakLineLength = 40; // initialiseringsvärde till int-variabel

        }
        public void StartMenu() // metod för starta meny
        {
            BreakLine(); // kallar metoden att skriv ut raden
            StartMenuText(); // kallar metoden att skriva meny
        }
        public void StartCreatePerson() // Declerar Metod 
        {
            BreakLine(); // kallar metoden att skriva raden
            CreatePersonText(); // kallar metoden att visa person information
        }
        public void QuitProgram() // Declerar metod att utgång program
        {
            BreakLine('_', breakLineLength); // Skrivar en reden 
            QuitProgramText(); // Kallar metod att visa utgång program information 
            BreakLine(); // kallar metoden att skriv ut raden
        }
        private void StartMenuText() // metod för visa meny
        {
            Console.WriteLine("Välkommen BMI-kalkylatorn"); // visar välkommen meddelande till använderen
            BreakLine('_', breakLineLength); // kallar metoden att skriv ut raden
            Console.WriteLine("Gör ett av följande val"); // information till använderen att ta en val 
            Console.WriteLine("1: Beräkna BMI för en person."); // forsta val
            Console.WriteLine("2: Avsluta program."); // andra val
            Console.WriteLine("\nval:");
        }
        private void CreatePersonText()  // Metod att visa person infromation
        {
            Console.WriteLine("Välkommen här kan du föra in data om en person."); 
            Console.WriteLine("Skriv ett värde i taget och tryck enter.");
            BreakLine('_', breakLineLength); //kallar metoden att skriv ut raden
            Console.WriteLine("Namn\nÅlder\nLängd i meter\nvikt i kg."); // persons information 
            Console.WriteLine("Mata in data:");
        }
        private void QuitProgramText() // Metod för visa en meddelande efter utgång från program
        {
            Console.WriteLine("*Hej då och hoppas vi ses snart*");
        }
        private void BreakLine() // Metod att skriv ut linjen
        {
            BreakLine('*', breakLineLength);
        }
        private void BreakLine(char breakLineType, int lineLength) // Declerar metod och variabler
        {
            string breakLine = new string(breakLineType, lineLength); 
            Console.WriteLine(breakLine);
        }
    }
}
