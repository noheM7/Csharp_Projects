using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection.Metadata;

namespace StudentDatabases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                // Create and save a new Blog
                Console.Write("Enter Students name: ");
                var name = Console.ReadLine();

                var blog = new Student { Name = name };
                db.Students.Add(blog);
                db.SaveChanges();
                var query = from b in db.Students
                            orderby b.Name
                            select b;

                Console.WriteLine("All students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        } 
        public class Student
        {
            public int StudentId { get; set; }
            public string Name { get; set;}
        }
        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
        }
    }
}