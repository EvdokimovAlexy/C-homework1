Console.WriteLine("Введите число");
int numberA = Convert.ToInt32 (Console.ReadLine());
int numberB = Convert.ToInt32 (Console.ReadLine());
int max = numberA;
int min = numberB;
if (numberB > max) max = numberB;

{
    Console.Write("Наибольшее число "); 
    Console.WriteLine(max);
}

if (numberA < min) min = numberA;
{
    Console.Write("Наименьшее число "); 
    Console.WriteLine(min);
}