using System;

namespace Entityframework.demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EmployeeContext("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TimeManagement;Data Source=.");
            var provider = new EmployeeProvider(context);
            var employee = provider.Get(1);
            Console.WriteLine($"Welcome { employee.FirstName} { employee.LastName}");

            var repo = new EmployeeRepo(context);
            repo.Create("First", "Last","Address","12345","67589");

        }
    }
}
