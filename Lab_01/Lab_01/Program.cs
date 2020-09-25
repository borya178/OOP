using System;

namespace Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Иван");
            Person person1 = new Person("Василий");
            Company company = new Company("Амкор");
            Company company1 = new Company("Амкор1");
            Company company2 = new Company("Амкор2");
            Company company3 = new Company("Амкор3");
            Company company4 = new Company("Амкор4");
            Company company5 = new Company("Амкор5");
            person1.EnterCompany(company);
            company.HireWorker(person);
            company1.HireWorker(person);
            company2.HireWorker(person);
            company3.HireWorker(person);
            company4.HireWorker(person);
            Console.WriteLine($"{person.countOfCompanies}");
            Console.WriteLine(person);
            Console.WriteLine(company);
            if (company5.HireWorker(person))
            {
                Console.WriteLine("Сотрудник нанят");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            if (company.SearchWorkerByName("Василий") != null)
            {
                Console.WriteLine("SearchWorkerByName: Сотрудник в компании");
            }
            if (company.IsWorkerInCompany(person))
            {
                Console.WriteLine("IsWorkerInCompany: Сотрудник работает в компании");
            }
            if (company.SearchWorkerByName("Олег") != null)
            {
                Console.WriteLine("SearchWorkerByName: Сотрудник в компании");
            }
            else
            {
                Console.WriteLine("SearchWorkerByName: Сотрудника нет в компании");
            }
            if (company.FireWorker(person))
            {
                Console.WriteLine("FireWorker: Сотрудник уволен");
            }
        }
    }
}