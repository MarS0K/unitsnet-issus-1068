using Library;

namespace App
{
    public static class AppQuantityProcessor
    {
        public static double GetTenMetersFromMeterUnit()
            => QuantityProcessor.GetTenMetersFromMeterUnit();

        public static double GetTenMetersAsMeterUnit()
            => QuantityProcessor.GetTenMetersAsMeterUnit();
    }
}