// Найти кубы чисел от N до N
Console.Write("Введите первое число ");
float First_number = float.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
float Second_number = float.Parse(Console.ReadLine());

for(float i = First_number; i <= Second_number; i++) 
Console.WriteLine(Math.Pow(i,3));




