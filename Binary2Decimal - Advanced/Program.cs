namespace Binary2Decimal;

class Program
{
    static void Main(string[] args)
    {
        const int BYTE_LENGTH = 8;

        Console.WriteLine("Enter a binary number up to 8 in length:");

        bool isValidInput = false;

        while (true)
        {
            string inputString = Console.ReadLine();

            if ((inputString.Length > BYTE_LENGTH) || (inputString.Length <= 0))
            {
                Console.WriteLine("Invalid input. Please enter a binary number up to 8 digits long.");
                continue;
            }

            bool charactersValid = true;
            foreach (char c in inputString)
            {
                if (c != '0' && c != '1')
                {
                    Console.WriteLine("Input invalid. All digits should be 0 or 1.");
                    charactersValid = false;
                    break;
                }
            }

            if (!charactersValid)
            {
                continue;
            }

            int binaryNumber = Convert.ToInt32(inputString, 2);
            Console.WriteLine($"Converted Decimal: {binaryNumber}");

            // Exit the loop once valid input is processed
            break;
        }
    }
}
