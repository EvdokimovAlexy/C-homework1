Console.WriteLine("Введите число");
int numberA = Convert.ToInt32 (Console.ReadLine());
int numberB = Convert.ToInt32 (Console.ReadLine());
int max = numberA;
int min = numberB;
if (numberA > numberB)
{
    max = numberA;
    Console.WriteLine($"Наибольшее число {numberA}, наименьшее число {numberB}"); 
}

else 
{
    min = numberA;
    Console.WriteLine($"Наибольшее число {numberB}, наименьшее число {numberA}"); 
} 