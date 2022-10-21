// Код из первой лекции. Сними комментарии с блоков перед использованием

/*
Console.Clear(); // очистка консоли
Console.WriteLine("Hello, World!");
*/




/*
Console.WriteLine("Enter your name");
string username = Console.ReadLine(); //  ввод переменной и считывание из консоли
Console.Write("Hi, "); // вывод в консоль( WriteLine - в одну линию т.е. будет пренос строки)
Console.WriteLine(username); // вывод значения переменной username
*/

/*
int number1 = 12;
int number2 = 5; 
int result = (number1 / number2); //  result = 2 т.к. типа переменной int - целые числа.
Console.WriteLine(result);
*/


/*
double number1 = 12; // double -  вещественные числа
double number2 = 5; 
double result = (number1 / number2); // result = 2,4
Console.WriteLine(result);
*/


/*
Console.Clear();
int number1 = new Random().Next(1,10); // случайное число от 1 до 9. полуинтервал всегда -1 от мах
int number2 = new Random().Next(1,10);
int result = number1 + number2;
Console.Write($" {number1} + {number2}  = ");
Console.WriteLine(result);
*/


/*
Console.Clear();
Console.Write("Enter your name: ");
string username = Console.ReadLine(); // тип переменной для строк
if (username == "John") // работает только если регистры в каждом символе совпадает
{
    Console.WriteLine("hooray, Hi Johnny!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
*/


/*
Console.Clear();
Console.Write("Enter your name: ");
string username = Console.ReadLine(); 
if (username.ToLower() == "john") // To.Lower переводит всё в нижний регистр!!!
{
    Console.WriteLine("hooray, Hi Johnny!");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
*/



// определение максимум...тупой метод!
Console.Clear();
int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;
int max  = a;
if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;
if (d > max ) max = d;
if (e > max ) max = e;
Console.Write("max = ");
Console.WriteLine(max);



