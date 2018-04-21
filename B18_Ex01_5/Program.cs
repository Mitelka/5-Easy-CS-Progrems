namespace B18_Ex01_5
{
    public class Program
    {
        // $G$ DSN-999 (0) The Main method should only be an access point to the program. Should look something like:
        // public static void Main() { Run(); } 
        public static void Main()
        {
            int number;
            number = getNumberFromUser();
            printLargestDigit(number);
            printSmallestDigit(number);
            printAmountOfEvenDigits(number);
            printAmountOfLowerThanFirstDigit(number);
        }

        private static int getNumberFromUser()
        {
            int number;
            bool isStrParsedToInt = false;
            System.Console.WriteLine("Please enter a possitive 6 digits integer:");
            isStrParsedToInt = int.TryParse(System.Console.ReadLine(), out number);

            while (!isStrParsedToInt || !isValidNumber(number))
            {
                System.Console.WriteLine("You've entered an invalid number, please enter a valid one!");
                isStrParsedToInt = int.TryParse(System.Console.ReadLine(), out number);
            }

            return number;
        }

        private static bool isValidNumber(int i_Number)
        {
            bool isValidNumberVar = true;
            if (i_Number <= 0)
            {
                isValidNumberVar = false;
            }

            if (i_Number.ToString().Length != 6)
            {
                isValidNumberVar = false;
            }

            return isValidNumberVar;
        }

        private static void printLargestDigit(int i_Number)
        {
            System.Text.StringBuilder strToPrint = new System.Text.StringBuilder("The largest digit is: ");
            strToPrint.Append(getLargestDigit(i_Number));
            System.Console.WriteLine(strToPrint);
        }

        private static void printSmallestDigit(int i_Number)
        {
            System.Text.StringBuilder strToPrint = new System.Text.StringBuilder("The smallest digit is: ");
            strToPrint.Append(getSmallestDigit(i_Number));
            System.Console.WriteLine(strToPrint);
        }

        private static void printAmountOfEvenDigits(int i_Number)
        {
            System.Text.StringBuilder strToPrint = new System.Text.StringBuilder("Amount of even digits: ");
            strToPrint.Append(getAmountOfEven(i_Number));
            System.Console.WriteLine(strToPrint);
        }

        private static void printAmountOfLowerThanFirstDigit(int i_Number)
        {
            System.Text.StringBuilder strToPrint = new System.Text.StringBuilder("Amount of lower than ");
            strToPrint.Append(i_Number % 10).Append(" is: ");
            strToPrint.Append(getAmountOfLowerDigits(i_Number, i_Number % 10));
            System.Console.WriteLine(strToPrint);
        }

        private static int getLargestDigit(int i_Number)
        {
            int maxDigit = i_Number % 10;
            i_Number = i_Number / 10;
            while (i_Number > 0)
            {
                if (i_Number % 10 > maxDigit)
                {
                    maxDigit = i_Number % 10;
                }

                i_Number = i_Number / 10;
            }

            return maxDigit;
        }

        private static int getSmallestDigit(int i_Number)
        {
            int minDigit = i_Number % 10;
            i_Number = i_Number / 10;
            while (i_Number > 0)
            {
                if (i_Number % 10 < minDigit)
                {
                    minDigit = i_Number % 10;
                }

                i_Number = i_Number / 10;
            }

            return minDigit;
        }

        private static int getAmountOfEven(int i_Number)
        {
            int numOfEven = 0;
            while (i_Number > 0)
            {
                if (i_Number % 2 == 0)
                {
                    numOfEven++;
                }

                i_Number = i_Number / 10;
            }

            return numOfEven;
        }

        private static int getAmountOfLowerDigits(int i_Number, int i_Digit)
        {
            int amountOfLowerThanDigit = 0;
            while (i_Number > 0)
            {
                if (i_Number % 10 < i_Digit)
                {
                    amountOfLowerThanDigit++;
                }

                i_Number = i_Number / 10;
            }

            return amountOfLowerThanDigit;
        }
    }
}
