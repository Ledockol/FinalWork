Console.WriteLine("Введите количество чисел");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArrayRandomNumbers(array);
PrintArray(array);
void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(0,10000));
        }
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    Console.WriteLine();
}
for(int i = 0; i < array.Length; i++)
{
    if(array[i] <= 999)
    Console.Write(array[i] + " " );
}
