// Задача 41
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа через запятую с пробелом");

/*string answer = Console.ReadLine();
string[] numbers = answer.Split(", ");
int score = 0;
for (int i = 0; i < numbers.Length; i++)
{   
    if (Convert.ToInt32(numbers[i]) > 0)
    {
        score++;
    }
}
Console.WriteLine(score);*/

//Напишите программу, которая найдёт точку пересечения 
//двух прямых, заданных уравнениями y = k1 * x + b1,
//y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Веедите к1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веедите b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веедите к2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веедите b2");
int b2 = Convert.ToInt32(Console.ReadLine());

//k1*x + b1 = k2 * x + b2
//(k1 - k2)x = b2 - b1
int x = (b2 - b1)/(k1 - k2);

int y = k1 * x + b1;
Console.WriteLine(y);

