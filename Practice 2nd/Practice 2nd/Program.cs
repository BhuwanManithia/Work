//  ====================================================
//1


//Console.WriteLine("Enter Your Height in feet: ");
//double height = double.Parse(Console.ReadLine());

//Console.WriteLine($"Your Height is {height}");




//  =====================================================
//2

//Console.WriteLine("Enter Your Name: ");
//string name = Console.ReadLine();

//Console.WriteLine("Enter Your Age: ");
//int age = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter Your Weight");
//double weight = double.Parse(Console.ReadLine());

//Console.WriteLine($"Your Name is {name}");
//Console.WriteLine($"Your Age is {age}");
//Console.WriteLine($"Your Age is {weight}");




//  ===================================================
//3


//Console.Write("Enter Your Grade Letter : ");
//char grade = char.Parse(Console.ReadLine());

//Console.WriteLine($"Grade is {grade}");




//  ===============================================
//4


//Console.WriteLine("Do you play cricket? type true or false");
//bool cricket = Boolean.Parse(Console.ReadLine());

//Console.WriteLine($"Do you play cricket = {cricket}");



//  ==========================================================
//5


//Console.WriteLine("Enter Pen cost: ");
//decimal cost = decimal.Parse(Console.ReadLine());

//Console.WriteLine($"A Pen costs: {cost}");



//  =============================================================
//6

//long indianpopulation = 1480000000L;

//Console.WriteLine($"Indian Plulation is {indianpopulation}");



//  ==================================================================
//7



//Console.WriteLine("Enter Student Name: ");
//string name = Console.ReadLine();

//Console.WriteLine("Enter Grade: ");
//char grade = char.Parse(Console.ReadLine());

//Console.WriteLine("Enter Marks Percentage: ");
//double percentage = double.Parse(Console.ReadLine());

//Console.WriteLine($"Your Name is {name}");
//Console.WriteLine($"Your Grade is {grade}");
//Console.WriteLine($"Your Percentage is {percentage}");




//  ==============================================================
//8


//Console.WriteLine("Enter 1st Double Number: ");
//double one = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter 2nd Double Number: ");
//double two = double.Parse(Console.ReadLine());

//Console.WriteLine($"The Division is: {one / two}");



//  ===============================================================
//9


//Console.WriteLine("What is the Temp: ");
//double temp = double.Parse(Console.ReadLine());

//Console.WriteLine($"Today Temprature is {temp}");



//  =======================================================
//10


//Console.WriteLine("Enter Your Name: ");
//string name = Console.ReadLine();

//Console.WriteLine("Enter Your Roll No. : ");
//int roll = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter Your Section: ");
//char section = char.Parse(Console.ReadLine());

//Console.WriteLine("Enter Fee Paid: ");
//double fee = double.Parse(Console.ReadLine());

//Console.WriteLine($"Name: {name}");
//Console.WriteLine($"Roll No. : {roll}");
//Console.WriteLine($"Section : {section}");
//Console.WriteLine($"Fee Paid : {fee}");





// Part--2




//  ------------------------------------------------------------------
//11

//Console.WriteLine("Enter Math Marks: ");
//double math = double.Parse(Console.ReadLine());


//Console.WriteLine("Enter English Marks: ");
//double english = double.Parse(Console.ReadLine());


//Console.WriteLine("Enter Hindi Marks: ");
//double hindi = double.Parse(Console.ReadLine());

//double total = math + english + hindi;

//Console.WriteLine($"Total Marks: {total}");
//Console.WriteLine($"The Average is {total / 3}");




//  ===========================================================
//12



//Console.WriteLine("Enter Temp in celcius: ");
//double tempc = double.Parse(Console.ReadLine());

//double fer = (tempc * 9 / 5) + 32;

//Console.WriteLine($"The Temprature is In Feranites is : {fer}");



//  ==============================================================
//13



//Console.WriteLine("Enter The radius of Circle: ");
//double radius = double.Parse(Console.ReadLine());

//double area = 3.14 * radius * radius;

//Console.WriteLine($"The area is {area}");





//  ===============================================================
//14




//Console.WriteLine("Enter The Room Length: ");
//double length = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter The Room Weight: ");
//double weight = double.Parse(Console.ReadLine());

//double area = length * weight;

//Console.WriteLine($"The area is {area}");




//  ===============================================
//15



//Console.WriteLine("Enter Price: ");
//double price = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter Quantity: ");
//double quantity = double.Parse(Console.ReadLine());

//Console.WriteLine($"Price: {price}");
//Console.WriteLine($"Quantity: {quantity}");
//Console.WriteLine($"Total price: {price * quantity}");


//  ====================================================
//16


//Console.WriteLine("Enter 2 digit number: ");
//int num = int.Parse(Console.ReadLine());

//int tens = num / 10;
//int ones = num % 10;

//Console.WriteLine($"The Tens is {tens}");
//Console.WriteLine($"The Ones is {ones}");




//  =====================================================
//17



//Console.WriteLine("Enter Total Minutes: ");
//int minu = int.Parse(Console.ReadLine());

//Console.WriteLine($"In Houre is =  {minu / 60}houre {minu % 60}Minutes");


//  ======================================================================
//18


//int amount = 545;


//int notes100 = amount / 100;
//int leftover = amount % 100;

//Console.WriteLine($"{amount} → {notes100} notes of 100 rupees and {leftover} rupees left over");




//  ========================================================================
//19


//double principal = 5000.0;
//double rate = 7.5;
//double years = 3.5;

//double interest = (principal * rate * years) / 100.0;

//Console.WriteLine($"Principal: {principal}, Rate: {rate}%, Years: {years}");
//Console.WriteLine($"Simple Interest = {interest}");



//   ===========================================================================
//20


//Console.Write("Enter marks for Subject 1: ");
//double sub1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter marks for Subject 2: ");
//double sub2 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter marks for Subject 3: ");
//double sub3 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter marks for Subject 4: ");
//double sub4 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter marks for Subject 5: ");
//double sub5 = Convert.ToDouble(Console.ReadLine());


//double total = sub1 + sub2 + sub3 + sub4 + sub5;
//double average = total / 5.0;
//double percentage = (total / 500.0) * 100.0;


//Console.WriteLine($"Total Marks: {total} / 500");
//Console.WriteLine($"Average Marks: {average}");
//Console.WriteLine($"Percentage: {percentage}%");




//int v1 = 10;
//int v2 = 20;

//v1 = v1 + v2;
//v2 = v1 - v2;
//v1 = v1 - v2;

//Console.WriteLine(v1);
//Console.WriteLine(v2);