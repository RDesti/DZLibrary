using System;

namespace DZLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для начала работы введите номер задачи" + "\n"
                + "1. Найти минимальный элемент одномерного массива" + "\n"
                + "2. Найти максимальный элемент одномерного массива" + "\n"
                + "3. Найти индекс минимального элемента одномерного массива" + "\n"
                + "4. Найти индекс максимального элемента одномерного массива" + "\n"
                + "5. Подсчитать сумму элементов одномерного массива с нечетными индексами" + "\n"
                + "6. Сделать реверс одномерного массива" + "\n"
                + "7. Посчитать количество нечетных элементов одномерного массива" + "\n"
                + "8. Поменять местами первую и вторую половины одномерного массива" + "\n"
                + "9. Отсортировать одномерный массив по возрастанию" + "\n"
                + "10. Отсортировать одномерный массив по убыванию" + "\n"
                + " " + "\n"
                + "11. Решить уравнение вида (5*А+В*В)/(В-А)" + "\n"
                + "12. Поменять содержимое переменных А и В местами" + "\n"
                + "13. Вывести результат деления А на В и остаток от деления" + "\n"
                + "14. Вывести решение линейного уравнения стандартного вида, где А*Х+В=С" + "\n"
                + "15. Вывести уравнения прямой в формате Y=A*X+B, проходящей через две точки" + "\n"
                + " " + "\n"
                + "16. Если А>В, подсчитать А+В, если А=В, подсчитать А*В, если А<В, подсчитать А-В" + "\n"
                + "17. Определить какой четверти принадлежит точка с координатами (X,Y)" + "\n"
                + "18. Вывести 3 числа (А, В и С) в порядке возрастания" + "\n"
                + "19. Вывести решение квадратного уравнения стандартного вида, где A*X*X+B*X+C=0 " + "\n"
                + "20. Вывести прописную запись числа" + "\n"
                + " " + "\n"
                + "21. Возвести число А в степень В" + "\n"
                + "22. Вывести все числа от 1 до 1000, которые делятся на А" + "\n"
                + "23. Найти количество положительных целых чисел, квадрат которых меньше А" + "\n"
                + "24. Вывести наибольший делитель числа А (кроме самого числа А)" + "\n"
                + "25. Вывести сумму всех чисел из диапазона от А до В, которые делятся без остатка на 7." + "\n"
                + "26. Вывести N-ое число ряда фибоначчи" + "\n"
                + "27. Найти наибольший общий делитель двух чисел используя алгоритм Евклида" + "\n"
                + "28. При вводе целого положительного числа, которое является кубом целого числа N. Найти число N методом половинного деления, " + "\n"
                + "29. Найти количество нечетных цифр вводимого числа" + "\n"
                + "30. Найти число, которое является зеркальным отображением последовательности цифр заданного числа" + "\n"
                + "31. Вывести числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных" + "\n"
                + "32. Сообщить есть ли в написании двух чисел одинаковые цифры" + "\n"
                + " " + "\n"
                + "33. Найти минимальный элемент двумерного массива" + "\n"
                + "34. Найти максимальный элемент двумерного массива" + "\n"
                + "35. Найти индекс минимального элемента двумерного массива" + "\n"
                + "36. Найти индекс максимального элемента двумерного массива" + "\n"
                + "37. Найти количество элементов двумерного массива, которые больше всех своих соседей одновременно" + "\n"
                + "38. Отразить двумерный массив относительно его главной диагонали." + "\n"
                + "" + "\n");
            int numberTask = Convert.ToInt32(Console.ReadLine());
            int sizeArray;
            double a;
            double b;
            double c;
            int number;
            switch (numberTask)
            {
                case 1:
                    Console.WriteLine($"введите длину массива:");
                    sizeArray = Convert.ToInt32(Console.ReadLine());
                    Array.CreateAndFill(sizeArray);
                    Console.WriteLine($"Минимальным элементом этого массива является {Array.FindMinElement(Array.CreateAndFill(sizeArray))}");
                    break;
                case 2:
                    Console.WriteLine($"введите длину массива:");
                    sizeArray = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Максимальным элементом этого массива является {Array.FindMaxElement(Array.CreateAndFill(sizeArray))}");
                    break;
                case 3:
                    Console.WriteLine($"введите длину массива:");
                    sizeArray = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Индексом минимального элемента этого массива является {Array.FindIndexMinElement(Array.CreateAndFill(sizeArray))}");
                    break;
                case 4:
                    Console.WriteLine($"введите длину массива:");
                    sizeArray = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Индексом максимального элемента этого массива является {Array.FindIndexMaxElement(Array.CreateAndFill(sizeArray))}");
                    break;
                case 5:
                    Console.WriteLine($"введите длину массива:");
                    sizeArray = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\nСумма всех элементов массива с нечетными индексами равна {Array.SummElemWithOddIndex(Array.CreateAndFill(sizeArray))}");
                    break;
                case 6:
                    Console.WriteLine($"введите длину массива:");
                    sizeArray = Convert.ToInt32(Console.ReadLine());
                    int[] reversArr = Array.GetReversArray(Array.CreateAndFill(sizeArray));
                    Console.WriteLine($"\nРеверсивный массив будет выглядеть следующим образом ");
                    for (int j = 0; j < reversArr.Length; j++)
                    {
                        Console.Write($"{reversArr[j]} ");
                    }
                    break;
                case 7:
                    Console.WriteLine($" + {numberTask}");
                    break;
                case 8:
                    Console.WriteLine($" + {numberTask}");
                    break;
                case 9:
                    Console.WriteLine($" + {numberTask}");
                    break;
                case 10:
                    Console.WriteLine($" + {numberTask}");
                    break;
                case 11:
                    Console.WriteLine($"введите значение а:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Ваш результат {Variables.GetResultOfEquation(a, b)}");
                    break;
                case 12:
                    Console.WriteLine($"введите значение а:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Variables.GetSwap(ref a, ref b);
                    break;
                case 13:
                    Console.WriteLine($"введите значение а:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    double[] div_rem = Variables.GetDivisionResultAndRemainder(a, b);
                    Console.WriteLine($"Результат деления равен {div_rem[0]}, остаток от деления равен {div_rem[1]}");
                    break;
                case 14:
                    Console.WriteLine($"введите значение а:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение с:");
                    c = Convert.ToDouble(Console.ReadLine());
                    double X = Variables.GetSolutionLinearEquation(a, b, c);
                    Console.WriteLine($"х = {X}");
                    break;
                case 15:
                    Console.WriteLine($"введите значение x1:");
                    double x1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение y1:");
                    double y1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение x2:");
                    double x2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение y2:");
                    double y2 = Convert.ToDouble(Console.ReadLine());
                    double[] equationStraight = Variables.GetEquationOfStraightLine(x1, y1, x2, y2);
                    Console.WriteLine($"Уравнение прямой, проходящей через две точки будет выглядеть следующим образом Y = {equationStraight[0]} * X +({equationStraight[1]})");
                    break;
                case 16:
                    Console.WriteLine($"введите значение а:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    double result = Branching.GetSumOrMultiplyOrMinus(a, b);
                    Console.WriteLine($"{result}");
                    break;
                case 17:
                    Console.WriteLine($"введите значение x:");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"введите значение y:");
                    int y = Convert.ToInt32(Console.ReadLine());
                    string s = Branching.DetermineInWhichQuarterPoint(x, y);
                    Console.WriteLine(s);
                    break;
                case 18:
                    Console.WriteLine($"введите значение а:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение c:");
                    c = Convert.ToDouble(Console.ReadLine());
                    string inAscendingOrder = Branching.GetNumbersInAscendingOrder(a, b, c);
                    Console.WriteLine($"Ваш результат {inAscendingOrder}");
                    break;
                case 19:
                    Console.WriteLine($"введите значение а:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение c:");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{Branching.GetSolveToQuadraticEquation(a, b, c)}");
                    break;
                case 20:
                    Console.WriteLine($"введите число:");
                    number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{Branching.PrintInLettersNumber(number)}");
                    break;
                case 21:
                    Console.WriteLine($"введите значение а:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"введите значение b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"{Cycles.GetExponentiation(a, b)}");
                    break;
                case 22:
                    Console.WriteLine($"введите значение а:");
                    number = Convert.ToInt32(Console.ReadLine());
                    Cycles.PrintNumbersThatMultiples(number);
                    break;
                case 23:
                    Console.WriteLine($" + {numberTask}");
                    break;
                case 24:
                    Console.WriteLine($" + {numberTask}");
                    break;
                case 25:
                    Console.WriteLine($" + {numberTask}");
                    break;
                case 26:
                    Console.WriteLine($" + {numberTask}");
                    break;
                case 27:
                    Console.WriteLine($" + {numberTask}");
                    break;
                case 28:
                    Console.WriteLine($"введите длину массива:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Минимальным элементом этого массива является");
                    break;
                case 29:
                    Console.WriteLine($"введите длину массива:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Минимальным элементом этого массива является");
                    break;
                case 30:
                    Console.WriteLine($"введите длину массива:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Минимальным элементом этого массива является");
                    break;
                case 31:
                    Console.WriteLine($"введите длину массива:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Минимальным элементом этого массива является");
                    break;
                case 32:
                    Console.WriteLine($"введите длину массива:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Минимальным элементом этого массива является");
                    break;
                case 33:
                    Console.WriteLine($"введите длину массива:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Минимальным элементом этого массива является");
                    break;
                case 34:
                    Console.WriteLine($"введите длину массива:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Минимальным элементом этого массива является");
                    break;
                case 35:
                    Console.WriteLine($"введите длину массива:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Минимальным элементом этого массива является");
                    break;
                case 36:
                    Console.WriteLine($"введите длину массива:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Минимальным элементом этого массива является");
                    break;
                case 37:
                    Console.WriteLine($"введите длину массива:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Минимальным элементом этого массива является");
                    break;
                case 38:
                    Console.WriteLine($"введите длину массива:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Минимальным элементом этого массива является");
                    break;


            }

        }
    }
}
