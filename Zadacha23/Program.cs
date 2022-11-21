/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int N = ReadInt("Введите число N: ");
int count = 1;

while(count <= N)
{
    int result = count * count * count;
    Console.Write(result + " ");
    count++;
}



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
