namespace opam_lab7
{ 
    class Program
    {
        static void Main()
        {
            Func<double, double> discountCalculator = null;

            discountCalculator += price => price * 0.95;
            discountCalculator += price => price * 0.90;
            discountCalculator += price => price - 100;

            double price = discountCalculator(1000);
           
            Console.WriteLine(price);
        }
    }
}