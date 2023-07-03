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
            // Task5();
            // Homework1();
            // Homework2();
            // Homework3();
            // Homework4();
            //CatTask();
            //StudentTask();
            BracketsTask();
        }

        /// <summary>
        ///Enter two integers numbers and check if they can represent the day and month. 
        ///Output result on the console.
        /// </summary>
        public static void Task1()
        {
            if (!Helpers.PromptWithValidationInt("Enter month number: ", "Can't parse month number", out int month))
            {
                return;
            }

            const int january = 1;
            const int december = 12;

            if (month < january || month > december)
            {
                Console.WriteLine("You have entered invalid month number");
                return;
            }

            if (!Helpers.PromptWithValidationInt("Enter day number: ", "Can't parse day number", out int day))
            {
                return;
            }

            var daysAmount = DateTime.DaysInMonth(DateTime.Now.Year, month);

            if (day < 1 || day > daysAmount)
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
            var inputNum = Helpers.Prompt("Enter double number: ");

            var parsedNum = double.TryParse(inputNum, out double num);

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
            if (!Helpers.PromptWithValidationInt("Enter hour of the day in 24h format: ", "Can't parse hour of the day", out int hour))
            {
                return;
            }

            const int startDay = 0;
            const int endDay = 23;
            if (hour < startDay || hour > endDay)
            {
                Console.WriteLine("You entered invalid hour");
                return;
            }

            string message;
            const int morning = 5;
            const int afternoon = 12;
            const int evening = 17;
            const int night = 21;
            if (hour >= morning & hour < afternoon)
            {
                message = "Good morning!";
            }
            else if (hour >= afternoon & hour < evening)
            {
                message = "Good afternoon!";
            }
            else if (hour >= evening & hour < night)
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
            var white = new RGB
            {
                R = 0xFF,
                G = 255,
                B = 255
            };

            RGB black = new RGB();
        }

        /// <summary>
        /// Read 3 float numbers and check if they are all in the range [-5;5].
        /// </summary>
        public static void Homework1()
        {
            float a = -20f;
            float b = 0f;
            float c = 4f;

            const float lowerBoundary = -5f;
            const float upperBoundary = 5f;

            if (a >= lowerBoundary && a <= upperBoundary
                && b >= lowerBoundary && b <= upperBoundary
                && c >= lowerBoundary && c <= upperBoundary)
            {
                Console.WriteLine("All 3 values are in range [-5;5]");
            }
            else
            {
                Console.WriteLine("One or more values are not in range [-5;5]");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Read 3 integer numbers and output max and min of them.
        /// </summary>
        public static void THomework2()
        {
            int a = -20;
            int b = 0;
            int c = 4;

            var minAB = a < b ? a : b;
            var min = minAB < c ? minAB : c;

            var maxAB = a > b ? a : b;
            var max = maxAB > c ? maxAB : c;

            Console.WriteLine($"Min value is: {min}; Max value is: {max}");

            Console.ReadLine();
        }

        /// <summary>
        /// Read number of HTTP Error (400, 401,402, ...) and write the name of this error 
        ///(Declare enum HTTPError)
        /// </summary>
        public static void Homework3()
        {
            int code = 403; // forbidden
            HttpError enumCode = (HttpError)code;
            Console.WriteLine($"Name of error code is: {enumCode}");

            Console.ReadLine();

        }

        /// <summary>
        /// Declare struct Dog with fields name, mark, age. 
        ///Declare object myDog of Dog type and read values for it.
        ///Output information on the console. (Override method ToString in struct)
        /// </summary>
        public static void Homework4()
        {
            var myDog = new Dog
            {
                Name = "Zuzik",
                Mark = "Street Fighter",
                Age = 15
            };

            Console.WriteLine(myDog);

            Console.ReadLine();
        }


        /// <summary>
        /// Create class Cat. The cat should have a property "fullness level" and method "eat something".
        /// Create enum Food (fish, mouse, ...). Each type of food should change the level of satiety differently.
        /// </summary>
        public static void CatTask()
        {
            var cat = new Cat();

            Console.WriteLine($"The fullness level of a cat is {cat.FullnessLevel}");

            cat.EatSomething(Food.Mouse);

            Console.WriteLine($"The fullness level of a cat is {cat.FullnessLevel}");

            cat.EatSomething(Food.Meat);

            Console.WriteLine($"The fullness level of a cat is {cat.FullnessLevel}");

            Console.ReadLine();
        }


        /// <summary>
        /// Create struct Student with fields last name and group number.
        /// Create array of students and output student names of a given group that begin with a given letter.
        /// The last name and group number are entered from the console.
        /// </summary>
        public static void StudentTask()
        {
            Student[] students = new Student[5]
            {
                new Student() { GroupNumber = 3, LastName = "Yatsiuk" },
                new Student() { GroupNumber = 2, LastName = "Yaroslav" },
                new Student() { GroupNumber = 3, LastName = "Yuzyk" },
                new Student() { GroupNumber = 2, LastName = "Dobrynin" },
                new Student() { GroupNumber = 3, LastName = "Tishchenko" }
            };

            var searchResult = students.Where(student => student.GroupNumber == 3 && student.LastName.StartsWith("Y"));

            foreach (var student in searchResult)
            {
                Console.WriteLine($"Student group: {student.GroupNumber}; Student last name: {student.LastName}");
            }
        }


        public static void BracketsTask()
        {
            //string brackets = "((()))";
            //string brackets = "(((())";
            string brackets = "()()";

            bool isBalanced = true;
            var stack = new Stack<char>();
            foreach (char bracket in brackets)
            {
                if (bracket == '(')
                {
                    stack.Push(bracket);
                }
                else // close bracket
                {
                    if (stack.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    stack.Pop();
                }
            }

            if (stack.Count != 0) isBalanced = false;

            Console.WriteLine($"Brackets expression is balanced: {isBalanced}");
        }
    }
}