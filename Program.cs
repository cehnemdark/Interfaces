using Interfaces;

// SqlManager sınıfından bir örnek oluşturuluyor
SqlManager sqlManager = new SqlManager();

// MySqlServerManager sınıfından bir örnek SqlManager'a ekleniyor
sqlManager.Add(new MySqlServerManager
{

});

// ISqlServer arayüzünden üç örnek oluşturuluyor
ISqlServer[] sqlServer = new ISqlServer[3]
{
    new MySqlServerManager(),
    new MySqlServerManager(),
    new SqlOracleManager(),
};

// Her bir sqlServer örneği için Add yöntemi çağrılıyor
foreach (ISqlServer server in sqlServer)
{
    Console.WriteLine(server.Add);
}

// IEats arayüzünden üç örnek oluşturuluyor
IEats[] eats = new IEats[3]
{
    new Manager(),
    new Ceo(),
    new Stajyer()
};

// Her bir eats örneği için Eat yöntemi çağrılıyor
foreach (IEats eat in eats)
{
    eat.Eat();
}

// ISalary arayüzünden iki örnek oluşturuluyor
ISalary[] salaries = new ISalary[2]
{
    new Manager(),
    new Ceo(),
};

// Her bir salaries örneği için GetSalary yöntemi çağrılıyor
foreach (var item in salaries)
{
    item.GetSalary();
}

// IWorker arayüzünden dört örnek oluşturuluyor
IWorker[] workers = new IWorker[4]
{
     new Manager(),
    new Ceo(),
    new Stajyer(),
    new Robot(),
};

// Her bir workers örneği için Work yöntemi çağrılıyor
foreach (var worker in workers)
{
    worker.Work();
}

//// PersonManager sınıfından bir örnek oluşturuluyor
//PersonManager personManager = new PersonManager();

//// Customer sınıfından bir örnek oluşturuluyor
//var customer = new Customer
//{
//    FirstName = "Serhat",
//    Address = "Gültepe"
//};

//// PersonManager'a customer örneği ekleniyor
//personManager.Add(customer);

//// PersonManager sınıfından bir örnek daha oluşturuluyor
//PersonManager personManager2 = new PersonManager();

//// Student sınıfından bir örnek oluşturuluyor
//var student = new Student
//{
//    FirstName = "Abdullah",
//    No = 2004
//};

//// PersonManager'a student örneği ekleniyor
//personManager.Add(student);

//// IPerson arayüzü tanımlanıyor
//public interface IPerson
//{
//    public int Id { get; set; }
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//}

//// Customer sınıfı, IPerson arayüzünü uygulayan bir sınıf olarak tanımlanıyor
//public class Customer : IPerson
//{
//    public string Address { get; set; }
//    public int Id { get; set; }
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//}

//// Student sınıfı, IPerson arayüzünü uygulayan bir sınıf olarak tanımlanıyor
//public class Student : IPerson
//{
//    public string LastName { get; set; }
//    public int Id { get; set; }
//    public string FirstName { get; set; }
//    public int No { get; set; }
//}

//// PersonManager sınıfı, IPerson arayüzünü uygulayan nesneleri yönetmek için bir yönetici sınıfıdır.
//public class PersonManager
//{

//    // Add yöntemi, IPerson arayüzünü uygulayan nesneleri parametre olarak alır ve bu nesnelerin FirstName özelliğini yazdırır.
//    public void Add(IPerson person)
//    {
//        Console.WriteLine(person.FirstName);
//    }
//}
