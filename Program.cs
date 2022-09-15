using IEnumerableQueryable;

internal class Program
{
    private static void Main(string[] args)
    {
        var context = new EmployeeContext("Data Source=PT219LT\\MSSQL;Initial Catalog=IEQ;Integrated Security=True");
        //IQueryable<Employee> employees = context.Employees
        //    .Where(e => e.Id >= 1);
        //var topEmployees = employees.Take(2);
        //foreach (var employee in topEmployees)
        //{
        //    Console.WriteLine($"Name-{employee.FirstName} {employee.LastName}");
        //}
        IEnumerable<Employee> employees = context.Employees
            .Where(e => e.Id >= 1).ToList<Employee>();
        var topemployees = employees.Take(2);
        foreach (var employee in topemployees)
        {
            Console.WriteLine($"Name-{employee.FirstName} LastName-{employee.LastName} Address-{employee.Address}");
        }
    }
}