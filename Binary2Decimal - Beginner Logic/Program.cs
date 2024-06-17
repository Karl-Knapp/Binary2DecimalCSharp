namespace Binary2Decimal;

class Program
{
    static void Main(string[] args)
    {
        const int BYTE_LENGTH = 8;

        Console.WriteLine("Enter a binary number up to 8 in length:");

        bool isValidInput = false;
        int[] intArray = [];

        while (!isValidInput)
        {
            string inputString = Console.ReadLine();
            if (inputString.Length > BYTE_LENGTH || inputString.Length <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a binary number up to 8 digits long.");
                continue;
            }

            try
            {
                intArray = Array.ConvertAll(inputString.ToCharArray(), c => int.Parse(c.ToString()));
                if (!intArray.All(x => x == 0 || x == 1))
                {
                    Console.WriteLine("Input invalid. All digits should be 0 or 1.");
                    continue;
                }

                isValidInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Only numbers 0 and 1 are allowed.");
            }
        }

        int binaryNumber = 0; //Doing 'binaryNumber = Convert.ToInt32(inputString, 2);' does the exact same thing as the code below but it does now show the underlying logic of how to convert from binary to decimal.
        Array.Reverse(intArray);

        for (int i = 0; i < intArray.Length; i++)
        {
            if (intArray[i] == 1)
            {
                binaryNumber += (int)Math.Pow(2, i);
            }
        }
        Console.WriteLine($"Converted Decimal: {binaryNumber}");
    }
}
