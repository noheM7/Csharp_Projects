using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Operators_submission
{
    public class Employee 
    {
        public string Id
        { get; set; }

        public string FirstName
        { get; set; }

        public string LastName
        { get; set; }






        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.Id == employee2.Id) ;


                return true;
            



        }




        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee.Id != employee2.Id;
        }

       
        

    }

    
}


       
