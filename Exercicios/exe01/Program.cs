int[] numbers = new int[] {1, 2, 3, 4, 5, 6 , 7, 8, 9, 10 };

Random random = new Random();
for(int i = 0; i < numbers.Length; i++){
    int j = random.Next(i, numbers.Length);
    int temp = numbers[i];
    numbers[i] = numbers[j];
    numbers[j] = temp;
}

Console.WriteLine("valores desordenados:");
foreach (int number in numbers) {
    Console.WriteLine(number);
}

Array.Sort(numbers);
Console.WriteLine("valores ordenados");
foreach (int number in numbers) {
    Console.WriteLine(number);
}