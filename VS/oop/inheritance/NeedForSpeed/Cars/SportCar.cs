namespace NeedForSpeed.Cars
{
    public class SportCar : Car
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 10;
        public SportCar(int horsepower, double fuel)
            : base(horsepower, fuel)
        {
        }

        public override double FuelConsumption => DEFAULT_FUEL_CONSUMPTION;
    }
}
