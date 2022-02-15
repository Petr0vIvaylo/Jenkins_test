using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;
        
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }
            return true;
        }
        
        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void IsPrime_InputIs1_ReturnFalse(int value)
        {
            bool result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be prime");
        }
    }
}
