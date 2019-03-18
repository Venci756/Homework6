namespace exercise_inheritance
{
    class Manager : Employee
    {
        public double Bonus { get; set; }

        public Manager()
        {
            FirstName = "Wekoslav";
            LastName = "Stefanovski";
            Salary = 9000;
            Role = Role.Manager;
        }

        public void AddBonus(double value)
        {
            Bonus = value;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
