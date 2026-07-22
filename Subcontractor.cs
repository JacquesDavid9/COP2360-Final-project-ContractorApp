// Member 3 will replace this with the real implementation including proper base(...) constructor chaining and the payroll method.
 
using System;
 
namespace ContractorApp
{
    public class Subcontractor : Contractor
    {
        public int Shift { get; set; }             // 1 = Day, 2 = Night
        public double HourlyPayRate { get; set; }
 
        public Subcontractor() : base() { }
 
        public Subcontractor(string name, string number, string startDate, int shift, double payRate)
            : base(name, number, startDate)
        {
            Shift = shift;
            HourlyPayRate = payRate;
        }
 
        // Placeholder payroll method - Member 3 will implement the real 3% night shift differential logic here.
        public float CalculatePay(double hoursWorked)
        {
            double pay = hoursWorked * HourlyPayRate;
            if (Shift == 2)
                pay *= 1.03;
 
            return (float)pay;
        }
    }
}
