namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 numOfVND = 0;
            Int32 numOfUSD = 0;
            UInt16 exchange_rate_usd_to_vnd = 23000;

            bool isSuccess;

        askNumOfUSD:
            Console.Write("Enter Amount Of USD: ");
            isSuccess = Int32.TryParse(Console.ReadLine(), out numOfUSD);
            if (!isSuccess || numOfUSD < 0)
            {
                Console.WriteLine("Amount Of USD cannot be Negative OR Characters");
                goto askNumOfUSD;
            }

            numOfVND = numOfUSD * exchange_rate_usd_to_vnd;
            Console.WriteLine($"Amount Of VND we get: {numOfVND}");
        }
    }
}