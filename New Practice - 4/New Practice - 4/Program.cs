// 1.  saprate even and odd numbers from an array.


//int[] num = { 10, 15, 20, 25, 30, 33, 44 };

//int even = 0;
//int[] evenNumbers = new int[num.Length];

//int odd = 0;
//int[] oddNumbers = new int[num.Length];

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] % 2 == 0)
//    {
//        evenNumbers[even] = num[i];
//        even++;
//    }
//    else
//    {
//        oddNumbers[odd] = num[i];
//        odd++;
//    }
//}

//Console.Write("Even Numbers: ");
//for (int i = 0; i < even; i++)
//{
//    Console.Write(evenNumbers[i] + " ");
//}

//Console.WriteLine();

//Console.Write("Odd Numbers: ");
//for (int i = 0; i < odd; i++)
//{
//    Console.Write(oddNumbers[i] + " ");
//}
//Console.ReadLine();





// 2. Find the 1st Missing Number (1 to N)


//int[] num = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
//int n = 1;

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] != n)
//    {
//        Console.WriteLine("The 1st missing number is: " + n);
//        break;
//    }
//    n++;
//}



// 3. Find All Numbers Greater Than the Average


//int[] num = { 20, 30, 40, 50, 60 };

//int sum = 0;

//for (int i = 0; i < num.Length; i++)
//{
//    sum += num[i];
//}
//sum = sum / num.Length;

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] > sum)
//    {
//        Console.WriteLine(num[i] + " ");
//    }
//}




// 4.  Find the First Duplicate Number


//int[] num = { 10, 20, 30, 20, 50 };

//for (int i = 0; i < num.Length; i++)
//{
//    for (int j = i + 1; j < num.Length; j++)
//    {
//        if (num[i] == num[j])
//        {
//            Console.WriteLine("First Duplicate Number: " + num[i]);
//            break;  
//        }
//    }
//}



// 5. Find the Last Duplicate Number

//int[] num = { 10, 20, 30, 20, 30 };

//for (int i = num.Length - 1; i >= 0; i--)
//{
//    for (int j = i - 1; j >= 0; j--)
//    {
//        if (num[i] == num[j])
//        {
//            Console.WriteLine("Last Duplicate Number: " + num[i]);
//            break;
//        }
//    }
//}






int[] num = { 10, 20, 30, 40, 50 };

int numb = 0;

for (int i = 0; i < num.Length / 2; i++)
{
    int j = num.Length - 1 - i;

    numb = num[i];
    num[i] = num[j];
    num[j] = numb;
}
for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine(num[i]);
}
