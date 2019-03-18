namespace exercise_inheritance
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }
        public Role Role { get; set; }

        public string PrintInfo()
        {
            return $"The dude's first name is {FirstName}, last name is {LastName} and the salary is {Salary}";
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
