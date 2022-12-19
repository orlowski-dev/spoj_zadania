string inp = Console.ReadLine();
string nextChar;

for (int i = 0; i < inp.Length; i++)
{
    if (inp[i].Equals('_'))
    {
        nextChar = Convert.ToString(inp[i + 1]);
        Console.Write(nextChar.ToUpper());
        i++;
    } else
    {
        Console.Write(inp[i]);
    }
}