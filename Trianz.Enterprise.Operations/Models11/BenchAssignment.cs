using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trianz.Enterprise.Operations.Controllers;

namespace Trianz.Enterprise.Operations.Models
{
    public class BenchAssignment
    {

        public List<EmployeeDetailsPractiseWise> BenchEmployees { get; set; }

        public List<EmployeeDetailsPractiseWiseAssignment> AssignmentEmployees { get; set; }

        public List<Employeedetails> Getemployeedetails {get; set;}
        

    }
}