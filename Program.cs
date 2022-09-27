/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

System.Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Convert.ToInt32(Math.Pow(a,b));

System.Console.WriteLine($"{a}, {b} -> {result}");


/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

// костыль, но батут работает
// считаю что по затратам процессорного времени 
// самое выгодное решение
int result = a % 10;

while (a / 10 !=0){
    // результат костыля, сначала деление)
    a = a / 10;
    result = result + (a % 10);
}

System.Console.WriteLine($"{a} -> {result}");


/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

// метод возвращает строку из массива
string returnArray(int[] arr){
    string result = string.Empty;

    for(int i = 0; i < arr.Length; i++){
        if (i < arr.Length - 1){
            result = result + $"{arr[i]}, ";
        } else {
            result = result + $"{arr[i]}";
        }
    }

    return result;
}

// создаем массив
int[] array = new int[8];
for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(0,100);
}

// выводим массив
string result = returnArray(array);
System.Console.WriteLine($"{result} -> [{result}]");