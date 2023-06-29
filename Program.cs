// // Пускай вводится строка. Хочу узнать, состоит она из чисел или нет.
// Console.Write("Введите число: ");
// string stringNumber = Console.ReadLine(); // "1223" - строчка, в которой есть только цифры (8 - Yes)
// // "Hello1234" - NO
// int number; // Переменная, в которую будет вставляться
// // конвертированная строчку

// bool isNumber = int.TryParse(stringNumber, out number);
// // Проверяю stringNumber: состоит ли строчка ТОЛЬКО из цифр.
// // Если состоит, то isNumber = true; а в переменную number - само число
// // Если НЕ состоит, то isNumber = false; а в переменную number - 0
// if (isNumber) // isNumber == true 
// {
//     Console.WriteLine($"В строчке {stringNumber} находятся ТОЛЬКО ЦИФРЫ");
//     Console.WriteLine(number);
// }
// else
// {
//     Console.WriteLine($"В строчке {stringNumber} находятся символы");
//     Console.WriteLine(number);
// }

// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

// Console.Write("Введите координаты точки Х: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// if (x == 0 ^ y == 0)
// {
//     Console.Write("Точка совпадает с осями координат");
// }
// else
// {
//     if (x > 0 && y > 0)
//     {
//         Console.Write("Точка находится в 1 четвери");
//     }
//     if (x < 0 && y > 0)
//     {
//         Console.Write("Точка находится во 2 четвери");
//     }
//     if (x < 0 && y < 0)
//     {
//         Console.Write("Точка находится в 3 четвери");
//     }
//     if (x > 0 && y < 0)
//     {
//         Console.Write("Точка находится в 4 четвери");
//     }
// }

//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// Console.Write("Введите номер четверти: ");
// int quarter = Convert.ToInt32(Console.ReadLine());
// if (quarter == 1)
// {
//    Console.Write ($"Точка лежит в диапазоне по оси Х > 0 и по оси Y > 0");
// }
// else if (quarter == 2)
// {
//    Console.Write ($"Точка лежит в диапазоне по оси Х < 0  и по оси Y > 0");
// }
// else if (quarter == 3)
// {
//    Console.Write ($"Точка лежит в диапазоне по оси Х < 0  и по оси Y < 0");
// }
// else if (quarter == 4)
// {
//    Console.Write ($"Точка лежит в диапазоне по оси Х > 0  и по оси Y < 0");
// }

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21








// Console.Write("Введите координаты первой точки Х: ");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты первой точки Y: ");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты второй точки Х: ");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты второй точки Y: ");
// double y2 = Convert.ToInt32(Console.ReadLine());
// if (x1 > x2)
// {
//     double leg1 = x1 - x2;
// }
// else
// {
//     double leg1 = x2 - x1;
// }
// if (y1 > y2)
// {
//     double leg2 = y1 - y2;
// }
// else
// {
//     double leg2 = y2 - y1;
// }
// double distance = Math.Round(Math.Sqrt(Math.Pow(leg1, 2) + Math.Pow(leg2, 2)), 2);
// Console.Write("Расстояние между точками равно { distance}");










//  Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
//  и находит расстояние между ними в 2D пространстве.
//  A (3,6); B (2,1) -> 5,09 
//  A (7,-5); B (1,-1) -> 7,21

//  AB = √(x2 - x1)2 + (y2 - y1)2
// Console.Write("Введите координату по оси оХ для второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оY для второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по оси оХ для первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оY для первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);

// Console.WriteLine($"Расстояние: {d}");

// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// int start = 1;
// int end = Convert.ToInt32(Console.ReadLine()); 

// while (start <= end)
// {
// Console.Write(Math.Pow(start, 2) + ", ");
// start++;
// if (start == end)
// {
//     Console.Write(Math.Pow(start, 2));
//     start++;
// }
// } 


// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// int start = 1;
// Console.Write("Введите число: ");
// int end = Convert.ToInt32(Console.ReadLine());

// while (start <= end)
// {
//     Console.Write(Math.Pow(start, 2) + " "); // start во степень
//     start++; // start = start + 1 - инкремент
// }

// точка старта(1), условие из цикла(start <= end), увеличение счетчика start++
// start = i
// for (int i = 1; i <= end; i++)
// {
//     Console.Write(Math.Pow(i, 2) + " ");
// }