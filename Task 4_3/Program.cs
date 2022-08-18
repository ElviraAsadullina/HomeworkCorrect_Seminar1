int a = 22;
int b = 3;
int c = 9;
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