namespace exercise_inheritance
{
    class SalesPerson : Employee
    {
        public double SuccessSaleRevenue { get; set; }
        public SalesPerson()
        {
            Salary = 500;
            Role = Role.Sales;
        }

        public void AddSuccessRevenue(double value)
        {
            SuccessSaleRevenue = value;
        }

        public override double GetSalary()
        {
            double bonusSalary = Salary;
            if (SuccessSaleRevenue <= 2000)
            {
                bonusSalary += 500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                bonusSalary += 1000;
            }
            else
            {
                bonusSalary += 1500;
            }
            return bonusSalary;
        }
    }
}
