Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberC = Convert.ToInt32 (Console.ReadLine());
int max = numberA;
if (numberA > numberB && numberA >= numberC)
{
    max = numberA;
}   
else if (numberB > numberA && numberB > numberC )
{
    max = numberB;
}
    
else if (numberC > numberA && numberC > numberB)
{
    max = numberC;
}
Console.Write("Максимальное число ");
Console.WriteLine(max);