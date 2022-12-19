uint iloscZapisow = Convert.ToUInt32(Console.ReadLine());
int[] wysokosci = new int[iloscZapisow];
string wysokosciInp = Console.ReadLine();
uint index = 0;
int tmpA, tmpB, tmpC;
uint iloscWzniesien = 0;

foreach (string inp in wysokosciInp.Split(" "))
{
    wysokosci[index] = Convert.ToInt32(inp);
    index++;
}

for (int i = 0; i < wysokosci.Length - 2; i++)
{
    tmpA = wysokosci[i];
    tmpB = wysokosci[i+1];
    tmpC = wysokosci[i+2];

    if (tmpA < tmpB && tmpB > tmpC) { iloscWzniesien++; }
}

Console.WriteLine(iloscWzniesien);