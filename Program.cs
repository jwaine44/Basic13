// Print all of the integers from 1 to 255.
static void PrintNumbers()
{
    for(int i = 1; i <= 255; i++)
    {
        Console.WriteLine(i);
    }
}

PrintNumbers();

// Print odd numbers between 1-255
static void PrintOdds()
{
    for(int i = 1; i <= 255; i++)
    if(i % 2 == 1)
    {
        Console.WriteLine(i);
    }
}

PrintOdds();

// Print all of the numbers from 0 to 255, but this time, also print the sum as you go. 
static void PrintSum()
{
    int sum = 0;
    for(int i = 0; i <= 255; i++)
    {
        sum += i;
        Console.WriteLine($"New number: {i} Sum: {sum}");
    }
}

PrintSum();

// Write a function that would iterate through each item of the given integer array and print each value to the console. 
static void LoopArray(int[] numbers)
{
    for(int j = 0; j < numbers.Length; j++)
    Console.WriteLine(numbers[j]);
}

int[] arr = {1, 2, 3, 4};
LoopArray(arr);

// Write a function that takes an integer array and prints and returns the maximum value in the array. 
// Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), or even a mix of positive numbers, negative numbers and zero.
static int FindMax(int[] numbers)
{
    int max = numbers[0];
    for(int k = 0; k < numbers.Length; k++)
    if(max < numbers[k])
    {
        max = numbers[k];
    }
    return max;
}

int result;
int[] arr2 = {-3, -5, -7};
result = FindMax(arr2);
Console.WriteLine(result);

// Write a function that takes an integer array and prints the AVERAGE of the values in the array.
// For example, with an array [2, 10, 3], your program should write 5 to the console.
static void GetAverage(int[] numbers)
{
    int sum = 0;
    for(int m = 0; m < numbers.Length; m++)
    {
        sum += numbers[m];
    }
    Console.WriteLine(sum / numbers.Length);
}

int[] arr3 = {2, 10, 3};
GetAverage(arr3);

// Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
// When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
static int[] OddArray()
{
    int[] arr4 = new int[256 / 2];
    for(int i = 1; i <= 255; i += 2)
    {
        arr4[i / 2] = i;
    }
    return (arr4);
}

OddArray();

// Write a function that takes an integer array, and a integer "y" and returns the number of array values that are greater than the "y" value. 
// For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 (since there are two values in the array that are greater than 3).
static int GreaterThanY(int[] numbers, int y)
{
    int count = 0;
    for(int i = 0; i < numbers.Length; i++)
    if(numbers[i] > y)
    {
        count++;
    }
    return count;
}

int greaterThanYResult;
int[] arr5 = {1, 3, 5, 7};
greaterThanYResult = GreaterThanY(arr5, 3);
Console.WriteLine(greaterThanYResult);

// Write a function that takes an integer array "numbers", and then multiplies each value by itself.
// For example, [1,5,10,-10] should become [1,25,100,100]
static void SquareArrayValues(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i] * numbers[i];
    }
}

int[] arr6 = {1, 5, 10, -10};
SquareArrayValues(arr6);

// Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
// When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
static void EliminateNegatives(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] < 0)
            numbers[i] = 0;
    }
}

int[] arr7 = {1, 5, 10, -2};
EliminateNegatives(arr7);

// Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, the minimum value in the array, and the average of the values in the array.
static void MinMaxAverage(int[] numbers)
{
    int max = numbers[0];
    int min = numbers[0];
    int sum = numbers[0];

    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > max)
        max = numbers[i];

        if(numbers[i] < min)
        min = numbers[i];
        
        sum += numbers[i];
        int avg = sum / numbers.Length;
    }
}

int[] arr8 = {1, 5, 10, -2};
MinMaxAverage(arr8);

// Given an integer array, say [1, 5, 10, 7, -2], 
// Write a function that shifts each number by one to the front and adds '0' to the end. 
// For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, it should become [5, 10, 7, -2, 0].
static void ShiftValues(int[] numbers)
{
    for(int i = 0; i < numbers.Length - 1; i++)
    {
        numbers[i] = numbers[i + 1];
    }

    numbers[numbers.Length - 1] = 0;
}

ShiftValues(arr8);

// Write a function that takes an integer array and returns an object array that replaces any negative number with the string 'Dojo'.
// For example, if array "numbers" is initially [-1, -3, 2] your function should return an array with values ['Dojo', 'Dojo', 2].
static object[] NumToString(int[] numbers)
{
    object[] newObject = new object[numbers.Length];
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] < 0)
            newObject[i] = "Dojo";
        else
            newObject[i] = numbers[i];
    }
    return newObject;
}

int[] arr9 = {-1, -3, 2};
NumToString(arr9);