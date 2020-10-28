using System.Collections.Generic;

namespace Lab_02
{
    class Company
    {
        public string CompanyName { private set; get; }
        private List<Employee> Workers;

        public Company(string companyName, Boss boss)
        {
            CompanyName = companyName;
            boss.MyCompany = this;
            Workers = new List<Employee>();
            Workers.Add(boss);
        }

        public Employee SearchWorkerByName(string name)
        {
            foreach (var i in Workers)
            {
                if (i.Name.Equals(name))
                {
                    return i;
                }
            }
            return null;
        }

        public bool IsWorkerInCompany(Employee employee)
        {
            return Workers.Contains(employee);
        }

        public override string ToString()
        {
            return $"В этой компании работает {this.Workers.Count} сотрудников";
        }

        public class Boss : Employee
        {
            public Company MyCompany { set; get; }
            public Boss(string name)
                : base(name)
            { }

            public bool HireWorker(Employee employee)
            {
                if (employee.CountOfCompanies >= 5 || MyCompany.Workers.Contains(employee))
                {
                    return false;
                }
                MyCompany.Workers.Add(employee);
                employee.CountOfCompanies++;
                return true;
            }

            public bool FireWorker(Employee employee)
            {
                if (!MyCompany.Workers.Remove(employee))
                {
                    return false;
                }
                employee.CountOfCompanies--;
                return true;
            }
            public override string ToString()
            {
                return $"Босс компании {MyCompany.CompanyName}";
            }
        }
    }
}