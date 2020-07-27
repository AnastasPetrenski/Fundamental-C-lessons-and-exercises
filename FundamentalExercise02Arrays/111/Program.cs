using System;
using System.Linq;

namespace _10_LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine()); //четем входните данни
            int[] indexes = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int[] initialField = new int[fieldSize]; //създаваме си полето
            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] < initialField.Length
                    && indexes[i] >= 0)
                {
                    initialField[indexes[i]] = 1; //определяме къде първоначално име калинка
                }
            }

            string input = Console.ReadLine();
            string[] command = new string[3];

            while (input != "end")
            {
                command = input.Split().ToArray();
                int ladyBug = int.Parse(command[0]); //разделяме командата на трите й части
                string direction = command[1];
                int flyLength = int.Parse(command[2]);

                if (ladyBug < initialField.Length //проверяваме дали подадената позиция е в полето
                    && ladyBug >= 0
                    && initialField[ladyBug] == 1 //и дали там има калинка
                    && flyLength != 0) //и дали тя се мести
                {
                    if (direction == "right") //ако се мести надясно
                    {
                        if (ladyBug + flyLength < initialField.Length //дали премествайки се, е в полето
                            && ladyBug + flyLength >= 0
                            && initialField[ladyBug + flyLength] == 0) //и дали там, където трябва да отиде, е празно
                        {
                            initialField[ladyBug + flyLength] = 1; //ако да, тя заема мястото
                        }
                   else if (ladyBug + flyLength < initialField.Length
                                 && ladyBug + flyLength >= 0
                                 && initialField[ladyBug + flyLength] == 1) //ако обаче там не е празно
                        {
                            while (ladyBug + flyLength < initialField.Length
                                   && ladyBug + flyLength >= 0
                                   && initialField[ladyBug + flyLength] == 1) //продължава напред със същия брой движения ДОКАТО не открие празно място
                            {
                                flyLength += flyLength; //затова увеличаваме хода със същия брой движения
                                if (ladyBug + flyLength < initialField.Length
                                    && ladyBug + flyLength >= 0 // а тази проверка е в случай, че числото е ОТРИЦАТЕЛНО, за да не излезе от полето НАЛЯВО
                                    && initialField[ladyBug + flyLength] == 0)
                                {
                                    initialField[ladyBug + flyLength] = 1; //ако открие празна позиция, я заема
                                    break; //и излизаме от while-цикъла
                                }
                            }
                        }
                    }
                    else if (direction == "left") //прилагаме същата логика и за движение наляво
                    {
                        if (ladyBug - flyLength >= 0 // само че тук движението е с минус
                            && ladyBug - flyLength < initialField.Length
                            && initialField[ladyBug - flyLength] == 0)
                        {
                            initialField[ladyBug - flyLength] = 1;
                        }
                   else if (ladyBug - flyLength >= 0
                                 && ladyBug - flyLength < initialField.Length
                                 && initialField[ladyBug - flyLength] == 1)
                        {
                            while (ladyBug - flyLength >= 0 // ДОКАТО (while) не открие празна позиция
                                   && ladyBug - flyLength < initialField.Length
                                   && initialField[ladyBug - flyLength] == 1)
                            {
                                flyLength += flyLength; // тук си е плюс, а не минус, въпреки че е наляво, но... за да не ходи напред-назад
                                if (ladyBug - flyLength >= 0
                                    && ladyBug - flyLength < initialField.Length
                                    && initialField[ladyBug - flyLength] == 0)
                                {
                                    initialField[ladyBug - flyLength] = 1;
                                    break;
                                }
                            }
                        }
                    }

                    initialField[ladyBug] = 0; //ако сме влезли в най-първата if проверка, значи при всички случаи, е излетяла от първоначалната си позиция
                }

                input = Console.ReadLine(); // да не забравяме да се върнем към началото на първия while цикъл с нова команда
            }

            Console.WriteLine(String.Join(" ", initialField)); //и естествено, си принтираме полето след всички движения
        }
    }
}