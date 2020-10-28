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
}