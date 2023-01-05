//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
int[] array = new int[5];
for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(1, 1000);
}
Console.WriteLine($"[{String.Join(", ", array)}]");
int even = 0;
for(int i = 0; i < array.Length; i++){
    if(array[i] % 2 == 0)
    even++;
}
Console.WriteLine($"Количество чётных чисел: {even}");