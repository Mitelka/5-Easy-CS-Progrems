namespace B18_Ex01_3
{
    public class Program
    {
        public static void Main()
        {
            getInputFromUser();
        }

        private static void getInputFromUser()
        {
            System.Console.WriteLine("Hi! please Enter The bar of the sand clock - Number only");
            string barOfStars = System.Console.ReadLine();
            validationInput(barOfStars);
        }

        // $G$ CSS-013 (-2) Bad variable name (should be in the form of i_PascalCase).
        private static void validationInput(string i_input)
        {
            int numBarOfStars;
            if (int.TryParse(i_input, out numBarOfStars))
            {
                buildSandClock(numBarOfStars);
            }
            else
            {
                System.Console.WriteLine("Invalid number");
                getInputFromUser();
            }
        }

        private static void buildSandClock(int i_numBarOfStars)
        {
            if ((i_numBarOfStars % 2) == 0) 
            {
                B18_Ex01_2.Program.PrintSandClock(i_numBarOfStars + 1); // In case of even input --> add 1
            }
            else
            {
                B18_Ex01_2.Program.PrintSandClock(i_numBarOfStars); // using method from previos task
            }
        }
    }
}