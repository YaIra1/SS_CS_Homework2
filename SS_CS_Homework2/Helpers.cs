using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS_CS_Homework2
{
    public static class Helpers
    {
        public static string Prompt(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static bool ParseAndValidateInt(string input, string errorMessage, out int value)
        {
            var wasParsed = int.TryParse(input, out value);

            if (!wasParsed)
            {
                Console.WriteLine(errorMessage);
            }

            return wasParsed;
        }

        public static bool PromptWithValidationInt(string message, string errorMessage, out int value)
        {
            var input = Prompt(message);

            return ParseAndValidateInt(input, errorMessage, out value);
        }
    }
}
