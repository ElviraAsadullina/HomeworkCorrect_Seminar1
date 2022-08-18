int a = 44;
int b = 5;
int c = 78;
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