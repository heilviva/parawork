
using parawork;


namespace TestProject1
{
    [TestClass]
    public class InvestmentCalculatorTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCalculateCompoundInterest_NegativePrincipal()
        {
            InvestmentCalculator.CalculateCompoundInterest(-1000, 0.05, 10, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCalculateCompoundInterest_NegativeRate()
        {
            InvestmentCalculator.CalculateCompoundInterest(1000, -0.05, 10, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCalculateCompoundInterest_NegativeTime()
        {
            InvestmentCalculator.CalculateCompoundInterest(1000, 0.05, -10, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCalculateCompoundInterest_NegativeFrequency()
        {
            InvestmentCalculator.CalculateCompoundInterest(1000, 0.05, 10, 0);
        }
    }
}