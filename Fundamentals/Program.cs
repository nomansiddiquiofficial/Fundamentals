using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
namespace Fundamentals
{

    class Program
    {
        //static void Main(string[] args)
        //{
        //    //  ternary operator
        //    //ex:1
        //    int speed = 100;
        //    string status = (speed > 80) ? "Above limit" : "Within limit";
        //    //Console.WriteLine(status);

        //    //ex:2
        //    string time = (DateTime.Now.Hour < 12) ? "Morning" : "Afternoon";
        //    //Console.WriteLine(time);

        //    //ex:3
        //    const double pi = 3.14;
        //    int number = int.Parse(Console.ReadLine());
        //    string result = (number > pi) ? "number is greater" : "number is lesser";
        //    // Console.WriteLine(result);


        // Delegates 

        //static void Main(string[] args)
        //{
        //    Calculation obj = new Calculation(CustomMath.Addition);
        //    obj.Invoke(6, 9); // or obj(6, 9)
        //obj = CustomMath.Divide;    
        //obj.Invoke(10, 2);
        //}


        static void Main(string[] args)
        {
            Properties properties = new Properties();
           // properties.Name = "noman";
            //Console.WriteLine(properties.Name);
            PreDefinedProperties preDefinedProperties = new PreDefinedProperties("NomanS", 3);
           // preDefinedProperties.SetEmpName("NOman");
            Console.WriteLine(preDefinedProperties.EmpName);
            Console.WriteLine(preDefinedProperties.EmpId);
        
            Console.WriteLine(preDefinedProperties.EmpExists);



        }


    }


}