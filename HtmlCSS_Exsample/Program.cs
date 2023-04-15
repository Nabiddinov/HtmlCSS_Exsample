namespace HtmlCSS_Exsample
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Enter a number between 1 and 10:");

            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 10)
            {
                Console.Clear();
                Console.WriteLine("Invalid number. Please try again.");
                goto start; // transfer control back to the start label
            }
            else
            {
                Console.WriteLine("You entered: " + number);
            }
        }
    }
}