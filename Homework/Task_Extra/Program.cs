// модифицировать программу из 19 задания и сделать так, чтобы проверялись не только цифры, но и строчки.

Console.Write("Введите данные: ");
string str = Convert.ToString(Console.ReadLine());
if (str[0] == str[4] && str[1] == str[3])
{
    Console.Write("Введенные данные " + str + " является палиндромом");
}
else
{
    Console.WriteLine($"Введенные данные {str} не является палиндромом");
}