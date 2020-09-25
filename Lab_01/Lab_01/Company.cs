using System.Collections.Generic;

namespace Lab_01
{
    class Company
    {
        private string companyName { set; get; }
        private List<Person> workers;

        public Company(string companyName)
        {
            this.companyName = companyName;
            this.workers = new List<Person>();
        }

        public bool HireWorker(Person person)
        {
            if (person.countOfCompanies >= 5 || workers.Contains(person))
            {
                return false;
            }
            workers.Add(person);
            person.countOfCompanies++;
            return true;
        }

        public bool FireWorker(Person person)
        {
            if (person.countOfCompanies == 0 || !workers.Contains(person))
            {
                return false;
            }
            workers.Remove(person);
            person.countOfCompanies--;
            return true;
        }

        public Person SearchWorkerByName(string name)
        {
            foreach (var i in workers)
            {
               if (i.name.Contains(name))
                {
                    return i;
                }
            }
            return null;
        }

        public bool IsWorkerInCompany(Person person)
        {
            return workers.Contains(person);
        }
        
        public override string ToString()
        {
            return $"В этой компании работает {this.workers.Count} сотрудников";
        }
    }
}

//Описать классы Company и Person, описывающие отношение найма между компанией и работником.Работник может принимать решение о найме в компанию.
//Компания также может принимать решения о найме и увольнении работника.В одной компании может работать произвольное число работников, один работник может работать не более чем в 5 компаниях одновременно.
//Реализовать методы:
//для получения работника компании по ФИО;
//для проверки, устроен ли работник в компанию;
//для вывода обоих классов в ostream.
//Для демонстрации создать несколько компаний и заполнить их работниками. Вывести компании в ostream. Продемонстрировать работу всех публичных методов классов (кроме геттеров и сеттеров).