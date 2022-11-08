double a, b;
double c = 0;
Console.WriteLine("Выберите какую операцию хотите выполнить: ");
Console.WriteLine("\r\n1.Сложить два числа\r\n2.Вычесть первое число из второго\r\n3.Произведение двух чисел \r\n4.Деление двух чисел \r\n5.Возведение в степень числа\r\n6.Нахождение корня\r\n7.Нахождение 1% числа\r\n8.Нахождение факториала\r\n9.Выход из программы\r\n");
do
{
    Console.WriteLine("Введите номер операции: ");
    int action = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите первое число: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    b = Convert.ToInt32(Console.ReadLine());
    switch (action)
    {
        case 1:
            c = a + b;
            break;
        case 2:
            c = a - b;
            break;
        case 3:
            c = a * b;
            break;
        case 4:
            c = a / b;
            break;
        default:
            break;
        case 5:
            c = Math.Pow(a, b);
            break;
        case 6:
            c = Math.Sqrt(a);
            break;
        case 7:
            c = a / 100;
            break;



    }
    Console.WriteLine("Результат: " + c);
    Console.WriteLine();
}
while (true);