string MethodFor(int count, string text)
{
    
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = MethodFor(10, "textFor");
Console.WriteLine(res);
