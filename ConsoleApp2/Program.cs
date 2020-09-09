using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {   // Объявляем переменные типа Float.
            float a, b, c;

            // Оповещаем полльзователя о том, что необходимо ввести данные.
            Console.WriteLine("Привет! Введите пожалуйcта все необходимые данные!");

            //Запрашиваем первое число.
            Console.Write("a= ");
            a = float.Parse(Console.ReadLine());
            
            //Запрв=ашиваем второе число
            Console.Write("b= ");
            b = float.Parse(Console.ReadLine());

            //производим логику, а именно деление. Сохраняем в переменную "С".
            c = a / b;

            //С помощью метода Math.Round(); округляем полученное число до 3 цифр после запятой и выводим в консоль.
            Console.WriteLine(Math.Round((c), 3));

        }
    }
}