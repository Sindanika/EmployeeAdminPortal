using System.ComponentModel.DataAnnotations;

namespace EmployeeAdminPortal.Models
{
    public class UpdateEmployeeDto
    {
       
            public string Name { get; set; }

            [EmailAddress]
            public string Email { get; set; }

            public string Phone { get; set; }

            public string Salary { get; set; }
        

    }
}
