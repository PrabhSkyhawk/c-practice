using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ObjectiveC;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
namespace MyApplication
{
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
    /*
    int[] myNumbers = { 5, 1, 8, 9 };
    Console.WriteLine(myNumbers.Max());  // returns the largest value
    Console.WriteLine(myNumbers.Min());  // returns the smallest value
    Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
    */
    /*
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("i am learning c");
        }
        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();
        }
    }
    }

    */
    /*    class Program
        {
            static void MyMethod(string lname)
            {
                Console.WriteLine("SEHAJ"+ lname);
            }
            static void Main(string[] args)
            {
                MyMethod("singh");
                MyMethod("saini");
                MyMethod("khan");
            }
        }
    }
    */
    /*
    class Program
    {
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + "is" + age);
        }
        static void Main(string[] args)
        {
            MyMethod("SEHAJ", 15);
            MyMethod("AMRIT", 100);
            MyMethod("GOLDY", 25);

        }
    }
    }
    */
    /*
    class Program
    {
        static void MyMethod(string fname, int salary)
        {
            Console.WriteLine(fname + "earns" + "rs" + salary);
        }
        static void Main(string[] args)
        {
            MyMethod("SEHAJ", 20000);
            MyMethod("SAMRAT", 40000);
            MyMethod("PRABH", 10000);
        }
    }
        }
    */
    /*
    class Program
    {
        static void MyMethod(string attendance = "shruti")
        {
            Console.WriteLine(attendance);
        }
        static void Main(string[] args)
        {
            MyMethod("rabya");
            MyMethod("tanu");
            MyMethod();
            MyMethod("aman");
        }
    }
    }
    */
    /*
    class Program
    {
        static int MyMethod(int x)
        {
            return 5 + x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(3));
        }
    }
    }
    */
    /*
    class Program
    {
        static int MyMethod(int x)
        {
            return 100 - x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(5));
        }
    }
    }
    */
    // 4 july
    /*
    class Program
    {
        static double MyMethod(double x)
        {
            return 2.6 + x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(9.5));
        }
    }
    }
    */
    /*
    class Program
    {
        static double MyMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(2.88, 8.6));
        }
    }
    }
    */
    /*
    class Program
    {
        static double MyMethod(double x, double y, double z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            double a = MyMethod(2.3, 4.5, 6.7);
            Console.WriteLine(a);
        }
    }
    }
    */
    /*
    class Program
    {
        static void MyMethod(string student1, string student2, string student3)
        {
            Console.WriteLine("The topper of the class is:" + student1);
        }
        static void Main(string[] args)
        {
            MyMethod(student1: "raghav", student2: "abhi", student3: "nishant");
        }
    }
    }
    */
    /*
    class Program
    {
        static void MyMethod(string visitor1, string visitor2, string visitor3)
        {
            Console.WriteLine("The visitor with most wealth is :" +visitor3);
        }
        static void Main(string[] args)
        {
            MyMethod(visitor1: "rajneesh", visitor2: "mandeep",visitor3:"sehaj");
        }
    }
    }
    */
    /*
    class Program
    {
        static int MyMethod(int x, int y)
        {
            return x + y;
        }
        static double MyMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int mynum1 = MyMethod(1, 2);
            double mynum2 = MyMethod(2.9, 3.1);
            Console.WriteLine("int: " +mynum1);
            Console.WriteLine("double:"+ mynum2);
        }
    }
    }
    */
    //c# classes creating new object 
    /*
    class BIKE
    {
        string color = "black";
        static void Main(string[] args)
        {
            BIKE Myobj = new BIKE();
            Console.WriteLine(Myobj.color);
        }
    }
    }
    */
    //multipple classes and objects 
    /*
    class Bike
    {
        string color = "black";
        int model = 2024;
        static void Main(string[] args)
        {
            Bike Mybike1 = new Bike();
            Bike Mybike2 = new Bike();
            Console.WriteLine(Mybike1.color);
            Console.WriteLine(Mybike2.model);
        }
    }

    class Car 
    {
       static void Main(string[] args)
        {
            Bike Mybike1 = new Bike();
            Console.WriteLine(Mybike1);
        }
    }
    }
    */
    /*                    //fields left blank
    class Car
    {
        string color;
        int model;
        static void Main(string[] args)
        {
            Car Myobject = new Car();
            Myobject.color = "red";
            Myobject.model = 2024;
            Console.WriteLine(Myobject.color);
            Console.WriteLine(Myobject.model);
        }
    }
    }
    */
    /* //////////////////////////////// fields used forr multiple objects
     class Car
     {
         string name;
         int model;
         static void Main(string[] args)
         {
             Car Ford = new Car();
             Ford.name = "mustang";
             Ford.model = 2024;

             Car Toyata = new Car();
             Toyata.name = "fortuner";
             Toyata.model = 2024;

             Car landrover = new Car();
             landrover.name = "range rover";
             landrover.model = 2024;

             Console.WriteLine(Ford.name);
             Console.WriteLine(Toyata.name);
             Console.WriteLine(landrover.model);
         }
     }
    }
    */
    //inheritance 
    /*
    class Vehicle
    {
        public string brand = "ford";
        public void honk()
        {
            Console.WriteLine("Side plz");
        }
    }
    class Car : Vehicle
    {
        public string modelname = "mustang";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car Mycar = new Car();
            Mycar.honk();
            Console.WriteLine(Mycar.brand + "" + Mycar.modelname);
        }
    }
    }
    */
    //5 july   constructor
    /*
    class Program
    {
        public Program()
        {
            Console.WriteLine("I am learner");
        }
        static void Main(string[] args)
        {
            Program MyObject = new Program();
        }
    }
    }
    */
    /*
    class Car
    {
        string carModel;
        int carYear;
        double carPower;
        public Car(string model,int year,double power)
        {
            carModel = model;
            carYear = year;
            carPower = power;
        }
        static void Main(string[] args)
        {
            Car MyCar = new Car("mustang", 2023, 7.4);
            Console.WriteLine("model:" + MyCar.carModel);
            Console.WriteLine("year:" + MyCar.carYear);
            Console.WriteLine("power:" + MyCar.carPower);
        }
    }
    }
    */
    /*
    class Car
    {
        string carModel;
        int carYear;
        double carPower;
        public Car(string model, int year, double power)
        {
            carModel = model;
            carYear = year;
            carPower = power;
        }
        public Car(string model, double power, int year)
        {
            carModel = model;
            carYear = year;
            carPower = power;
        }
        public Car(double power, string model, int year)
        {
            carModel = model;
            carYear = year;
            carPower = power;
        }
        static void Main(string[] args)
        {
            Car MyCar = new Car("mustang", 2023, 7.4);
            Console.WriteLine("model:" + MyCar.carModel);
            Console.WriteLine("year:" + MyCar.carYear);
            Console.WriteLine("power:" + MyCar.carPower);
        }
    }
    }
    */
    // access modifiers
    /*
    class Car                  //////////////PRIVATE MODIFIER
    {
        private string model = "mustang";
        static void Main(string[] args)
        {
            Car myobj = new Car();
            Console.WriteLine(myobj.model);
            Console.ReadLine(); 
        }
    }
    }
    */
    /*
    class Car  /////////////////////////////////////////////////PUBLIC ACCESS MODIFIER
    {
        public string model = "Mustang";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }
    }
    */
    /*
    class Attendance               //Inaccessible bcoz of private modifier
    {
       int attendance = 10;
    }

    class Salary
    {
        static void Main(string[] args)
        {
            Attendance myattendance = new Attendance();
            myattendance.attendance = 7;
        }
    }
    }
    */
    /*
    class Car
    {
        int manufactured = 2024;         //Inaccessbile due to protection level 
    }
    class Bike
    {
        static void Main(string[] args)
        {
            Car vehciledetails = new Car();
            vehciledetails.manufactured = 2019;
        }
    }
    }
    */
    /*
    class Car
    {
        int model = 2024;
        public void SetBalance(int amount)                          //updating private class using SETBALANCE
        {
            model = amount;
        }
        class Bike
        {
            static void Main(string[] args)
            {
                Car cardetail = new Car();
                cardetail.SetBalance(20000);
            }
        }
    }
    }
    *//*
    class School
    {
        int attendance = 40;
        public void SetBalance(int record)
        {
            attendance = record;
        }

    }
    class College
    {
        static void Main(string[] args)
        {
            School register = new School();
            register.SetBalance(23)
                ;
        }
    }
    }

    */
    /*
    class School
    {
        int attendance = 40;
        public void SetBalance(int record)
        {
            attendance = record;
        }
        public void GetBalance()
            { 
            Console.WriteLine("No of students present is:"+attendance);
        }
    }
    class College
    {
        static void Main(string[] args)
        {
            School register = new School();
            register.SetBalance(23);
            register.GetBalance();
                
        }
    }
}
*/
    // polymorphism // method overloading
    /*
    class Program
    {
        void sum(int a, int b)                // diff parameters of same method 
        {
            Console.WriteLine(a + b);
        }
        void sum(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            Program myobj = new Program();
            myobj.sum(1, 2);
            myobj.sum(2.7f,1.2f);
        }
    }
}
*/
    /*
class Program
{
    void sum(int a, int b)                // diff  no of parameters of same method 
    {
        Console.WriteLine(a + b); // 2 integer parameters
    }
    void sum(int  a, int b, int c)  // 3 integer parameters
    {
        Console.WriteLine(a + b+c);
    }
    static void Main(string[] args)
    {
        Program myobj = new Program();  
        myobj.sum(1, 2);        //if only 2 values are entered then first method will be executed
            myobj.sum(1, 2,3);    //now this is for ecxecution of 2 method
        }
}
}
    */
    /*
    class Program
    {
        void sum(int a, float b)                // diff sequence of parameters of same method 
        {
            Console.WriteLine(a + b);          //int,float
        }
        void sum(float a, int b)  // float,int
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            Program myobj = new Program();
            myobj.sum(1, 2.6f);
            myobj.sum(2.7f, 1);
        }
    }
}
*/
    //method overriding
    /*
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("animal is eating");
        }
    }
    class Dog : Animal
    {
        public static void Main(string[] args)
        {
            Dog tommy = new Dog();
            tommy.eat();
        }
    }
}
    */