using System;

namespace Trianz.Enterprise.Operations.Models
{
    [Serializable]
    public class Employees
    {

        public int EmployeeId { get; set; }
        public string PrimarySkills { get; set; }
        public string SecondarySkills { get; set; }
    }
}