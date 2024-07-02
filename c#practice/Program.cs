using System;
using System.Runtime.InteropServices;
// arithemetic operators
/*
int sum1 = 20;
int sum2 = sum1+50; //70
int sum3 = sum2 + 100;  //170
Console.WriteLine(sum1);
Console.WriteLine(sum2);
Console.WriteLine(sum3);
Console.ReadLine();
*/
/*
int x  = 12;
int y = 3;
Console.WriteLine(x*y);
*/

/*
int x = 15;
int y = 5;
Console.WriteLine(x-y);
Console.ReadLine();
*/
/*
int X = 20;
int Y = 2;
Console.WriteLine(X / Y);
Console.ReadLine();
*/
/*
int x  = 53;
x++;
Console.WriteLine(x);
Console.ReadLine();
*/
/*
int x = 50;
int y = 7;
Console.WriteLine(x%y);
Console.ReadLine();
*/

// asignment operators
/*
int x = 8;
x += 3;
Console.WriteLine(x);
Console.ReadLine(); 
*/
/*
int x = 23;
x -= 3;
Console.WriteLine(x);
Console.ReadLine();
*/
/*
int x = 10;
x *= 3;
Console.WriteLine(x);
Console.ReadLine();
*/
/*
int x = 30;
x/= 3;
Console.WriteLine(x);
Console.ReadLine();
*/
/*
int y = 45;
y &= 8;
Console.WriteLine(y);
Console.ReadLine();
*/
/*
int y = 36;    //2 will be added in 36
y|= 2;
Console.WriteLine(y);
*/
// comparison operator 
/*
int x  =5 ;
int y =3 ;
Console.WriteLine(x==y);
Console.ReadLine(); 
*/
/*
int x = 10;
int y = 20;
Console.WriteLine(x>y);
Console.ReadLine();
*/
/*
int x = 10;
int y = 20;
Console.WriteLine(x<y); 
Console.ReadLine();
*/
/*
int x  = 50;
int y = 20;
Console.WriteLine(x>=y);
Console.ReadLine();
*/
/*
int x = 30;
int y = 50;
Console.WriteLine(x <= y);
Console.ReadLine();
*/
//logical operator
/*
int x = 20;
Console.WriteLine(x>5 && x<100);
Console.ReadLine();
*/
/*
int x = 40;
Console.WriteLine(x>10 ||x <5);
Console.ReadLine();
*/
/*
int x = 90;
Console.WriteLine(!(x > 45 && x < 110));
Console.ReadLine();
*/
//c# math
/*
Console.WriteLine(Math.Max(5, 15));
Console.ReadLine();
Console.WriteLine(Math.Min(5, 15));
Console.ReadLine();
*/
/*
Console.WriteLine(Math.Sqrt(100));
Console.ReadLine();
*/
// STRING
/*
string greeting = "hello";
Console.WriteLine(greeting);
Console.ReadLine();
*/
/*
string admission = "present sir";
Console.WriteLine(admission);
Console.ReadLine();
*/
/*
string greeting = "hello";
string greeting2 = "how are you?";
Console.WriteLine(greeting);    
Console.WriteLine(greeting2);
Console.ReadLine();
*/
/*
string txt = "prabhjotsingh";
Console.WriteLine("The length of the txt string is:" +txt.Length);
Console.ReadLine();
*/
/*
string txt = "prabhjotsingh";
string txt2 = "lieutenant";                                                         //from own side
Console.WriteLine("The length of the txt string is:" + txt.Length);
Console.WriteLine("The length of the txt2 string is:" + txt2.Length);
Console.ReadLine();
*/
/*
string txt = "Hello Buddy";
Console.WriteLine(txt.ToUpper());
Console.WriteLine(txt.ToLower());
Console.ReadLine();
*/
// string concatenation
/*
string FirstName = "prabh";
string LastName = "singh";
string Name = FirstName+LastName;
Console.WriteLine(Name);
Console.ReadLine(); 
*/
/*
string FirstName = "prabh";
string LastName = "singh";
string name = string.Concat(FirstName, LastName);   
Console.WriteLine(name);    
Console.ReadLine(); 
*/
//Adding numbers and strings 
/*
int x = 17;
int y = 30;
int z = x + y;
Console.WriteLine(z);
*/
//interpoliation
/*
string FirstName = "prabhjot";
string LastName = "singh";
string name = $" my name is {FirstName}{LastName}";
Console.WriteLine(name);
Console.ReadLine();
*/
// access string
/*
string greeting="hello";
Console.WriteLine(greeting[4]);
Console.ReadLine();
*/
// using indexof in access string 
/*
string greeting = " hello world";
Console.WriteLine(greeting.IndexOf("r"));
Console.ReadLine();
*/
/*
string name = "prabhjot singh";
int charPos = name.IndexOf("h");
string lastName=name.Substring(charPos);
Console.WriteLine(lastName);
*/
// special characters string 2july 2024
/*
string txt = "Welcome to \"the coding\" ninjas session";
    Console.WriteLine(txt);
Console.ReadLine();
*/
/*
string txt = "i don\'t want you to come in my way";
Console.WriteLine(txt);
Console.ReadLine();
*/
/*
string txt = "i will go\\gone to market";          //tick the right option 
Console.WriteLine(txt); 
Console.ReadLine();
*/
//Boolean
/*
bool doyoulikecoding = true;
bool doyoulikeswimming = false;
Console.WriteLine(doyoulikecoding);
Console.WriteLine(doyoulikeswimming);
Console.ReadLine();
*/
/*
int x = 50;
int y = 90;
Console.WriteLine(x>y); 
Console.ReadLine();
*/
/*
int myage = 25;
int votingage  = 18;
Console.WriteLine(myage>=votingage);
Console.ReadLine(); 
*/
// boolean if-else
/*
int myage = 25;
int myfriendage = 18;
if (myage >= myfriendage)
    Console.WriteLine("i am elder than my friend!");
else
    Console.WriteLine("my friend is elder than me");
Console.ReadLine();
*/
//    if-else
//IF
/*
if (1000>580)
    Console.WriteLine("YES!1000 IS GREATER THAN 580");
Console.ReadLine(); 
*/
/*
int x = 25;
int y = 53;
if (x<y)
Console.WriteLine("YES!53 IS GREATER THAN 25");
Console.ReadLine();
*/
/*
int time = 1200;
if (time > 1200)
    Console.WriteLine("GOOD AFTERNOON");
else
    Console.WriteLine("GOOD MORNING");
Console.ReadLine(); 
*/
/*
int time = 1400;
if (time > 1300)
    Console.WriteLine("GOOD AFTERNOON");
else if (time < 0900)
    Console.WriteLine("GOOD MORNING");
else
    Console.WriteLine("GOOD DAY");
Console.ReadLine();
*/
//short hand if - else
/*
int salary = 20000;
string result = (salary > 30000)?"enjoy the vaccation." : "you need to spend carefully.";
Console.WriteLine(result);
Console.ReadLine();
*/
//switch
/*
int list = 4;
switch (list)
{
    case 1:
        Console.WriteLine("Intro");
        break;
    case 2:
        Console.WriteLine("acknowledgement");
        break;
    case 3:
        Console.WriteLine("index");
        break;
    case 4:
        Console.WriteLine("summary");
        break;
}
Console.ReadLine();
*/
//LOOP
// while loop
/*
int i = 3;
while (i < 10) 
{
    Console.WriteLine(i);
    i++;
}
Console.ReadLine();
*/
//DO WHILE
/*
int i = 5;
do
{
    Console.WriteLine(i);
    i++;
}
while (i<11);
Console.ReadLine();
*/
// FOR LOOP
/*
for (int i = 3;i<13;i++)
{
    Console.WriteLine(i);
}
Console.ReadLine();
*/
/*
for (int i = 3; i < 15;i=i+3)
{
  Console.WriteLine(i);
}
Console.ReadLine();
*/
/*
for (int i = 1; i <= 2; ++i)
{
    Console.WriteLine("Outer: " + i);  // Executes 2 times

    // Inner loop
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine(" Inner: " + j);  // Executes 6 times (2 * 3)
    }
}
*/
/*
for (int i = 0; i < 10; i++)
{
    if (i == 8)
    {
        break;
    }
    Console.WriteLine(i);
}
Console.ReadLine();
*/
/*
for (int i = 0; i < 12; i++)
{
    if (i == 7)
    {
        continue;
    }
    Console.WriteLine(i);
}
Console.ReadLine();
*/
/*
int i = 0;
while(i<15)
{
    Console.WriteLine(i);
    i++;
    if (i==6)
    {
        break;
    }
}
*/
/*
int i = 0;
while (i < 14)
{
    if (i == 6)
    {
        i++;
        continue;
    }
    Console.WriteLine(i);
    i++;
}
*/
//array
/*
string[] cars = { "mustang", "bmw", "gtr", "mercedes" };
Console.WriteLine(cars[2]);
Console.WriteLine(cars[3]);
Console.ReadLine(); 
*/
//loop through an array
/*
string[] cars = { "bmw", "mercedes", "mustang", "fortuner", "audi" };
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}
*/
/*
string[] username = { "abhishek", "raghu", "anshu", "altaf", "kabir" };                 //my own example
for (int i = 0; i < username.Length; i++)
{
    Console.WriteLine(username[i]);
}
*/
//for each loop
/*
string[] teachers = { "monika", "jaswinder", "kuldeep", "vishali" };
foreach (string i in teachers)
{
    Console.WriteLine(i);
}
Console.ReadLine();
*/
/*
string[] teachers = { "monika", "jaswinder", "anu", "bhavya" };
Array.Sort(teachers);
foreach (string i in teachers)
{
    Console.WriteLine(i);
}
*/
