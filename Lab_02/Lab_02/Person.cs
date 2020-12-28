namespace Lab_02
{
    abstract class Person
    {
        public string Name { private set; get; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Имя человека: {Name}";
        }
    }

    class Employee : Person
    {
        public int CountOfCompanies { set; get; }
        public Employee(string name)
            : base(name)
        {
            CountOfCompanies = 0;
        }
        public override string ToString()
        {
            return $"Сотрудник по имени {Name} устроен в {CountOfCompanies} компаний";
        }
    }
    class Boss : Employee
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