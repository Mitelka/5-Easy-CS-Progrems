namespace B18_EX01_1
{
	// $G$ RUL-005 (-20) The zip file should contain a single folder. 
    public class Program
    {
        // $G$ DSN-999 (-5) The Main method should only be an access point to the program. Should look something like:
        // public static void Main() { Run(); } 
        // $G$ DSN-004 (-10) Unnecessary code duplication,Use loop instead
        public static void Main()
        {
            string binNumberStr1, binNumberStr2, binNumberStr3;
            int decimalNumber1, decimalNumber2, decimalNumber3;

            System.Console.WriteLine("Please enter 3 binary number in the length of 9 (Press 'enter' at the end of each number");
            binNumberStr1 = getBinaryNumberStr();
            binNumberStr2 = getBinaryNumberStr();
            binNumberStr3 = getBinaryNumberStr();

            decimalNumber1 = convertBinToDec(binNumberStr1);
            decimalNumber2 = convertBinToDec(binNumberStr2);
            decimalNumber3 = convertBinToDec(binNumberStr3);

            printZeroOneStats(binNumberStr1, binNumberStr2, binNumberStr3);
            printConvertedBinayToDecimal(decimalNumber1, decimalNumber2, decimalNumber3);
            printAmountOfPowered2Numbers(decimalNumber1, decimalNumber2, decimalNumber3);
            printAmountOfDecsSeriesNum(decimalNumber1, decimalNumber2, decimalNumber3);
            printAverage(decimalNumber1, decimalNumber2, decimalNumber3);
        }

        private static string getBinaryNumberStr()
        {
            string inputNumberStr;
            inputNumberStr = System.Console.ReadLine();
            while (!isValidBinary(inputNumberStr))
            {
                System.Console.WriteLine("The number you've entered is invalid, please enter another one.");
                inputNumberStr = System.Console.ReadLine();
            }

            return inputNumberStr;
        }

        private static void printZeroOneStats(string i_BinNumberStr1, string i_BinNumberStr2, string i_BinNumberStr3)
        {
            System.Text.StringBuilder strToPrint = new System.Text.StringBuilder("Average number of ones in the 3 given binary numbers is: ");
            double aveOfOnes = aveNumOfGivenDigit(1, i_BinNumberStr1, i_BinNumberStr2, i_BinNumberStr3);
            double aveOfZeros = aveNumOfGivenDigit(0, i_BinNumberStr1, i_BinNumberStr2, i_BinNumberStr3);
            strToPrint.Append(aveOfOnes);
            System.Console.WriteLine(strToPrint);
            strToPrint.Clear();

            strToPrint.Append("Average number of zeros in the 3 given binary numbers is: ");
            strToPrint.Append(aveOfZeros);
            System.Console.WriteLine(strToPrint);
        }

        private static double aveNumOfGivenDigit(int i_Digit, string i_BinNumberStr1, string i_BinNumberStr2, string i_BinNumberStr3)
        {
            int digitAppearCntInNum1 = 0;
            int digitAppearCntInNum2 = 0;
            int digitAppearCntInNum3 = 0;
            double average;

            digitAppearCntInNum1 = countDigitInNum(i_Digit, i_BinNumberStr1);
            digitAppearCntInNum2 = countDigitInNum(i_Digit, i_BinNumberStr2);
            digitAppearCntInNum3 = countDigitInNum(i_Digit, i_BinNumberStr3);

            average = (digitAppearCntInNum1 + digitAppearCntInNum2 + digitAppearCntInNum3) / 3.0;
            return average;
        }

        private static int countDigitInNum(int i_Digit, string i_BinNumberStr)
        {
            int counterOfDigitAppearInNum = 0;
            int digitInStr;
            foreach (char digitChar in i_BinNumberStr)
            {
                digitInStr = digitChar - '0';
                if (digitInStr == i_Digit)
                {
                    counterOfDigitAppearInNum++;
                }
            }

            return counterOfDigitAppearInNum;
        }

        private static bool isValidBinary(string i_numberStr)
        {
            bool isValidBinaryVar = true;
            if (i_numberStr.Length != 9)
            {
                isValidBinaryVar = false;
            }

            foreach (char character in i_numberStr)
            {
                if (character != '0' && character != '1')
                {
                    isValidBinaryVar = false;
                }
            }

            return isValidBinaryVar;
        }

        private static void printConvertedBinayToDecimal(int i_DecimalNumber1, int i_DecimalNumber2, int i_DecimalNumber3)
        {
            System.Text.StringBuilder strToPrint = new System.Text.StringBuilder("The numbers converted to decimal: ");
            strToPrint.Append(i_DecimalNumber1).Append(", ");
            strToPrint.Append(i_DecimalNumber2).Append(", ");
            strToPrint.Append(i_DecimalNumber3);
            System.Console.WriteLine(strToPrint);
        }

        private static int convertBinToDec(string i_BinNumber)
        {
            int indexCnt = i_BinNumber.Length - 1;
            int decNumber = 0;
            for (int i = 0; i < i_BinNumber.Length; i++)
            {
                if (i_BinNumber[i] == '1')
                {
                    decNumber += (int)System.Math.Pow(2, indexCnt);
                }

                indexCnt--;
            }

            return decNumber;
        }

        private static void printAmountOfPowered2Numbers(int i_DecimalNumber1, int i_DecimalNumber2, int i_DecimalNumber3)
        {
            System.Text.StringBuilder strToPrint = new System.Text.StringBuilder("Amount of numbers that are 2 powered: ");
            int numOfNumbers = 0;
            numOfNumbers = is2Powered(i_DecimalNumber1) + is2Powered(i_DecimalNumber2) + is2Powered(i_DecimalNumber3);
            strToPrint.Append(numOfNumbers);
            System.Console.WriteLine(strToPrint);
        }

        private static int is2Powered(int i_Number)
        {
            if ((i_Number != 0) && ((i_Number & (i_Number - 1)) == 0))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private static void printAmountOfDecsSeriesNum(int i_DecimalNumber1, int i_DecimalNumber2, int i_DecimalNumber3)
        {
            System.Text.StringBuilder strToPrint = new System.Text.StringBuilder("Amount of numbers that their digit are descending: ");
            int numOfNumbers;
            numOfNumbers = areDigitsDesc(i_DecimalNumber1) + areDigitsDesc(i_DecimalNumber2) + areDigitsDesc(i_DecimalNumber3);
            strToPrint.Append(numOfNumbers);
            System.Console.WriteLine(strToPrint);
        }

        private static int areDigitsDesc(int i_Number)
        {
            int prevDigit = i_Number % 10;
            i_Number = i_Number / 10;
            int areDigitsDescVar = 1;
            while (i_Number > 0 && areDigitsDescVar != 0)
            {
                if (i_Number % 10 > prevDigit)
                {
                    prevDigit = i_Number % 10;
                    i_Number = i_Number / 10;
                }
                else
                {
                    areDigitsDescVar = 0;
                }
            }

            return areDigitsDescVar;
        }

        private static void printAverage(int i_DecimalNumber1, int i_DecimalNumber2, int i_DecimalNumber3)
        {
            System.Text.StringBuilder strToPrint = new System.Text.StringBuilder("The average of the input numbers is: ");
            int[] decimalNumbersArray = { i_DecimalNumber1, i_DecimalNumber2, i_DecimalNumber3 };
            strToPrint.Append(string.Format("{0:0.00}", calcAverage(decimalNumbersArray)));
            System.Console.WriteLine(strToPrint);
        }

        private static float calcAverage(int[] i_DecimalNumbers)
        {
            int sum = 0;
            for (int i = 0; i < i_DecimalNumbers.Length; i++)
            {
                sum += i_DecimalNumbers[i];
            }

            return sum / (float)i_DecimalNumbers.Length;
        }
    }
}
