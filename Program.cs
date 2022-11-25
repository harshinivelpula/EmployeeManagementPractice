namespace EmployeeManagementt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Employee Wage Computation Program");
            //EmployeeSalary EmployeeSalary = new EmployeeSalary();
            //EmployeeSalary.EmployeeAttendance();
            //Console.ReadKey();
            //DailyEmployeeWage dailyEmployeeWage = new DailyEmployeeWage();
            //DailyEmployeeWage.DailyWage();
            //Console.ReadKey();
            //Case Case = new Case();
            //Case.CaseStatement();
            //Console.ReadKey();
            //WageForMonth wageForMonth = new WageForMonth();
            //WageForMonth.MonthlyWage();
            //Console.ReadKey();
            //Condition condition = new Condition();
            //Condition.WageTill();
            //Console.ReadKey();
            //Refactor.ComputeEmpWage();
            //Console.ReadKey();
            //MultipleCompany.computeEmpWage();
            //Console.ReadKey();
            save dMart = new save("DMart", 20, 2, 10);
            save reliance = new save("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());

        }
    }
}