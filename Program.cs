// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// // надо еще подумать по десятичным дробям  
// double [,] Create2dArray(int rows, int cols, double min, double max){    
//     double [,] array = new double [rows, cols];                       
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
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Enter the amount of rows: ");
// int r = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the amount of columns: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the minimal element: ");
// double min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the maximal element: ");
// int max = Convert.ToInt32(Console.ReadLine());
// double [,] arraye = Create2dArray(r,c,min,max);
// Console.WriteLine();
// Show2dArray(arraye);


// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// надо еще подумать, чтобы строка об ошибке не всегда появлялась


// int [,] Create2dArray(int rows, int cols, int min, int max){    // задаем параметры двумерного массива
//     int [,] array = new int [rows, cols];                       // создаем новый массив с параметрами: столбцы и строки
//     for(int i = 0; i < rows; i++){                              // цикл про столбцы
//         for(int j = 0; j < cols; j++){                          // цикл про строки
//             array[i,j] = new Random().Next(min, max+1);         // создаем элементы массива
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

// int FindTheNum(int [,] array, int x, int y){
//     int res = 0;                              
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             if(x == i && y == j)
//                 res = array[i,j];
//         }
//     }
//     return res;
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
// Console.Write("Enter the row index: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the column index: ");
// int y = Convert.ToInt32(Console.ReadLine());
// int find = FindTheNum(arr,x,y);
// Console.WriteLine($"{find}");

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// надо подумать, что не получается

int [,] Create2dArray(int rows, int cols, int min, int max){    
    int [,] array = new int [rows, cols];                       
    for(int i = 0; i < rows; i++){                              
        for(int j = 0; j < cols; j++){                         
            array[i,j] = new Random().Next(min, max+1);         
        }
    }
    return array;
}

void Show2dArray(int [,] array){                                
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void SumTheColumns(int [,] array){
    double sum = 0;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            sum = array[i,j] + array[i,j+1];
        }
        Console.Write(sum + " ");
    }
}

Console.Write("Enter the numb of rows: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the numb of columns: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimal number of the array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximal number of the array: ");
int max = Convert.ToInt32(Console.ReadLine());
int [,] arr = Create2dArray(r,c,min,max);
Show2dArray(arr);
SumTheColumns(arr);