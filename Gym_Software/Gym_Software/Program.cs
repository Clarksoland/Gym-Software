using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Software
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program introduction

            Console.WriteLine("Welcome to the Gym Member checkup program.");
            Console.WriteLine("Press any key to begin.");

            Console.ReadKey();
            Console.Clear();

            //Define variables

            string gender = string.Empty;
            double weight = -1;
            double height = -1;
            int age = -1;
            int activityLevel = -1;
            double bmr = 0;
            double bmi = 0;
            double requiredIntake = 0;

            //Ask for user to input basic information (with appropriate error checking)

            Console.Write("Please enter your gender ('Male' / 'Female' or 'M' / 'F'): ");

            while (true)
            {
                gender = Console.ReadLine().ToLower();

                if (gender == "male" || gender == "m")
                {
                    gender = "male";
                    break;
                }
                else if (gender == "female" || gender == "f")
                {
                    gender = "female";
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write("Please enter a valid gender ('Male' / 'Female' or 'M' / 'F'): ");
                }
            }
            Console.Clear();

            Console.Write("Please enter your weight (in Kilograms): ");

            while (true)
            {
                try
                {
                    weight = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.Write("Please enter a valid weight (in Kilograms): ");
                }

                if (weight <= 0)
                {
                    Console.Clear();
                    Console.Write("Please enter a valid weight (in Kilograms): ");
                }
                else
                {
                    break;
                }
            }
            Console.Clear();

            Console.Write("Please enter your height (in Centimeters): ");

            while (true)
            {
                try
                {
                    height = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.Write("Please enter a valid height (in Centimeters): ");
                }

                if (height <= 0)
                {
                    Console.Clear();
                    Console.Write("Please enter a valid height (in Centimeters): ");
                }
                else
                {
                    break;
                }
            }
            Console.Clear();

            Console.Write("Please enter your age (in Years): ");

            while (true)
            {
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.Write("Please enter a valid age (in Years): ");
                }

                if (age <= 0)
                {
                    Console.Clear();
                    Console.Write("Please enter a valid age (in Years): ");
                }
                else
                {
                    break;
                }
            }
            Console.Clear();

            Console.Write("How often do you exercise? (0: Little to never / 1: 1-3 days per week / 2: 3-5 days per week / 3: 6-7 days per week / 4: twice a day): ");

            while (true)
            {
                try
                {
                    activityLevel = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.Write("Please enter a valid value (0: Little to never / 1: 1-3 days per week / 2: 3-5 days per week / 3: 6-7 days per week / 4: twice a day): ");
                }

                if (activityLevel < 0 || activityLevel > 4)
                {
                    Console.Clear();
                    Console.Write("Please enter a valid value (0: Little to never / 1: 1-3 days per week / 2: 3-5 days per week / 3: 6-7 days per week / 4: twice a day): ");
                }
                else
                {
                    break;
                }
            }
            Console.Clear();

            //Calculate BMR from gathered information

            if (gender == "male")
            {
                bmr = Math.Round(88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age), 2);
            }
            else
            {
                bmr = Math.Round(447.593 + (9.247 * weight) + (3.098 * height) - (4.330 * age), 2);
            }

            //Calculate BMI from gathered information

            bmi = Math.Round(weight / Math.Pow((height / 100), 2), 1);

            //Calculate Required Intake from gathered information

            if (activityLevel == 0)
            {
                requiredIntake = Math.Round(bmr * 1.2);
            }
            else if (activityLevel == 1)
            {
                requiredIntake = Math.Round(bmr * 1.375);
            }
            else if (activityLevel == 2)
            {
                requiredIntake = Math.Round(bmr * 1.55);
            }
            else if (activityLevel == 3)
            {
                requiredIntake = Math.Round(bmr * 1.725);
            }
            else
            {
                requiredIntake = Math.Round(bmr * 1.9);
            }

            //Output calculated information

            Console.WriteLine("Your current BMR is: {0}.", bmr);
            Console.WriteLine("Your current BMI is: {0}.", bmi);
            Console.WriteLine("Your target BMI is: 22.");
            Console.WriteLine("To maintain your current weight level, you mist intake: {0} KCal.", requiredIntake);

            Console.ReadKey();
        }
    }
}
