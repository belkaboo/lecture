void Method1()
{
    Console.WriteLine("Author ...");
}

Method1();

void Method2(string msg)
{
    Console.WriteLine(msg);

}
Method2("Text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

// Method21("text21", 4);

Method21(count: 4, msg: "new text");

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;

    }
    return result;
}
string res = Method4(10, "text4");
Console.WriteLine(res);

Console.WriteLine ("")