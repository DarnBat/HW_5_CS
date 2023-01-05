// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int[] array = new int[5];
for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(1, 10);
}
Console.Write($"[{String.Join(", ", array)}]");
int sum = 0;
for(int i = 1; i < array.Length; i += 2){
sum +=array[i];
}
 Console.Write($" -> {sum}");