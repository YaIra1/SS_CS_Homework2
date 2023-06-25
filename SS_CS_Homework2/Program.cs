using System;

namespace SS_CS_Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            // Task3();
            // Task4();
            Task5();
        }


        /// <summary>
        ///Enter two integers numbers and check if they can represent the day and month. 
        ///Output result on the console.
        /// </summary>
        public static void Task1()
        {
            int month, day;

            Console.Write("Enter month num: ");
            var inputMonth = Console.ReadLine();

            var parsedMonth = int.TryParse(inputMonth, out month);

            if (!parsedMonth)
            {
                Console.WriteLine("Can't parse month number");
                return;
            }

            if (month < 1 || month > 12)
            {
                Console.WriteLine("You have entered invalid month number");
                return;
            }

            Console.Write("Enter day num: ");
            var inputDay = Console.ReadLine();

            var parsedDay = int.TryParse(inputDay, out day);

            if (!parsedDay)
            {
                Console.WriteLine("Can't parse day number");
                return;
            }

            var daysCount = DateTime.DaysInMonth(2023, month);

            if (day < 1 || day > daysCount)
            {
                Console.WriteLine("You have entered invalid day number for chosen month");
                return;

            }
            Console.WriteLine("Successfully entered date");

            Console.ReadLine();
        }

        /// <summary>
        /// Enter double number and get the first 2 digits after the point of this number 
        /// and output the sum of these numbers. For example: 3.456 -> 4+5=9
        /// </summary>
        public static void Task2()
        {
            double num;
            Console.Write("Enter double number: ");
            var inputNum = Console.ReadLine();

            var parsedNum = double.TryParse(inputNum, out num);

            if (!parsedNum)
            {
                Console.WriteLine("Can't parse double number");
                return;
            }
            var truncated = Math.Truncate(num);
            var fraction = num - truncated;
            num = fraction * 10;
            var firstDigit = Math.Truncate(num);
            fraction = num - firstDigit;
            num = fraction * 10;
            var secondDigit = Math.Truncate(num);
            Console.WriteLine("The sum of first two digits of fractions is: {0}", firstDigit + secondDigit);

            Console.ReadLine();
        }

        /// <summary>
        /// Enter integer number  h, representing the time of day (hour). 
        /// Depending on the time of day, output greetings("Good morning!", "Good afternoon!", "Good evening!“ or "Good night!")
        /// </summary>
        public static void Task3()
        {
            int hour;

            Console.Write("Enter hour of the day in 24h format: ");
            var inputHour = Console.ReadLine();

            var parsedHour = int.TryParse(inputHour, out hour);

            if (!parsedHour)
            {
                Console.WriteLine("Can't parse hour of the day");
                return;
            }
            if (hour < 0 || hour > 23)
            {
                Console.WriteLine("You entered invalid hour");
                return;
            }
            string message;
            if (hour >= 5 & hour < 12)
            {
                message = "Good morning!";
            }
            else if (hour >= 12 & hour < 17)
            {
                message = "Good afternoon!";
            }
            else if (hour >= 17 & hour < 21)
            {
                message = "Good evening!";
            }
            else
            {
                message = "Good night!";
            }
            Console.WriteLine(message);

            Console.ReadLine();

        }

        /// <summary>
        /// Identify enum TestCaseStatus {Pass, Fail, Blocked, WP, Unexecuted}.  
        ///Assign status “Pass” for variable test1Status and output result on the console.
        /// </summary>
        public static void Task4() 
        {
            var test1Status = TestCaseStatus.Pass;
            Console.WriteLine(test1Status);

            Console.ReadLine();
        }

        /// <summary>
        /// Determine struct RGB that represents the color with fields red, green, blue (type byte).
        /// Identify two variables of this type and enter their fields for white and black colors.
        /// </summary>
        public static void Task5()
        {
            var white = new RGB();
            RGB black = new RGB();
            white.R = 0xFF;
            white.G = 255;
            white.B = 255;
        }
    }
}