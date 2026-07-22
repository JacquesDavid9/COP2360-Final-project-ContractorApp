// Member 2 will replace this with the real implementation. Base class holding contractor name, number, and start date.
 
using System;
 
namespace ContractorApp
{
    public class Contractor
    {
        public string ContractorName { get; set; }
        public string ContractorNumber { get; set; }
        public string ContractorStartDate { get; set; }
 
        public Contractor() { }
 
        public Contractor(string name, string number, string startDate)
        {
            ContractorName = name;
            ContractorNumber = number;
            ContractorStartDate = startDate;
        }
    }
}
