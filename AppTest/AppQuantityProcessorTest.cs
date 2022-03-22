using App;
using Xunit;

namespace AppTest
{
    public class AppQuantityProcessorTest
    {
        private const double TenMeters = 10;

        [Fact]
        public void GetTenMetersAsMeterUnit_ShouldReturnTenMeters()
        {
            Assert.Equal(TenMeters, AppQuantityProcessor.GetTenMetersAsMeterUnit());
        }

        [Fact]
        public void GetTenMetersFromMeterUnit_ShouldReturnTenMeters()
        {
            Assert.Equal(TenMeters, AppQuantityProcessor.GetTenMetersFromMeterUnit());
        }
    }
}