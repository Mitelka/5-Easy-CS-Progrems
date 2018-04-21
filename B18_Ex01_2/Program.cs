namespace B18_Ex01_2
{
    public class Program
    {
        public static void Main()
        {
            int barNumOfStars = 5;
            PrintSandClock(barNumOfStars);
        }

        // $G$ CSS-013 (-5) Bad variable name (should be in the form of i_PascalCase).
        public static void PrintSandClock(int i_barNumOfStars)
        {
            System.Text.StringBuilder starStrings = new System.Text.StringBuilder();
            for (int i = i_barNumOfStars; i_barNumOfStars - i < i; i--)
            {
                starStrings.AppendLine(new string(' ', i_barNumOfStars - i) + new string('*', (2 * i) - i_barNumOfStars));
            }

            for (int i = 0; i < i_barNumOfStars / 2; i++)
            {
                starStrings.AppendLine(new string(' ', (i_barNumOfStars / 2) - 1 - i) + new string('*', (2 * i) + 3));
            }

            System.Console.WriteLine(starStrings.ToString());
        }
    }
}
