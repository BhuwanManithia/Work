//Part A — Simple if-else (10 problems)

// 1. Elevator Overload

//Console.WriteLine("Enter Total humans: ");
//int totalHumans = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Total Weight(KG): ");
//double totalWeight = Convert.ToDouble(Console.ReadLine());

//if (totalWeight > 680)
//{
//    Console.WriteLine("Elevator Overload");
//}
//else
//{
//    Console.WriteLine("Elevator is safe to use");
//}


// ====================================================

//2. Parking Fee

//Console.WriteLine("Enter Your Parking Time: ");
//int parkingTime = Convert.ToInt32(Console.ReadLine());

//if (parkingTime > 30)
//{
//    Console.WriteLine("Amount to pay: 50");
//}
//else
//{
//    Console.WriteLine("Free Parking");
//}



// ====================================================

//3. Battery Warning

//Console.WriteLine("Enter Battery Percentage: ");
//int battery = Convert.ToInt32(Console.ReadLine());

//if (battery < 20)
//{
//    Console.WriteLine("Enable power saving mode");
//}
//else
//{
//    Console.WriteLine("Battery OK");
//}


// ====================================================

//4. Typing Speed

//Console.WriteLine("Enter Total Words Typed: ");
//double words = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter Total Minutes Taken: ");
//double minutes = Convert.ToDouble(Console.ReadLine());

//double speed = words / minutes;

//if (speed >= 40)
//{
//    Console.WriteLine("Fast typist");
//}
//else
//{
//    Console.WriteLine("Keep practicing");
//}


// ====================================================

//5. Pizza Delivery Zone

//Console.WriteLine("Enter Delivery Distance(KM): ");
//int distance = Convert.ToInt32(Console.ReadLine());

//if (distance <= 5)
//{
//    Console.WriteLine("Delivery Charge: 0");
//}
//else
//{
//    int charge = (distance - 5) * 10;
//    Console.WriteLine("Delivery Charge: " + charge);
//}


// ====================================================

//6. Password Space Check

//Console.WriteLine("Enter Password: ");
//string password = Console.ReadLine();

//if (password.Contains(' '))
//{
//    Console.WriteLine("Invalid: spaces not allowed");
//}
//else
//{
//    Console.WriteLine("Password accepted");
//}


// ====================================================

//7. Water Tank Alert

//Console.WriteLine("Enter Tank Capacity(Litres): ");
//double capacity = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter Current Water Level(Litres): ");
//double waterLevel = Convert.ToDouble(Console.ReadLine());

//if (waterLevel < (capacity * 0.10))
//{
//    Console.WriteLine("Pump ON");
//}
//else
//{
//    Console.WriteLine("Pump OFF");
//}


// ====================================================

//8. Screen Time

//Console.WriteLine("Enter Today's Screen Time(Minutes): ");
//int screenTime = Convert.ToInt32(Console.ReadLine());

//if (screenTime > 360)
//{
//    Console.WriteLine("Take a break!");
//    Console.WriteLine("Over Limit By: " + (screenTime - 360) + " Minutes");
//}
//else
//{
//    Console.WriteLine("Healthy usage");
//}


// ====================================================

//9. Train Waiting List

//Console.WriteLine("Enter Waiting List Number: ");
//int waitingList = Convert.ToInt32(Console.ReadLine());

//if (waitingList <= 10)
//{
//    Console.WriteLine("High chance of confirmation");
//}
//else
//{
//    Console.WriteLine("Consider another train");
//}


// ====================================================

//10. Refund Window

//Console.WriteLine("Enter Days Since Purchase: ");
//int days = Convert.ToInt32(Console.ReadLine());

//if (days <= 7)
//{
//    Console.WriteLine("Refund approved");
//}
//else
//{
//    Console.WriteLine("Refund window closed");
//}




// Part B — Nested if-else (10 problems)


// ====================================================

//1. Cab Surge Pricing

//Console.WriteLine("Enter Current Hour(0-23): ");
//int hour = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Base Fare: ");
//double fare = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Is it Raining? (y/n): ");
//char rain = Convert.ToChar(Console.ReadLine());

//if ((hour >= 8 && hour <= 10) || (hour >= 17 && hour <= 20))
//{
//    if (rain == 'y')
//    {
//        fare = fare * 2;
//    }
//    else
//    {
//        fare = fare * 1.5;
//    }
//}

//Console.WriteLine("Final Fare: " + fare);


// ====================================================

//2. Baggage Fee

//Console.WriteLine("Enter Travel Class (E/B): ");
//char travelClass = Convert.ToChar(Console.ReadLine());

//Console.WriteLine("Enter Bag Weight(KG): ");
//int bagWeight = Convert.ToInt32(Console.ReadLine());

//if (travelClass == 'E')
//{
//    if (bagWeight <= 15)
//    {
//        Console.WriteLine("Baggage Fee: 0");
//    }
//    else
//    {
//        Console.WriteLine("Baggage Fee: " + ((bagWeight - 15) * 500));
//    }
//}
//else
//{
//    if (bagWeight <= 30)
//    {
//        Console.WriteLine("Baggage Fee: 0");
//    }
//    else
//    {
//        Console.WriteLine("Baggage Fee: " + ((bagWeight - 30) * 300));
//    }
//}


// ====================================================

//3. Blood Donation Eligibility

//Console.WriteLine("Enter Age: ");
//int age = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Weight(KG): ");
//int weight = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Months Since Last Donation: ");
//int months = Convert.ToInt32(Console.ReadLine());

//if (age >= 18 && age <= 60)
//{
//    if (weight >= 50)
//    {
//        if (months >= 3)
//        {
//            Console.WriteLine("Eligible for Blood Donation");
//        }
//        else
//        {
//            Console.WriteLine("Rejected: Last donation was less than 3 months ago");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Rejected: Weight must be at least 50 KG");
//    }
//}
//else
//{
//    Console.WriteLine("Rejected: Age must be between 18 and 60");
//}


// ====================================================

//4. Warranty Claim

//Console.WriteLine("Months Since Purchase: ");
//int purchaseMonths = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Physical Damage? (y/n): ");
//char damage = Convert.ToChar(Console.ReadLine());

//if (purchaseMonths <= 12)
//{
//    if (damage == 'n')
//    {
//        Console.WriteLine("Free repair");
//    }
//    else
//    {
//        Console.WriteLine("Paid repair");
//    }
//}
//else
//{
//    Console.WriteLine("Warranty expired");
//}


// ====================================================

//5. Video Quality Selector

//Console.WriteLine("Enter Internet Speed(Mbps): ");
//int speed = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Data Saver Mode (on/off): ");
//string mode = Console.ReadLine();

//if (speed >= 25)
//{
//    if (mode == "on")
//    {
//        Console.WriteLine("720p");
//    }
//    else
//    {
//        Console.WriteLine("4K");
//    }
//}
//else if (speed >= 5)
//{
//    Console.WriteLine("480p");
//}
//else
//{
//    Console.WriteLine("Audio only");
//}


// ====================================================

//6. Hostel Mess Rebate

//Console.WriteLine("Enter Days Absent: ");
//int absent = Convert.ToInt32(Console.ReadLine());

//if (absent > 15)
//{
//    Console.WriteLine("Full rebate");
//}
//else if (absent > 7)
//{
//    Console.WriteLine("Leave Application Submitted? (y/n): ");
//    char leave = Convert.ToChar(Console.ReadLine());

//    if (leave == 'y')
//    {
//        Console.WriteLine("Half rebate");
//    }
//    else
//    {
//        Console.WriteLine("No rebate");
//    }
//}
//else
//{
//    Console.WriteLine("No rebate");
//}


// ====================================================

//7. Gaming Level Unlock

//Console.WriteLine("Enter Player Score: ");
//int score = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Boss Defeated? (y/n): ");
//char boss = Convert.ToChar(Console.ReadLine());

//if (score >= 1000)
//{
//    if (boss == 'y')
//    {
//        Console.WriteLine("Level 3 unlocked");
//    }
//    else
//    {
//        Console.WriteLine("Defeat the boss first");
//    }
//}
//else
//{
//    Console.WriteLine("Score too low");
//}


// ====================================================

//8. AC Auto Mode

//Console.WriteLine("Enter Room Temperature: ");
//int temperature = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Humidity: ");
//int humidity = Convert.ToInt32(Console.ReadLine());

//if (temperature > 30)
//{
//    if (humidity > 70)
//    {
//        Console.WriteLine("Cool + Dry mode");
//    }
//    else
//    {
//        Console.WriteLine("Cool mode");
//    }
//}
//else if (temperature >= 24)
//{
//    Console.WriteLine("Fan mode");
//}
//else
//{
//    Console.WriteLine("AC off");
//}


// ====================================================

//9. Traffic Fine

//Console.WriteLine("Enter Vehicle Speed: ");
//int vehicleSpeed = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Repeat Offender? (y/n): ");
//char repeat = Convert.ToChar(Console.ReadLine());

//if (vehicleSpeed > 60)
//{
//    if (vehicleSpeed > 80)
//    {
//        if (repeat == 'y')
//        {
//            Console.WriteLine("Fine: 5000");
//        }
//        else
//        {
//            Console.WriteLine("Fine: 2000");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Fine: 1000");
//    }
//}
//else
//{
//    Console.WriteLine("No Fine");
//}


// ====================================================

//10. Movie Ticket Kiosk

//Console.WriteLine("Enter Age: ");
//int personAge = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Show Time(0-23): ");
//int showTime = Convert.ToInt32(Console.ReadLine());

//if (personAge < 18)
//{
//    if (showTime > 22)
//    {
//        Console.WriteLine("Not allowed");
//    }
//    else
//    {
//        Console.WriteLine("Ticket Price: 120");
//    }
//}
//else if (personAge >= 60)
//{
//    Console.WriteLine("Ticket Price: 100");
//}
//else
//{
//    Console.WriteLine("Ticket Price: 200");
//}