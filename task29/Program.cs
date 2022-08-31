//Напишите программу, которая выводит массив из 8 элементов

void WriteMassiv(int[] massive) //метод который заполняет массив
{
    int lenght = massive.Length;
    
    for(int i = 0; i < lenght; i++)
    {
        massive[i] = new Random().Next(0,100); // наполняем массив случайными цифрами от 0 до 99
    }
}

void PrintMassiv(int[] massiv) // метод который выводит массив
{
    int lenght = massiv.Length;
    
    for(int i = 0; i < lenght; i++)
    {
        Console.Write($"{massiv[i]}|");
    }
}

int[] array = new int[8]; //объявляем массив на 8 элементов

WriteMassiv(array);

Console.Write("|");

PrintMassiv(array);
