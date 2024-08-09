using ProxyDesignPattern.Model;

class Program
{
    public static void Main(string[] args)
    {
        Employee employee1 = new Employee("Jayant", "123456", "CEO");
        Employee employee2 = new Employee("Shreyash", "123456", "Developer");
        Employee employee3 = new Employee("Aditya", "123456", "Client");

        Console.WriteLine("CEO Accessing");
        SharedProxy folderProxy = new SharedProxy(employee1);
        folderProxy.ReadWriteOperation();
        Console.WriteLine();


        Console.WriteLine("Developer Accessing");
        SharedProxy folderProxy2 = new SharedProxy(employee2);
        folderProxy2.ReadWriteOperation();
        Console.WriteLine();


        Console.WriteLine("Client Accessing");
        SharedProxy folderProxy3 = new SharedProxy(employee3);
        folderProxy3.ReadWriteOperation();
    }
}