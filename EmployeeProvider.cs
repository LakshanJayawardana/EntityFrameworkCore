using System.Linq;
namespace Entityframework.demo
{
    internal class EmployeeProvider : IEmployeeProvider
    {
        private readonly EmployeeContext EmployeeContext;

        public EmployeeProvider(EmployeeContext employeeContext)
        {
            this.EmployeeContext = employeeContext;
        }
        public Employee Get(int id)
        {
            return EmployeeContext.Employees.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
