using System;

namespace Array_challange1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            string inputValueType;

            Console.WriteLine("Please enter any value");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");
            Console.Write("Enter now your selected value: ");


            string inputType = Console.ReadLine();
            int inputTypeInt = int.Parse(inputType);

            switch (inputTypeInt)
            {
                case 1:
                    isValid = AllLetters(inputValue);
                    inputValueType = "string";
                    break;
                case 2:
                    int parsedValue = 0;
                    isValid = int.TryParse(inputValue, out parsedValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool parsedValue2 = false;
                    isValid = bool.TryParse(inputValue, out parsedValue2);
                    inputValueType = "Boolean";
                    break;
                default:
                    inputValueType = "Unknown";
                    Console.WriteLine("An error occured! Keep trying, tiger!");
                    break;
            }

            Console.WriteLine($"You have entered the value: {inputValue}");
            if (isValid)
            {
                Console.WriteLine($"It is valid! It's indeed a {inputValueType}");
            }
            else
            {
                Console.WriteLine($"It is invalid! It is not a {inputValueType}!");
            }

        }
        

        static bool AllLetters(string value)
        {
            foreach(char c in value)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
