using System.Globalization;

int[] numbers = new int[8];
numbers = [-1, -2, 0, 1, 2, 3, 4, 5];

// 1. Find Sum of Array

//int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    sum = sum + numbers[i];
//}
//Console.WriteLine(sum);



// 2. Find Average of Array

//int sum = 0;
//int average;

//for (int i = 0; i < numbers.Length; i++)
//{
//    sum = sum + numbers[i];
//}
//average = sum / numbers.Length;
//Console.WriteLine(average);



// 3. Find Largest Number

//int largest = numbers[0];

//for (int i = 1; i < numbers.Length; i++)
//{
//    if (numbers[i] > largest)
//    {
//        largest = numbers[i];
//    }
//}
//Console.WriteLine(largest);



// 4. Find Smallest Number

//int smallest = numbers[0];

//for (int i = 1; i < numbers.Length; i++)
//{
//    if (numbers[i] < smallest)
//    {
//        smallest = numbers[i];
//    }
//}
//Console.WriteLine(smallest);



// 5. sum of odd number

//int odd = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//    }
//    else
//    {
//        odd += numbers[i];
//    }
//}
//Console.WriteLine(odd);



// 6. sum of even number


//int even = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 == 0)
//    {
//        even += numbers[i];
//    }
//}
//Console.WriteLine(even);



// 7. Reverse the Array



//for (int i = 0; i < numbers.Length / 2; i++)
//{
//   int reverse = numbers[i];
//    numbers[i] = numbers[numbers.Length - 1 - i];
//    numbers[numbers.Length - 1 - i] = reverse;
//}
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}




// 8. Search a Number

//int number = 1;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if(numbers[i] == number)
//    {
//        Console.WriteLine("Number found at index: " + i);
//        break;
//    }

//}



// 9. Search a index

//int index = 3;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (i == index)
//    {
//        Console.WriteLine(numbers[i]);
//    }
//}


// 10. Count Positive numbers


//int positiveCount = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] >= 0)
//    {
//        positiveCount++;
//    }
//}
//Console.WriteLine(positiveCount);





// 11. Count Negative numbers


//int negativeCount = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] < 0)
//    {
//        negativeCount++;
//    }
//}
//Console.WriteLine(negativeCount);



// 12. copy one array to another array


//int[] copyArray = new int[numbers.Length];

//for (int i = 0; i < numbers.Length; i++)
//{
//    copyArray[i] = numbers[i];
//}

//for (int i = 0; i < copyArray.Length; i++)
//{
//Console.WriteLine(copyArray[i]);

//}



// 13. replace negative numbers with 0

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] < 0)
//    {
//        numbers[i] = 0;
//    }
//    Console.WriteLine(numbers[i]);
//}


