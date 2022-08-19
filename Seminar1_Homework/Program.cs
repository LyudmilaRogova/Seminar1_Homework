//Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.
/*
Console.Write("Введите число a: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int num_b = Convert.ToInt32(Console.ReadLine());

if(num_a > num_b){
    Console.WriteLine("max = " + num_a);
}
else{
    Console.WriteLine("max = " + num_b);
}
*/

//Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите число a: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int num_b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int num_c = Convert.ToInt32(Console.ReadLine());

int max = num_a;

if(max < num_b){
    max = num_b;
}

if(max < num_c){
    max = num_c;
}

Console.WriteLine("max = " + max);
*/

//Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0){
    Console.WriteLine("Число " + num + " четное");
}
else{
     Console.WriteLine("Число " + num + " нечетное");
}
*/


//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
//объявление счетчика
int i = 2;

if(N == 1){
    Console.WriteLine("В заданном промежутке нет четных чисел");
}
else{
    while(i <= N){
        Console.Write(i + " ");
        i += 2;
    }
}
