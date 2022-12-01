//     Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.  
//     3, 5 -> 243 (3⁵)  
//     2, 4 -> 16
// ***Не однозначно понимание задачи - принимать числа в теле цикла или принять два числа а циклом решить возведение в степень.
// Исходя из логики - принимаем два числа без цикла, а в цикле решаем задачу возведения в степень ***


//  ----------------------------------- START

int AddNumber(string str)
{
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int FindPowNum(int numA, int numB)
{
    int result = numA;
    for (var i = 1; i < numB; i++)
    {
        result = result * numA;
    }
    return result;
}

void PrintPow(int result, int numA, int numB)
{
    Console.WriteLine($"Результат возведения числа {numA} в натуральную степерь {numB} : {result}");
}


// ---------- Исполнение ----------------
Console.Clear();
int numberA = AddNumber("Введите число А: ");
int numberB = AddNumber("Введите число В: ");
Console.WriteLine($"Задача: необходимо число {numberA} возвести в степень {numberB}. Нажмите Enter для решения задачи...");
Console.ReadLine();
if (numberB == 0) Console.WriteLine($"Результат возведения числа {numberA} в натуральную степерь {numberB} : 1. Потому-то любое число в нулевой степени равно 1!"); // условие-проверка, если число возводится в нулевую степень
else
{
    int result = FindPowNum(numberA, numberB);
    PrintPow(result, numberA, numberB);
}

//  --------------------------------------END