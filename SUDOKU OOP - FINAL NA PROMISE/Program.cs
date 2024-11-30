namespace SUDOKU_OOP___FINAL_NA_PROMISE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! ");




         /*   int choice; // Declare the variable to hold the number of Sudoku grids

            // Input validation loop
            while (true)
            {
                Console.Write("Enter the number of Sudoku grids to generate: ");
                string input = Console.ReadLine(); // Read user input

                // Try to parse the input
                if (int.TryParse(input, out choice) && choice > 0)
                {
                    break; // Exit the loop if input is valid
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive integer."); // Error message
                }
            }
         */



            Console.Write("Enter the number of Sudoku grids to generate: ");
            int choice = int.Parse(Console.ReadLine());

            // Grid sudoku = new Grid();
         
            int totalattempts = 0;

            for (int i = 0; i < choice; i++)
            {
              
                Grid sudoku = new Grid();

                Console.WriteLine($"\nGenerating Sudoku grid {i + 1}...");

                int attempts = 0;
                bool success = false;

                while (!success)
                {
                    attempts++;
                    sudoku.Initialize();
                    success = sudoku.GenerateGrid(sudoku);
                  
                }
                totalattempts += attempts;
                

                Console.WriteLine($"Sudoku Grid {i + 1} (Attempts: {attempts}):");
                sudoku.DisplayGrid(sudoku);
            }

            int average = totalattempts/ choice;
            Console.WriteLine("the total average attempt to  "+ average);







            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
