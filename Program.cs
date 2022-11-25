int [] numbers = new int[8];
Console.Write("[");
for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 9);
    Console.Write(numbers[i]);
    if (i < numbers.Length - 1)
    {
        Console.Write(", ");
    }    
 }
Console.Write("]");

