Console.Write("Input number: "); // запрашиваем пользователя 1 число
int number_1 = Convert.ToInt32(Console.ReadLine()); //преобразовывает из консоли в целое число

Console.Write("Input number: "); // запрашиваем пользователя 2 число
int number_2 = Convert.ToInt32(Console.ReadLine()); //преобразовывает из консоли в целое число

if (number_1 == number_2*number_2)
    Console.WriteLine("a = " + number_1 + ", b = " + number_2 + " ->" + " yes");
else
    Console.WriteLine("a = " + number_1 + ", b = " + number_2 + " ->" + " no");