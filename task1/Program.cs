// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

Console.Write("Ввелите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Ввелите число: "); 
int b = int.Parse(Console.ReadLine());
ToDegree(a, b);
void ToDegree(int a, int b)
{ 
    int result = 1;
    
    for (int i = 1; i <= b; i++) 
    { 
        result = result * a; 
    } 
    Console.WriteLine(result);
}
