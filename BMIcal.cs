using System;
using System.Collections.Generic;
using System.Text;

namespace BMIcalculator
{
    class BMIcal
    {
        public string BMICalculatorStart(float length, float weight) // Declerar metod och variabler 
        {
            return BMICalculatorText(Calculation(length, weight)); // lämnar BMI 
        }
        private string BMICalculatorText(float bmi) // metod för visa BMI 
        {
            string text = "Din BMI är:" + bmi; // declerar bmi till string variable 
            return text; // lämnar tillbaka variable
        }
        private float Calculation(float length, float weight) // metod och varibaler för beräkning
        {
            Console.WriteLine(length + " " + weight);
            float bmi = (float)Math.Round(weight / (length * length), 3); // beräkning BMI värde
            return bmi; // lämna tillbaka bmi
        }
    }
}
