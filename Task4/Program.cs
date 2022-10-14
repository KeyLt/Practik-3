// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите первое число ");
float First_number = float.Parse(Console.ReadLine());
Console.Write("Введите второе число ");
float Second_number = float.Parse(Console.ReadLine());

for(float i = First_number; i <= Second_number; i++) 
    if(i % 2 == 0)
    Console.WriteLine(Math.Pow(i,3));



