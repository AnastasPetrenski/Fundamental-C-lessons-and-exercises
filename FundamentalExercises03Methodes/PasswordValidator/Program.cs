using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] arrPass = password.ToCharArray();
            if (PasswordLengthValidator(password) && 
                CheckPasswordContentLettersAndDigitsOnly(arrPass) && 
                CheckPasswordMinDigitsContent(arrPass))
            {
                Console.WriteLine("Password is valid");
            }

            if (!PasswordLengthValidator(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!CheckPasswordContentLettersAndDigitsOnly(arrPass))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!CheckPasswordMinDigitsContent(arrPass))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool PasswordLengthValidator(string password)
        {
            bool isValid = false; 
            if (password.Length >= 6 && password.Length <= 10)
            {
                isValid = true;
            }

            return isValid;
        }

        static bool CheckPasswordContentLettersAndDigitsOnly(char[] arrPass)
        {
            bool isValid = true;
            for (int i = 0; i < arrPass.Length; i++)
            {
                int currElement = arrPass[i];
                if ((currElement >= 48 && currElement <= 57) || 
                    (currElement >= 65 && currElement <= 90) ||
                    (currElement >= 97 && currElement <= 122))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }

        static bool CheckPasswordMinDigitsContent(char[] arrPass)
        {
            bool isValid = false;
            int count = 0;
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < arrPass.Length; i++)
            {
                char currElement = arrPass[i];
                if (digits.Contains(currElement))
                {
                    count++;
                }
            }

            if (count > 1)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
