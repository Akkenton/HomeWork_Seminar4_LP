//     Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.  
//     452 -> 11  
//     82 -> 10  
//     9012 -> 12


//  ----------------------------------- START

int AddNumber(string str)
{
    Console.WriteLine(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int SummOfNumbers(int num)
{
    int result = 0;
    while (num != 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

// ---------- Исполнение ----------------

int num = AddNumber("Введите число: ");
int result = SummOfNumbers(num);
Console.WriteLine($"Сумма составных чисел числа {num} равна {result}");

//  --------------------------------------END