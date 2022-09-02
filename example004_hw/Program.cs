Console.WriteLine("Введите любое число");
int numberA = Convert.ToInt32 (Console.ReadLine());

for (int index = 1; index < numberA; index++)
{
    if (index % 2 == 0)
    {
    Console.WriteLine(index);
    }
}
   