using UnitsNet;
using UnitsNet.Units;

namespace Library
{
    public static class QuantityProcessor
    {
        private const double TenMeters = 10;
        private const LengthUnit MeterUnit = LengthUnit.Meter;

        public static double GetTenMetersFromMeterUnit()
            => Length.From(TenMeters, MeterUnit).Meters;

        public static double GetTenMetersAsMeterUnit()
            => Length.FromMeters(TenMeters).As(MeterUnit);
    }
}