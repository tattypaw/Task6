/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/
// Вариант 1, без массива, числа не сохраняются
/*
void Positive(int m){
    int n = 0;
    int k = 0;
    for(int i = 0; i < m; i++){
        Console.Write("Введите число: ");
        k = Convert.ToInt32(Console.ReadLine());
        if (k > 0) n++;
    }
    Console.WriteLine("Количество чисел больше нуля: " + n);
}
Console.Write("Сколько чисел Вы хотите ввести? ");
int m = Convert.ToInt32(Console.ReadLine());
Positive(m);
*/

// Вариант 2, с массивом
/*
double[] CreateArray(int size){
    double[] array = new double[size];
    for (int i = 0; i < size; i++){
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void Positive(double[] array){
    int n = 0;
    for(int i = 0; i < array.Length - 1; i++){
        if (array [i] > 0) n++;
    }
    Console.WriteLine("Количество чисел больше нуля: " + n);
}

Console.Write("Сколько чисел Вы хотите ввести? ");
int m = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(m);
Positive(array);
*/
/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double[,] ParametrLine(){
    double[,] lines = new double[2,2];
    Console.WriteLine("Введите параметры первой прямой");
    Console.Write("Введите свободный член уравнения: ");
    lines[0,1] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите коэффициент х: ");
    lines[0,0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите параметры второй прямой");
    Console.Write("Введите свободный член уравнения: ");
    lines[1,1] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите коэффициент х: ");
    lines[1,0] = Convert.ToDouble(Console.ReadLine());
    return lines;
}

void Intersection(double[,] array){
    double y = (array[1,1] * array[0,0] -array[0,1]*array[1,0]) / (array[0,0] - array[1,0]);
    double x = (y - array[0,1]) / array[0,0];
    Console.WriteLine($"Координаты точки пересечения ({x}; {y})");
}

Console.WriteLine("Определение точки пересечения двух прямых");
double[,] lines = ParametrLine();

Intersection(lines);