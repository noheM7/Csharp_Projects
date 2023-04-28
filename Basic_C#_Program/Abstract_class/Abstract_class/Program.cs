using System;

namespace Abstract_class
{
    class Program
    {
        static  void Main(string[] args)
        {
            Employee name = new Employee();
            name.firstName = "Sample";
            name.lastName = " Student";
            Employee employee = new Employee() { firstName = "Sample", lastName = " Student" };
            name.SayName();
        
        IQuittable quittable = new Employee();
            
                quittable.Quit(employee);
            }
           
    }
}

