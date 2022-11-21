/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
Console.Write("ВВедите любое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
String str = Convert.ToString(number);
char [] ar = str.ToCharArray();

if (ar[0] == ar[4] && ar[1] == ar[3] && ar[2] == ar[2])
{
    Console.WriteLine(str + " - ЭТО ЧИСЛО ЯВЛЯЕТСЯ ПАЛИНДРОМОМ");
}
else
{
    Console.WriteLine(str + " - ЭТО ЧИСЛО НЕ ЯВЛЯЕТСЯ ПАЛИНДРОМОМ");
}