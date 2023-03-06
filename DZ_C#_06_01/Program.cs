/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

System.Console.WriteLine("Введите чисела через запитую:");
int[] namber = Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
int SummNambers(int[] arrey)
{
    int summ = 0;
    for (int i = 0; i < namber.Length; i++)
    {
        if (namber[i] > 0)
        {
            summ++;
        }
    }
    return summ;
}
int sum = SummNambers(namber);
System.Console.WriteLine($"Чисел больше нуля: {sum}");