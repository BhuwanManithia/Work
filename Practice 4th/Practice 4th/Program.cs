//✅ 1.Check if a person is eligible to vote.

//Console.WriteLine("Enter Your Age: ");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("You have a Valid Voter ID: True OR False:- ");
//Boolean hasID = Convert.ToBoolean(Console.ReadLine());

//if (age >= 18)
//{
//    if (hasID)
//    {
//        Console.WriteLine("Eligible to vote.");
//    }
//    else
//    {
//        Console.WriteLine("Not eligible to vote.");
//    }
//}
//else
//{
//    Console.WriteLine("Not eligible to vote.");
//}





//=====================================================================

//✅ 2.Verify login credentials.

//Console.WriteLine("Enter Your Username: ");
//string username = Console.ReadLine();

//Console.WriteLine("Enter Your Password: ");
//string password = Console.ReadLine();

//if (username == "admin")
//{
//    if (password == "1234")
//    {
//        Console.WriteLine("Access granted.");
//    }
//    else
//    {
//        Console.WriteLine("Invalid password.");
//    }
//}
//else
//{
//    Console.WriteLine("Invalid username.");
//}





//=====================================================================

//✅ 3.Check if a number is positive and even.

//Console.WriteLine("Enter a Number: ");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number > 0)
//{
//    if (number % 2 == 0)
//    {
//        Console.WriteLine("Number is positive and even.");
//    }
//    else
//    {
//        Console.WriteLine("Number is positive but odd.");
//    }
//}
//else
//{
//    Console.WriteLine("Number is not positive.");
//}





//=====================================================================

//✅ 4.Check if a student passed with excellence.

//Console.WriteLine("Student Passed: True OR False:- ");
//Boolean passed = Convert.ToBoolean(Console.ReadLine());

//Console.WriteLine("Enter Your Marks: ");
//int marks = Convert.ToInt32(Console.ReadLine());

//if (passed)
//{
//    if (marks > 90)
//    {
//        Console.WriteLine("Excellent result.");
//    }
//    else
//    {
//        Console.WriteLine("Passed, but not excellent.");
//    }
//}
//else
//{
//    Console.WriteLine("Student Failed.");
//}





//=====================================================================

//✅ 5.Check for government job eligibility.
 
//Console.WriteLine("Are You a Citizen: True OR False:- ");
//Boolean isCitizen = Convert.ToBoolean(Console.ReadLine());

//Console.WriteLine("Enter Your Age: ");
//int age = Convert.ToInt32(Console.ReadLine());

//if (isCitizen)
//{
//    if (age >= 18)
//    {
//        Console.WriteLine("Eligible for government job.");
//    }
//    else
//    {
//        Console.WriteLine("Not eligible due to age.");
//    }
//}
//else
//{
//    Console.WriteLine("Not eligible due to citizenship.");
//}





//=====================================================================

//✅ 6.Check divisibility by 3 and 5.

//Console.WriteLine("Enter a Number: ");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number % 3 == 0)
//{
//    if (number % 5 == 0)
//    {
//        Console.WriteLine("Divisible by both 3 and 5.");
//    }
//    else
//    {
//        Console.WriteLine("Not divisible by both 3 and 5.");
//    }
//}
//else
//{
//    Console.WriteLine("Not divisible by both 3 and 5.");
//}





//=====================================================================

//✅ 7.Check admin delete permissions.

//Console.WriteLine("Enter Your Role: ");
//string role = Console.ReadLine();

//Console.WriteLine("Can Delete Records: True OR False:- ");
//Boolean canDelete = Convert.ToBoolean(Console.ReadLine());

//if (role == "admin")
//{
//    if (canDelete)
//    {
//        Console.WriteLine("You can delete records.");
//    }
//    else
//    {
//        Console.WriteLine("You are admin, but deletion is not allowed.");
//    }
//}
//else
//{
//    Console.WriteLine("You are not admin.");
//}





//=====================================================================

//✅ 8.Check subscription access.

//Console.WriteLine("Are You Registered: True OR False:- ");
//Boolean isRegistered = Convert.ToBoolean(Console.ReadLine());

//Console.WriteLine("Do You Have Paid Subscription: True OR False:- ");
//Boolean hasPaid = Convert.ToBoolean(Console.ReadLine());

//if (isRegistered)
//{
//    if (hasPaid)
//    {
//        Console.WriteLine("Access granted to premium content.");
//    }
//    else
//    {
//        Console.WriteLine("Please complete your subscription.");
//    }
//}
//else
//{
//    Console.WriteLine("Please register first.");
//}





//=====================================================================

//✅ 9.Find the largest of four numbers.

//Console.WriteLine("Enter First Number: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Second Number: ");
//int b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Third Number: ");
//int c = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Fourth Number: ");
//int d = Convert.ToInt32(Console.ReadLine());

//if (a > b && a > c && a > d)
//{
//    Console.WriteLine("Largest number is " + a);
//}
//else if (b > a && b > c && b > d)
//{
//    Console.WriteLine("Largest number is " + b);
//}
//else if (c > a && c > b && c > d)
//{
//    Console.WriteLine("Largest number is " + c);
//}
//else
//{
//    Console.WriteLine("Largest number is " + d);
//}





//=====================================================================

//✅ 10.Check if a year is a leap year and divisible by 400.

//Console.WriteLine("Enter a Year: ");
//int year = Convert.ToInt32(Console.ReadLine());

//if (year % 4 == 0)
//{
//    if (year % 400 == 0)
//    {
//        Console.WriteLine("Leap year and divisible by 400.");
//    }
//    else
//    {
//        Console.WriteLine("Leap year but not divisible by 400.");
//    }
//}
//else
//{
//    Console.WriteLine("Not a leap year.");
//}





//=====================================================================

//✅ 11.Check if a person can apply for a driver's license.

//Console.WriteLine("Enter Your Age: ");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Passed Learner Test: True OR False:- ");
//Boolean passedTest = Convert.ToBoolean(Console.ReadLine());

//if (age >= 18)
//{
//    if (passedTest)
//    {
//        Console.WriteLine("You can apply for a license.");
//    }
//    else
//    {
//        Console.WriteLine("You need to pass the learner test.");
//    }
//}
//else
//{
//    Console.WriteLine("You are not old enough.");
//}





//=====================================================================

//✅ 12.Check if a triangle is equilateral.

//Console.WriteLine("Enter First Side: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Second Side: ");
//int b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Third Side: ");
//int c = Convert.ToInt32(Console.ReadLine());

//if (a == b)
//{
//    if (b == c)
//    {
//        Console.WriteLine("Equilateral triangle.");
//    }
//    else
//    {
//        Console.WriteLine("Not an equilateral triangle.");
//    }
//}
//else
//{
//    Console.WriteLine("Not an equilateral triangle.");
//}





//=====================================================================

//✅ 13.Check if a person qualifies for a scholarship.

//Console.WriteLine("Enter Your Percentage: ");
//int percentage = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Are You From Rural Area: True OR False:- ");
//Boolean isRural = Convert.ToBoolean(Console.ReadLine());

//if (percentage >= 85)
//{
//    if (isRural)
//    {
//        Console.WriteLine("Scholarship granted.");
//    }
//    else
//    {
//        Console.WriteLine("No scholarship due to location.");
//    }
//}
//else
//{
//    Console.WriteLine("No scholarship due to percentage.");
//}





//=====================================================================

//✅ 14.Check if a number is a three-digit even number.

//Console.WriteLine("Enter a Number: ");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num >= 100 && num <= 999)
//{
//    if (num % 2 == 0)
//    {
//        Console.WriteLine("Three-digit even number.");
//    }
//    else
//    {
//        Console.WriteLine("Three-digit but odd number.");
//    }
//}
//else
//{
//    Console.WriteLine("Not Three-digit and not even.");
//}


Console.WriteLine("Enter a Plane class: ");
string planeClass = Console.ReadLine();

Console.WriteLine("Enter Your baggage weight(KG): ");
double baggageWeight = Convert.ToDouble(Console.ReadLine());


if (planeClass == "e")
{
    if (baggageWeight < 15)
    {
        Console.WriteLine("Free");
    }
    else
    {
        Console.WriteLine("Pay 500");
    }
}else if (planeClass == "b")
{
    if (baggageWeight < 30)
    {
        Console.WriteLine("Free");
    }
    else
    {
        Console.WriteLine("Pay 1000");
    }
}
