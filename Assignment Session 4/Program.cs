using Assignment_Session_4.Classes;
using Assignment_Session_4.Derived_Classes;
using Assignment_Session_4.Base_Classes;
namespace Assignment_Session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            #region Q1) Write a class named Calculator that contains a method named Add.Overload the Add method to:
            ///Accept two integers and return their sum.
            ///Accept three integers and return their sum.
            ///Accept two doubles and return their sum. 

            Calculator calculator = new Calculator();
            //since we did an Method Overloading the complier will decide to call which Method based on Number & Types of Paramters
            int result1 = calculator.Add(1, 2);//Add Method to Accept two integers and return their sum.
            Console.WriteLine(result1);//3

            int result2 = calculator.Add(1, 2, 3);//Add Method to Accept three integers and return their sum.
            Console.WriteLine(result2);//6

            double result3 = calculator.Add(1.2, 2.1);//Add Method to Accept two doubles and return their sum.
            Console.WriteLine(result3); //3.3

            #endregion

            #region Q2) Create a class named Rectangle with the following constructors:
            ///A parameterless constructor that sets the width and height to 0.
            ///A constructor that accepts width and height as integers.
            ///A constructor that accepts a single integer and sets both width and height to that value.

            //since we did an Constructor Overloading the complier will decide to call which Constructor based on Number & Types of Paramters
            Rectangle rectangle;
            rectangle = new Rectangle(); //A parameterless constructor that sets the width and height to 0.
            Console.WriteLine(rectangle);//Height = 0 , Width = 0 

            rectangle = new Rectangle(1, 2); //A constructor that accepts width and height as integers.
            Console.WriteLine(rectangle); //Height = 1 , Width = 2

            rectangle = new Rectangle(10); //A constructor that accepts a single integer and sets both width and height to that value.
            //Console.WriteLine(rectangle); //Height = 10 , Width = 10
            #endregion

            #region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
            //*Note: Overload the +, - operator to add and subtract two complex numbers.
            Complex C1 = new Complex() { Real = 10, Img = 6 };
            Complex C2 = new Complex() { Real = 5, Img = 3 };
            Complex C3;
            C3 = C1 + C2; //Since that Complier doesnt know how to calulate them we have to do Operator Overloading to make it valid 
            //Now its Valid After Operator Overloading on '+'
            Console.WriteLine(C3); // 15 + 9i

            C3 = C1 - C2; //Since that Complier doesnt know how to calulate them we have to do Operator Overloading to make it valid
            //Now its Valid After Operator Overloading on '-'
            Console.WriteLine(C3); //Complex Number = 5 + 3i
            #endregion

            #region Question 4) 
            //a) Create a base class named Employee with method That Work as it prints "Employee is  working". 
            //b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
            //*Ensure that the Manager class also calls the Work method of the Employee class within its Overridden method.

            Manager manager = new Manager();
            manager.Work(); //Employee is working
                            //Manager is managing
            #endregion

            #region Question 5)
            //a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass".
            //b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.
            //C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.
            // Then explain the difference between using override and new (using binding behavior)

            //since BaseClass Method was Virtual and we used Override Keyword in DerivedClass1
            BaseClass RefBase = new DerivedClass1(); //Reference From Base refers to Object from Derived (DerivedClass1)
                                                     //its Dynamic polymorphism | Dynamic binding | Late Binding
                                                     //it reslove during Run Time
                                                     //Compile will bind Method Based on Object Type
            RefBase.DisplayMessage(); // Message from DerivedClass1 
                                      //Since it used Override keyword so it will bind based on Object Type which is (DerivedClass1) == > Message from DerivedClass1 

            //Since we used "New" Keyword in DerivedClass2
            BaseClass RefBase2 = new DerivedClass2(); //Reference From Base refers to Object from Derived (DerivedClass1)
                                                      //its Static polymorphism | Static binding | Early Binding
                                                      //it reslove during Compilation Time
                                                      //Compile will bind Method Based on Reference Type
            RefBase2.DisplayMessage(); //Message from BaseClass 
                                       //Since it used New keyword so it will bind based on Reference Type which is (BaseClass) == > Message from BaseClass 
            #endregion

            #endregion

            #region Part 2

            #region Question 1 Define Class Duration To include Three Attributes Hours, Minutes and Seconds.

            //I Created the class
            #endregion

            #region Question 2-Override All System. Object Members [To String(), Equals(),GetHashCode() ] .

            Duration duration = new Duration(1,3,10);
            Console.WriteLine(duration.ToString()); //Duration = Hours:1, Minutes:3, Seconds:10
            Console.WriteLine(duration.Equals(5)); //False
            Console.WriteLine(duration.GetHashCode()); //8
            #endregion

            #region Question 3-Define All Required Constructors to Produce this output:
            //Duration D1 = new Duration(1, 10, 15);
            //D1.ToString();
            // Output: Hours: 1, Minutes: 10, Seconds: 15

            //Duration D1 = new Duration(3600);
            //D1.ToString();
            //Output: Hours: 1, Minutes: 0, Seconds: 0

            //Duration D2 = new Duration(7800);
            //D2.ToString();
            //Output: Hours: 2, Minutes: 10, Seconds: 0

            //Duration D3 = new Duration(666);
            //D3.ToString();
            //Output: Minutes: 11, Seconds: 6




            Duration D1;
            //Duration D1 = new Duration(1, 10, 15);
            D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); //Duration = Hours:1, Minutes:10, Seconds:15

            //Duration D1 = new Duration(3600);
            D1 = new Duration(3600);
            Console.WriteLine(D1.ToString());//Duration = Hours:1, Minutes:0, Seconds:0

            //Duration D2 = new Duration(7800);
            Duration D2 = new Duration(7800);
            Console.WriteLine(D2.ToString()); //Duration = Hours:2, Minutes: 10, Seconds: 0


            //Duration D3 = new Duration(666);
            Duration D3 = new Duration(666);
            Console.WriteLine(D3.ToString()); //Duration = Hours:0, Minutes: 11, Seconds:6

            #endregion

            #region  Question 4-Implement All required Operators overloading to enable this Code:
            //D3 = D1 + D2
            //D3 = D1 + 7800
            //D3 = 666 + D3
            //D3 = ++D1(Increase One Minute)
            //D3 = --D2(Decrease One Minute)
            //D1 = D1 - D2
            //If(D1 > D2)
            //If(D1 <= D2)
            //If(D1)
            //DateTime Obj = (DateTime)D1

            //D3 = D1 + D2
            D3 = D1 + D2;
            Console.WriteLine(D3.ToString()); //Duration = Hours:3, Minutes:10, Seconds:0

            //================================================================

            //D3 = D1 + 7800
            D3 = D1 + 7800;
            Console.WriteLine(D3.ToString()); //Duration = Hours:3, Minutes:10, Seconds:0

            //================================================================

            //D3 = 666 + D3;
            D3 = 666 + D3;
            Console.WriteLine(D3.ToString());  //Hours:3, Minutes:21, Seconds:6

            //================================================================

            //D3 = ++D1(Increase One Minute)

            D3 = ++D1; //since its prefix it will increment and then assign so both D1 , D2 Minutes will be incremented by 1
            Console.WriteLine(D1.ToString()); //Duration = Hours:1, Minutes: 1, Seconds: 0
            Console.WriteLine(D3.ToString()); //Duration = Hours:1, Minutes: 1, Seconds: 0

            //================================================================

            //D3 = --D2 (Decrease One Minute)

            D3 = --D2;  //since its prefix it will increment and then assign so both D1 , D2 Minutes will be Decremented by 1
            Console.WriteLine(D2.ToString()); //Duration = Hours:2, Minutes: 9, Seconds: 0
            Console.WriteLine(D3.ToString()); //Duration = Hours:2, Minutes: 9, Seconds: 0

            //================================================================

            D1 = D1 - D2;
            Console.WriteLine(D1.ToString()); //Duration = Hours:0, Minutes:0, Seconds:0


            //================================================================

            //If(D1 > D2)

            if (D1 > D2)
                Console.WriteLine("D1 > D2");
            else if (D1 < D2)
                Console.WriteLine("D1 < D2"); // D1<D2
            else
                Console.WriteLine("D1 Equals D2");


            //================================================================

            //If(D1 <= D2)

            string result = D1 <= D2 ? "D1 is less than or equal to D2" : "D1 is Greater Than D2";
            Console.WriteLine(result); //D1 is less than or equal to D2


            //================================================================

            //if(D1)
            if (D1)
            {
                Console.WriteLine("D1 has a value"); //D1 has a value
            }
            else
            {
                Console.WriteLine("D1 is empty or zero");
            }

            //================================================================

            //DateTime Obj = (DateTime)D1

            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj); // 1/1/0001 1:00:00 AM


            #endregion

            #endregion

        }


    }
}
