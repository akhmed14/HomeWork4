Console.WriteLine("Массив из 8 чисел: ");
void PrintArray(int[]array)
{
    int count = array.Length;
    for (int a = 1; a < count; a++)
    {
        Console.Write($"{array[a]}  ");
    }
}
int [] mass = new int[9];
Random rand = new Random();
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rand.Next(1, 100);
}
PrintArray(mass);