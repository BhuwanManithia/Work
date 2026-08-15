//Assignment 1: Print All Even Numbers

//int[] num = { 10, 15, 20, 25, 30, 33, 44 };

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] % 2 == 0)
//    {
//        Console.WriteLine(num[i]);
//    }
//}




//Assignment 2: Find the Largest Number

//int[] num = { 10, 25, 7, 40, 18 };

//int largest = num[0];

//for (int i = 0; i < num.Length; i++)
//{
//    if (largest < num[i])
//    {
//        largest = num[i];
//    }
//}
//Console.WriteLine("largest: " + largest);




//Assignment 3: Count Positive and Negative Numbers

//int[] num = { 10, -5, 20, -8, 15, -2 };

//int positiveCount = 0;
//int negativeCount = 0;

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] >= 0)
//    {
//        positiveCount++;
//    }
//    else
//    {
//        negativeCount++;
//    }
//}

//Console.WriteLine($"Positive Count: {positiveCount}");
//Console.WriteLine($"Negative Count: {negativeCount}");




//Assignment 4: Calculate Sum of Array


//int[] num = { 10, 20, 30, 40, 50 };

//int sum = 0;
//for (int i = 0; i < num.Length; i++)
//{
//    sum += num[i];
//}

//Console.WriteLine($"Sum: {sum}");





//Assignment 5: Separate Even and Odd Numbers

//int[] num = { 10, 15, 20, 25, 30, 33, 44 };

//Console.Write("Even Numbers: ");

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] % 2 == 0)
//    {
//        Console.Write(num[i] + " ");
//    }
//}

//Console.WriteLine();

//Console.Write("Odd Numbers: ");

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] % 2 != 0)
//    {
//        Console.Write(num[i] + " ");
//    }
//}





//Assignment 6: Find the First Missing Number


//int[] num = { 1, 2, 3, 5, 6 };

//int missingNumber = 1;

//for (int i = 0; i < num.Length; i++)
//{
//    if (missingNumber == num[i])
//    {
//        missingNumber++;
//    }
//    else
//    {
//        Console.WriteLine($"Missing Number: {missingNumber}");
//        break;
//    }
//}




//Assignment 7: Find the First Duplicate Number

//int[] num = { 10, 20, 30, 20, 50 };


//for (int i = 0; i < num.Length; i++)
//{
//    for (int j = i + 1; j < num.Length; j++)
//    {
//        if (num[i] == num[j])
//        {
//            Console.WriteLine(num[i]);
//            break;  
//        }
//    }
//}



//Assignment 8: Count Occurrences of a Number



//int[] num = { 10, 20, 30, 20, 40, 20 };

//int search = 20;
//int count = 0;

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] == search)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Occurrences of {search}: {count}");





//Assignment 9: Find All Numbers Greater Than Average


//int[] num = { 20, 30, 40, 50, 60 };

//int sum = 0;

//for (int i = 0; i < num.Length; i++)
//{
//    sum += num[i];
//}
//double average = sum / num.Length;

//Console.WriteLine($"Average: {average}");

//Console.Write("Greater than average: ");

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] > average)
//    {
//        Console.Write(num[i] + " ");
//    }
//} 
//Console.WriteLine();





//Assignment 10: Find the Second Largest Number


//int[] num = { 25, 10, 45, 30, 45, 15 };

//int firstlargest = num[0];
//int secondlargest = num[0];

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] > firstlargest)
//    {
//        firstlargest = num[i];
//    }else if (num[i] > secondlargest && num[i] < firstlargest)
//    {
//        secondlargest = num[i];
//    }
//}
//Console.WriteLine(secondlargest);





//Assignment 11: Find the Last Duplicate Number



//int[] num = { 10, 20, 30, 20, 40, 30 };

//bool h = true;

//for (int i = num.Length - 1; i >= 0 && h; i--)
//{
//    for (int j = num.Length - 1; j > i; j--)
//    {
//        if (num[i] == num[j])
//        {
//            Console.WriteLine(num[i]);
//            h = false;
//            break;
//        }
//    }
//}





//Assignment 12: Sort Array Without Built-in Sort



//int[] num = { 50, 20, 40, 10, 30 };

//for (int i = 0; i < num.Length; i++)
//{
//    for (int j = 0; j < num.Length - 1 - i; j++)
//    {
//        if (num[j] > num[j + 1])
//        {
//            int temp = num[j];
//            num[j] = num[j + 1];
//            num[j + 1] = temp;
//        }
//    }

//}

//Console.WriteLine("Ascending Order: ");
//for (int i = 0; i < num.Length; i++)
//{
//    Console.WriteLine(num[i]);
//}
//Console.WriteLine("Descending Order: ");
//for (int i = num.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(num[i]);
//}






// Assignment 13: Move All Zeros to the End


//int[] num = { 0, 1, 0, 3, 12 };

//int count = 0;

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] != 0)
//    {
//        num[count] = num[i];
//        count++;
//    }
//}

//for (int i = count; i < num.Length; i++)
//{
//    num[count] = 0;
//    count++;
//}
//for (int i = 0; i < num.Length; i++)
//{
//    Console.WriteLine(num[i]);
//}





// Assignment 14: Find Common Elements of Two Arrays


//int[] num1 = { 10, 20, 30, 40, 50 };
//int[] num2 = { 20, 40, 60, 80, 10 };

//Console.Write("Common Elements: ");
//for (int i = 0; i < num1.Length; i++)
//{

//    for (int j = 0; j < num2.Length; j++)
//    {
//        if (num1[i] == num2[j])
//        {
//            Console.Write(num1[i] + " ");
//        }
//    }
//}
//Console.ReadLine();





// Assignment 15: Remove Duplicate Elements


//int[] num = {10, 20, 10, 30, 20, 40, 30, 50};

//for (int i = 0; i < num.Length; i++)
//{
//    for (int j = i + 1; j < num.Length; j++)
//    {

//        if (num[i] == num[j])
//        {

//        }

//    }
//}
//Console.ReadLine();









// Practice




static bool IsEven(int x)
{
    if (x % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool result = IsEven(10);
bool result2 = IsEven(7);

Console.WriteLine(result);
Console.WriteLine(result2);

Console.ReadLine();