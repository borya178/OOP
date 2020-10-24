using System.Collections.Generic;

namespace Lab_02
{
    class Company
    {
        public string CompanyName { private set; get; }
        public List<Employee> Workers;

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
            return $"В этой компании работает {Workers.Count} сотрудников";
        }
    }
}