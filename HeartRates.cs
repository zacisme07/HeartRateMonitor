using System;
using System.Collections.Generic;
using System.Text;

namespace HeartRateMonitor
{
    class HeartRates
    {
        public string FName { get; set; }
        
        public string LName { get; set; }
        
        public int BirthYear { get; set; }

        public int CurrentYear { get; set; }

        public HeartRates(string fName, string lName, int birthYear, int currYear)
        {
            FName = fName;
            LName = lName;
            BirthYear = birthYear;
            CurrentYear = currYear;
        }

        public int Age(int birthYear, int currYear)
        {
            int age = currYear - birthYear;
            
            return age;
        }

        public int MaxHeartRate()
        {
            int maxHeartRate = 220 - Age(BirthYear, CurrentYear);

            return maxHeartRate;
        }

        public double MinTarget()
        {
            double minTarget = MaxHeartRate() * 0.5;

            return minTarget;
        }

        public double MaxTarget()
        {
            double maxTarget = MaxHeartRate() * 0.85;

            return maxTarget;
        }
    }
}
