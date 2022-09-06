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

double[] ParametrLine(){
    double[] line = new double[2];
    Console.Write("Введите свободный член уравненния: ");
    line[1] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите коэффициент х: ");
    line[0] = Convert.ToDouble(Console.ReadLine());
    return line;
}

void Intersection(double[] array1, double[] array2){
    double y = (array2[1] * array1[0] -array1[1]*array2[0]) / (array1[0] - array2[0]);
    double x = (y - array1[1]) / array1[0];
    Console.WriteLine($"Координаты точки пересечения ({x}; {y})");
}

Console.WriteLine("Определение точки пересечения двух прямых");
Console.WriteLine("Введите параметры первой прямой");
double[] line1 = ParametrLine();
Console.WriteLine("Введите параметры второй прямой");
double[] line2 = ParametrLine();

Intersection(line1, line2);