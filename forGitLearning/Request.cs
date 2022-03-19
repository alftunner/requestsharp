using System.IO.Compression;
using System.Xml;

namespace forGitLearning;

public class Request
{
    private static int id = 0;
    public int codeOfRequest;
    public Client client;
    public Dictionary<string, int> listOfgoods;
    public int Summ = 0;

    public Request()
    {
        id++;
        this.codeOfRequest = id;
        listOfgoods = new Dictionary<string, int>();
        this.client = new Client();
        Console.Write("Введите Y, если хотите вписать товар в список, если не хотите - N");
        string stopContinue = Console.ReadLine();
        while (stopContinue == "Y")
        {
            Console.Write("Введите название товара: ");
            string name = Console.ReadLine();
            Console.Write("Введите цену товара: ");
            int price = Convert.ToInt32(Console.ReadLine());
            this.listOfgoods.Add(name, price);
            Console.Write("Введите Y, если хотите продолжить вписывать товары в список, если не хотите - N");
            stopContinue = Console.ReadLine();
        }
        this.CalculateSumm();
    }

    private void CalculateSumm()
    {
        foreach (var item in listOfgoods)
        {

            this.Summ += item.Value;
        }
    }

    public void PrintInfoRequest()
    {
        Console.WriteLine("ID заказа" + this.codeOfRequest);
        Console.WriteLine("-------Инфо о клиенте------");
        this.client.PrintClientInfo();
        Console.WriteLine("----------------------");
        foreach (var item in listOfgoods)
        {
            Console.WriteLine($"Название товара: {item.Key}");
            Console.WriteLine($"Цена товара: {item.Value}");
            Console.WriteLine($"--------------------");
        }
        Console.WriteLine($"Сумма - {this.Summ}");
    }
}