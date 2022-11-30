using System.Linq;
{

}
Console.Clear();

int a = 12;
Console.WriteLine(a.GetType()); // определение типа переменной

var b = 12;
Console.WriteLine(b.GetType().Name); // вывод только типа переменной


// Пример необходимости var
var data = new int[] { 1, 2, 3, 4, }
        .Where(e => e > 0)
        .Select(e => new { q = e, w = e + 1 });

Console.WriteLine(data.GetType().Name);




