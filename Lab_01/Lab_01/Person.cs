namespace Lab_01
{
    class Person
    {
        public string name {private set; get; }
        public int countOfCompanies { set; get; }

        public Person(string name)
        {
            this.name = name;
            this.countOfCompanies = 0;
        }

        public bool EnterCompany(Company company)
        {
            return company.HireWorker(this);
        }

        public bool ExitCompany(Company company)
        {
            return company.FireWorker(this);
        }

        public override string ToString()
        {
            return $"Сотрудник по имени {this.name} устроен в {this.countOfCompanies} компаний";
        }
    }
}
//Описать классы Company и Person, описывающие отношение найма между компанией и работником.Работник может принимать решение о найме в компанию.Компания также может принимать решения о найме и увольнении работника.В одной компании может работать произвольное число работников, один работник может работать не более чем в 5 компаниях одновременно.
//Реализовать методы:
//для получения работника компании по ФИО;
//для проверки, устроен ли работник в компанию;
//для вывода обоих классов в ostream.
//Для демонстрации создать несколько компаний и заполнить их работниками. Вывести компании в ostream. Продемонстрировать работу всех публичных методов классов (кроме геттеров и сеттеров).
