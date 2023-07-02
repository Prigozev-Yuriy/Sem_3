// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 10 == number / 10000 && (number % 100 - number % 10) / 10 == (number / 1000) - (number / 10000) * 10)
{
    Console.Write("Число " + number + " является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}