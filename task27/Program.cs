// принимаем на вход число и выдаём сумму цифр в числе.

int SumDigit(int number) 
{
    int sum = 0;
    int digit = 0;
    
        while(number > 0)
    {
        digit = number % 10; // отрезаем по одной крайней цифре от остатка первоначального числа за каждый цикл
        sum = sum + digit;   // добавляем отрезанное число в сумматор
        number = number / 10;// обрезаем на одну крайнюю цифру первоначальное число за каждый цикл
    }
    return sum;
}

Console.WriteLine("Enter digit");
int number = int.Parse(Console.ReadLine());

int resultP = SumDigit(number);
Console.WriteLine($"Сумма цифр числа {number} = {resultP}");