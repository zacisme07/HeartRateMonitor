using System;

namespace HeartRateMonitor
{
    class HeartRateMonitor
    {
        static void Main(string[] args)
        {
            //Heart Rate Monitor App
            //Author Zachery Emerson

            string fName;
            string lName;
            int birthYear;
            int currYear;

            //Intorduction 
            Console.WriteLine("Want to know more about your heart?");
            Console.WriteLine("We just need to gather some information first...");
            
            //Gather information
            Console.Write("First, Please enter your first name: ");
            fName = Console.ReadLine();
            Console.Write("Next, Please tell me your last name: ");
            lName = Console.ReadLine();
            Console.Write("And what year were you born in: ");
            birthYear = int.Parse(Console.ReadLine());
            Console.Write("Finally, What year is it currently: ");
            currYear = int.Parse(Console.ReadLine());

            HeartRates heartrate1 = new HeartRates(fName, lName, birthYear, currYear);

            Console.WriteLine($"Your name is {heartrate1.FName} {heartrate1.LName} and you were born in {heartrate1.BirthYear}");
            Console.WriteLine($"Your age is {heartrate1.Age(heartrate1.BirthYear, heartrate1.CurrentYear)}");
            Console.WriteLine($"Your Maximum Heart Rate is {heartrate1.MaxHeartRate()}");
            Console.WriteLine($"Your target heart range is {heartrate1.MinTarget()} - {heartrate1.MaxTarget()}");
        }
    }
}
