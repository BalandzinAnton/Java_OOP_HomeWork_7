class Person
{


static void Main(string[] args)
    {
        	
    Employee tom = new Employee("Tom", 22, "Microsoft");
    Driver sergey = new Driver("Sergey", 28, "Audi");
    string tomS = tom.ToString();
    string sergeyS = sergey.ToString();
    Console.WriteLine(tomS);
    Console.WriteLine(sergeyS);

    }



    public string name;
    public int age;
 
    public Person(string name)
    {
        this.name = name;
    }
    public Person(string name, int age) : this(name)
    {
        this.age = age;
    }
    
}

class Employee : Person
{
    string company;
 
    public Employee(string name, int age, string company) : base(name, age)
    {
        this.company = company;
    }
    public override string ToString()
    {
        return "Name: " + this.name +  " age: " + this.age + " company: " + company;
    }
}

class Driver : Person
{
    string car;
 
    public Driver(string name, int age, string car) : base(name, age)
    {
        this.car = car;
    }
    public override string ToString()
    {
        return "Name: " + this.name +  " age: " + this.age + " car: " + car;
    }
}




