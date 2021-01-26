namespace exercise_polymorphism_csharp.Entities
{
    class OutsoucedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsoucedEmployee()
        {
        }

        public OutsoucedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;

        }
    }
}
