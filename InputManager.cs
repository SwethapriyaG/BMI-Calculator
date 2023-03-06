using System;
using System.Collections.Generic;
using System.Text;

namespace BMIcalculator
{
    class InputManager
    {
        public string userInputText() // Metod att ta infromation från avändaren
        {
            return Console.ReadLine(); // tar input från avändaren
        }
        public int userInputNumber(int min, int max) // Metod för användaren input nummer 
        {
            int number = 0; 
            bool validNumber = false;
            while (validNumber != true) // while loop att ta korrekt input nummer från användaren
            {
                string input = userInputText(); // tar använders input från userInputText metod och lagra i string variable
                Int32.TryParse(input, out number); // ändrar string variable till int variable
                if (number <= max && number >= min) // condition för använders input måste ha bara som mindre och maximal nummer
                {
                    Console.WriteLine("ok, " + number + ".");// Visar nummer
                    validNumber = true; // Sedan validNumber ska bli true.
                }
                else // om condition är fel måste visa en meddelande som måste ge en rätt nummer
                {
                    Console.WriteLine("Inte ett giltigt nummer, försök igen använd ett nummer mellan" + min + "and" + max + ".");
                }
            }
            return number; // om condition nöjd lämna tillbacka  nummer
        }
        public float userInputFloat() // Metod för tar nummer från använder
        {
            float number = 0f; 
            bool validFloat = false;
            while (validFloat != true) //while loop att ta korrekt input nummer från användaren
            {
                string input = userInputText();// tar använders input från userInputText metod och lagra i string variable
                float.TryParse(input, out number); // ändrar string variable till int variable
                if (number != 0f) // condtion för använder nummer måste inte ha null
                {
                    Console.WriteLine("ok, " + number + ".");// Visar nummer
                    validFloat = true; // Sedan validNumber ska bli true.
                }
                else // om condition är fel måste visa en meddelande som måste ge en rätt nummer
                {
                    Console.WriteLine("Inte en giltig inmatning, försök igen.");
                }
            }
            return number; // om condition nöjd lämna tillbacka  nummer
        }
    }
}
