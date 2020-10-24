using System;

namespace Lab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss("Сергей");
            Employee employee = new Employee("Иван");
            Employee employee2 = new Employee("Василий");
            Company company = new Company("Амкор", boss);

            Console.WriteLine(boss);
            Console.WriteLine(company);
            Console.WriteLine(employee);

            boss.HireWorker(employee);
            boss.HireWorker(employee2);
            if (company.IsWorkerInCompany(employee))
            {
                Console.WriteLine("IsWorkerInCompany: Сотрудник работает в компании");
            }
            Console.WriteLine(company);

            boss.FireWorker(employee2);
            if (company.SearchWorkerByName("Василий") != null)
            {
                Console.WriteLine("SearchWorkerByName: Сотрудник в компании");
            }
            Console.WriteLine(company);

            if (company.SearchWorkerByName("Сергей") != null)
            {
                Console.WriteLine("SearchWorkerByName: Сотрудник в компании");
            }
        }
    }
}
