int a = 2;
int b = 3;
int c = 7;
int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    Console.Write($"max = {c}");
}
else
{
    Console.Write($"max = {max}");
}