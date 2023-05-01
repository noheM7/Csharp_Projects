using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LAMBDA
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>()
            {

                new Employee{ FirstName="Jack", LastName="A", Id=1},
                new Employee{ FirstName="Drake", LastName="B", Id=2},
                new Employee{ FirstName="Jason", LastName="C", Id=3},
                new Employee{ FirstName="Chris", LastName="D", Id=4},
                new Employee{ FirstName="Lebron", LastName="E", Id=5},
                new Employee{ FirstName="Tom", LastName="F", Id=6},
                new Employee{ FirstName="Tiger", LastName="G", Id=7},
                new Employee{ FirstName="Mark", LastName="H", Id=8},
                new Employee{ FirstName="joe", LastName="I", Id=9},
                new Employee{ FirstName="joe", LastName="J", Id=10}


                };



            List<Employee> joeemployees = new List<Employee>(); 
            foreach (Employee samenames in Employees) 
            {
                if (samenames.FirstName == "Joe") 
                {
                    joeemployees.Add(samenames); 
                }
            }
            List<Employee> samenamelist = Employees.Where(x => x.FirstName == "Joe").ToList();




            List<Employee> Lambdaof5 = new List<Employee>();
            foreach (Employee IDover5 in Employees) 
            {
                if (IDover5.Id > 5) 
                {
                    Lambdaof5.Add(IDover5); 
                }
            }
            List<Employee> Lambdaof5s = Employees.Where(x => x.Id > 5).ToList(); 
        }
    }
}