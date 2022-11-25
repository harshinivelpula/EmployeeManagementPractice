namespace EmployeeManagementt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeSalary EmployeeSalary = new EmployeeSalary();
            EmployeeSalary.EmployeeAttendance();
            Console.ReadKey();
        }
    }
}