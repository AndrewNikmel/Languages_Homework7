// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// // // надо еще подумать по отрицательным числам  
// double [,] Create2dArray(int rows, int cols){    
//     double [,] array = new double [rows, cols];
//     Random random = new Random();
//     for(int i = 0; i < rows; i++){                              
//         for(int j = 0; j < cols; j++){                         
//             array[i,j] = new Random().NextDouble()*10;         
//         }
//     }
//     return array;
// }

// void Show2dArray(double [,] array){                                
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             double res = Math.Round(array[i,j], 1);
//             Console.Write(res+" ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Enter the amount of rows: ");
// int r = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the amount of columns: ");
// int c = Convert.ToInt32(Console.ReadLine());
// double [,] arraye = Create2dArray(r,c);
// Console.WriteLine();
// Show2dArray(arraye);


// Задача 50.Done Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int [,] Create2dArray(int rows, int cols, int min, int max){    
//     int [,] array = new int [rows, cols];                       
//     for(int i = 0; i < rows; i++){                              
//         for(int j = 0; j < cols; j++){                          
//             array[i,j] = new Random().Next(min, max+1);         
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array){                                
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindTheNum(int [,] array){
//     Console.WriteLine("Input the row: ");
//     int i = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Input the column: ");
//     int j = Convert.ToInt32(Console.ReadLine());
//     if(i < array.GetLength(0) && j < array.GetLength(1))
//         Console.WriteLine($"Your element is {array[i,j]}");
//     else
//         Console.WriteLine("Your element is not present in the Array");
// }



// Console.Write("Enter the numb of rows: ");
// int r = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the numb of columns: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the minimal number of the array: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the maximal number of the array: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] arr = Create2dArray(r,c,min,max);
// Show2dArray(arr);
// FindTheNum(arr);


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// надо подумать, что не получается


// int [,] Create2dArray(int rows, int cols, int min, int max){
//     int [,] array = new int [rows, cols];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < cols; j++){
//             array [i,j] = new Random().Next(min, max+1);
//         }
//     }
//     return array;
// }

// void Show2dArray(int [,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SumColumns(int [,] array){
//     int i = 0;
//     int length = array.GetLength(0);
//     for(int j = 0; j < array.GetLength(1); j++){
//         if(i< array.GetLength(0)){
//             int sum =+ array [i,j]+array[i+1,j];
//             double arithmeticSum = sum / length;
//             i++;
//             Console.Write(arithmeticSum + " ");
//     }    
// }
// }

// Console.WriteLine("Enter the amount of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the amount of columns: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array = Create2dArray(rows,cols,min,max);
// Show2dArray(array);
// Console.WriteLine();
// SumColumns(array);