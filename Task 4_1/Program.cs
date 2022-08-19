int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
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