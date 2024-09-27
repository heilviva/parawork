namespace parawork
{
    public class InvestmentCalculator
    {
        public static double CalculateCompoundInterest(double principal, double rate, double time, int frequency)
        {
            if (principal < 0)
                throw new ArgumentOutOfRangeException(nameof(principal), "Начальная сумма должна быть неотрицательным числом.");
            if (rate < 0)
                throw new ArgumentOutOfRangeException(nameof(rate), "Процентная ставка должна быть неотрицательным числом.");
            if (time < 0)
                throw new ArgumentOutOfRangeException(nameof(time), "Время в годах должно быть неотрицательным числом.");
            if (frequency <= 0)
                throw new ArgumentOutOfRangeException(nameof(frequency), "Количество начислений процентов в год должно быть положительным целым числом.");

            double amount = principal * Math.Pow((1 + rate / frequency), frequency * time);
            return amount - principal;
        }

        static void Main(string[] args)
        {
            double principal = 1000;
            double rate = 0.05;
            double time = 10;
            int frequency = 4; 

            double interest = CalculateCompoundInterest(principal, rate, time, frequency);
            Console.WriteLine($"Сложный процент: {interest}");
        }
    }
}
