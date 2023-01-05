// Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
int[] array = new int[5];
for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(-100, 100);
}
Console.WriteLine($"[{String.Join(", ", array)}]");
int min;
int max;
    if(array[0] > array[1])
    max = array[0]; min = array[1];

        max = array[1]; min = array[0];
for(int i = 0; i < array.Length; i++){
    if(array[i] < min)
        min = array[i];
    else if(array[i] > max)
        max = array[i];
}
    Console.WriteLine($"max = {max} \nmin = {min}");
    Console.WriteLine(max - min);
