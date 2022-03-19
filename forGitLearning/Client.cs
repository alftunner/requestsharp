namespace forGitLearning;

public class Client
{
    private static int test = 22;
    public int id;
    public string name;

    public Client()
    {
        Console.Write("Введите id клиента: ");
        this.id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Введите имя клиента: ");
        this.name = Console.ReadLine();
    }

    public void PrintClientInfo()
    {
        Console.WriteLine("ID клиента - " + id);
        Console.WriteLine("Имя клиента - " + name);
    }
}