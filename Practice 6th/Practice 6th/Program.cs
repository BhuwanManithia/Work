// 1. 

//Console.WriteLine("Enter Your Number: ");
//int num = int.Parse(Console.ReadLine());

//if (num == 0)
//{
//    Console.WriteLine("Zero");
//}else if (num > 0)
//{
//    Console.WriteLine("Positive");
//}
//else
//{
//    Console.WriteLine("Negative");
//}




// 2.    



// 3.   


//Console.WriteLine("Enter Your Age: ");
//int age = int.Parse(Console.ReadLine());

//if (age > 60)
//{
//    Console.WriteLine("Senier");
//}else if (age > 20 && mark < 59)
//{
//    Console.WriteLine("Adult");
//}
//else
//{
//    Console.WriteLine("Child");
//}



// 4.   



//Console.WriteLine("Enter Your 1 to 7: ");
//int day = int.Parse(Console.ReadLine());


//if (day == 1)
//{
//    Console.WriteLine("Sunday");
//}
//else if (day == 2)
//{
//    Console.WriteLine("Monday");
//}
//else if (day == 3)
//{
//    Console.WriteLine("Tuesday");
//}
//else if (day == 4)
//{
//    Console.WriteLine("Wednesday");
//}
//else if (day == 5)
//{
//    Console.WriteLine("Thurasday");
//}
//else if (day == 6)
//{
//    Console.WriteLine("Friday");
//} else if (day == 7)
//{
//    Console.WriteLine("Saturday");
//}





// 5.   


//Console.WriteLine("Enter A Character: ");
//char ch = char.Parse(Console.ReadLine());

//if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
//{
//    Console.WriteLine("Vowel");
//}
//else
//{
//    Console.WriteLine("Consonant");
//};



// 6.   

int a, b, c;
a= 10; b= 11; c= 12;

if (a > b)
{
    Console.WriteLine("a is greater than b");

}
else if (a > c)
{
    Console.WriteLine("a is greater than c");

}
else if (b > a)
{
    Console.WriteLine("b is greater than b");

}
else if (b > c)
{
    Console.WriteLine("b is the greatest");

}
else if (c > a)
{
    Console.WriteLine("c is the greatest");
}
else if (c > b) {

    Console.WriteLine("C is the greatest");
}



// 7.   


//Console.WriteLine("Enter Your temprature in celcius: ");
//int temp = int.Parse(Console.ReadLine());

//if (temp < 15)
//{
//    Console.WriteLine("Cold");
//}
//else if (temp < 25)
//{
//    Console.WriteLine("Pleasent");
//}
//else if (temp < 35)
//{
//    Console.WriteLine("Warm");
//} else if (temp > 35)
//{
//    Console.WriteLine("Hot");
//}




// 8.   


//Console.WriteLine("Enter a number: ");
//int number = int.Parse(Console.ReadLine());

//if (number == 0)
//{
//    Console.WriteLine("zero");

//}else if (number > 0)
//{
//    Console.WriteLine("positive");
//}
//else
//{
//    Console.WriteLine("negative");
//}




// SET 2..
// 


// 9.   


Console.WriteLine("Enter Subjects-1 Marks:  ");
double subject1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Subjects-2 Marks:  ");
double subject2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Subjects-3 Marks:  ");
double subject3 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Subjects-4 Marks:  ");
double subject4 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Subjects-5 Marks:  ");
double subject5 = double.Parse(Console.ReadLine());

double totalMarks = subject1 + subject2 + subject3 + subject4 + subject5;



double average = totalMarks / 5;

if (average >= 90)
{
    Console.WriteLine("Grade A");
}else if (average >= 80)
{
    Console.WriteLine("Grade B");
}
else if (average >= 70)
{
    Console.WriteLine("Grade C");
}
else if (average >= 60)
{
    Console.WriteLine("Grade D");
}
else
{
    Console.WriteLine("Grade F");
}






