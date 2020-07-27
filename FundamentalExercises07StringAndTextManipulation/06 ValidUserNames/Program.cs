    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace _06_ValidUserNames
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<string> users = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var user in users)
                {
                    bool isValid = true;
                    for (int i = 0; i < user.Length; i++)
                    {
                        if (!char.IsLetterOrDigit(user[i]) && user[i] != '-' && user[i] != '_')
                        {
                            isValid = false;
                        }
                    }


                    if (user.Length >= 3 && user.Length <= 16 && isValid)
                    {
                        Console.WriteLine(user);
                    }
                }
            }
        }
    }
