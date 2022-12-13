

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)


//  int Degree(int num1, int num2){
//     int nd = num1;
//     for(int i = 1; i < num2; i++)
//        nd = (nd * num1);
//     return nd;
//  }

//  Console.WriteLine("Введите число A");
//     int numA = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите число B");
//     int numB = Convert.ToInt32(Console.ReadLine());
//     int ns = Degree(numA, numB);
// Console.WriteLine(ns);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
// цифр в числе.(Массивы и строки использовать нельзя!!!)


//  int SummNumbers(int n){
//     int sum = 0;
//     while(n > 0){
//     int end = n % 10;
//     sum = sum + end;
//     n = n / 10;}
//     return sum;
//  }
//  Console.WriteLine("Введите число");
//     int num = Convert.ToInt32(Console.ReadLine());
//     int summ = SummNumbers(num);
//  Console.WriteLine(summ);



// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва
//  элементов и выводит их на экран.


//   int[] Array(int num)
// {
// int[] arr =  new int [num];
//     for (int i = 0; i < num; i++){
//       Console.WriteLine("Ведите цифру массива");
//       int a = Convert.ToInt32(Console.ReadLine());
//       arr[i] = a;   }
//     return arr;
// }
// void ShowArray (int[] arr){
//     for (int i = 0; i < arr.Length; i++)
//     {        Console.Write($"{arr[i]} ");    }
// }
// Console.WriteLine("Ведите длинну массива");
//      int a = Convert.ToInt32(Console.ReadLine()); 

//     ShowArray(Array(a));