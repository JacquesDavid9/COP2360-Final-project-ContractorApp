using System;


namespace ContractorApp
{
    public class Contractor
    {
        // Constractor Accessors & Mutators
        public string ContractorName { get; set; }
        public int ContractorNumber { get; set; }
        public DateOnly ContractorStartDate { get; set; }

        //Contractor Constructors
        public Contractor()
        {
            ContractorName = "";
            ContractorNumber = 0;
            ContractorStartDate = DateOnly.FromDateTime(DateTime.Now);
        }

        public Contractor(string name, int number, DateOnly startDate)
        {
            ContractorName = name;
            ContractorNumber = number;
            ContractorStartDate = startDate;
        }
    }

}
