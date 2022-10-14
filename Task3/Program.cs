// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число ");
float First_number = float.Parse(Console.ReadLine());
float sum = 1;
for(float i = 1; i <= First_number; i++) 
sum = sum * i;
Console.WriteLine(sum);
