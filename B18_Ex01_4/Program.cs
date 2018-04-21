namespace B18_Ex01_4
{
    // $G$ SFN-015 (-5) The program does not identify whether the string is a palindrome. when it is a number input
    public class Program
    {
        // $G$ DSN-999 (-1) The Main method should only be an access point to the program. Should look something like:
        // public static void Main() { Run(); } 
        public static void Main()
        {
            string inputStr;
            int inputNum;
            inputStr = getInputFromUser();
            if (!isInputANumber(inputStr))
            {
                printIfPalindrom(inputStr);
                printAmountOfLowerCase(inputStr);
            }
            else
            {
                inputNum = int.Parse(inputStr);
                printIfEven(inputNum);
            }
        }

        private static string getInputFromUser()
        {
            string inputStr;
            System.Console.WriteLine("Please enter a string or a number:");
            inputStr = System.Console.ReadLine();
            while (!isValidInput(inputStr))
            {
                System.Console.WriteLine("Your input is invalid! Please enter another one:");
                inputStr = System.Console.ReadLine();
            }

            return inputStr;
        }

        private static void printIfPalindrom(string i_InputStr)
        {
            if (isPalindrom(i_InputStr))
            {
                System.Console.WriteLine("The string you've entered is a Palindrom!");
            }
            else
            {
                System.Console.WriteLine("The string you've entered isn't a Palindrom!");
            }
        }

        private static void printAmountOfLowerCase(string i_InputStr)
        {
            System.Text.StringBuilder strToPrint = new System.Text.StringBuilder("Amount of lower case letters is: ");
            strToPrint.Append(countLowerCase(i_InputStr));
            System.Console.WriteLine(strToPrint);
        }

        private static void printIfEven(int i_InputStr)
        {
            if (i_InputStr % 2 == 0)
            {
                System.Console.WriteLine("The number is even.");
            }
            else
            {
                System.Console.WriteLine("The number is odd.");
            }
        }

        private static bool isInputANumber(string i_InputStr)
        {
            int number;
            bool isNumber = int.TryParse(i_InputStr, out number);

            return isNumber;
        }

        // check if only number or only letters
        private static bool isValidInput(string i_InputStr) 
        {
            bool isFirstCharNumber = char.IsDigit(i_InputStr[0]);
            bool isValidInputVar = true;

            if (isFirstCharNumber)
            {
                foreach (char c in i_InputStr)
                {
                    if (!char.IsDigit(c))
                    {
                        isValidInputVar = false;
                    }
                }
            }
            else
            {
                foreach (char c in i_InputStr)
                {
                    if (!char.IsLetter(c))
                    {
                        isValidInputVar = false;
                    }
                }
            }

            return isValidInputVar;
        }

        private static int countLowerCase(string i_InputStr)
        {
            int lowerCaseCnt = 0;
            foreach (char inputChar in i_InputStr)
            {
                if (char.IsLower(inputChar))
                {
                    lowerCaseCnt++;
                }
            }

            return lowerCaseCnt;
        }

        private static bool isPalindrom(string i_InputStr)
        {
            bool isPal = true;
            for (int i = 0; i < i_InputStr.Length / 2 && isPal; i++)
            {
                if (i_InputStr[i] != i_InputStr[i_InputStr.Length - i - 1])
                {
                    isPal = false;
                }
            }

            return isPal;
        }
    }
}
