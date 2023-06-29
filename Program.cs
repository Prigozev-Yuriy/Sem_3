// Пускай вводится строка. Хочу узнать, состоит она из чисел или нет.
Console.Write("Введите число: ");
string stringNumber = Console.ReadLine(); // "1223" - строчка, в которой есть только цифры (8 - Yes)
// "Hello1234" - NO
int number; // Переменная, в которую будет вставляться
// конвертированная строчку

bool isNumber = int.TryParse(stringNumber, out number);
// Проверяю stringNumber: состоит ли строчка ТОЛЬКО из цифр.
// Если состоит, то isNumber = true; а в переменную number - само число
// Если НЕ состоит, то isNumber = false; а в переменную number - 0
if (isNumber) // isNumber == true 
{
    Console.WriteLine($"В строчке {stringNumber} находятся ТОЛЬКО ЦИФРЫ");
    Console.WriteLine(number);
}
else
{
    Console.WriteLine($"В строчке {stringNumber} находятся символы");
    Console.WriteLine(number);
}