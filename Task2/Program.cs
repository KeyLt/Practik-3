// // Подсчитать сумму цифр в числе
int x = int.Parse(Console.ReadLine());
int sum=0;
for (int i=10; i>=0; i--)
{
    sum+=x/(int)Math.Pow(10.0,i);
    x=x%(int)Math.Pow(10.0,i);
}
Console.WriteLine(sum);

//Попытки

// using System;
// class Program {
// public static int Main() 
//     {
//     Console.Write("Введите число : ");
//     string m = Console.ReadLine();
//     // char [] k = m.ToCharArray();
//     int num=int.Parse(m);
//     int i = 0;
//     int s = 0;
//     while(num>0) {
//     // i++;
//     // num/=10;
//         for (int j = 0; j++;)
//         s = s + m[j];
//         }
// //   Console.WriteLine("Количество цифр введенного числа : {0}", i);
//     Console.WriteLine(s);
//     // Console.ReadKey(); // функция ожидания нажатия клавиши 
//     return 0;
//     }
// }


// // String.Length
// // Console.Write("Введите первое число ");
// // string First_number = Console.ReadLine();

// // while(First_number>0)
// //     for(int i, i=0, i++, i<First_number)


// // float.Parse


// int a = int.Parse(Console.ReadLine());
//             long s = 0;
//             while (a > 0)
//             {
//                 long p = a;
//                 s = s + p % 10;
//                 p = p /10 ;
                
//             }
// return 0;
//  Console.WriteLine(s);