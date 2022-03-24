/*using forGitLearning;

Request request = new Request();
request.PrintInfoRequest();*/

void Change(out int i, ref int[] arr)
{
    i = 20;
    Console.WriteLine("Значения до переопределения:");
    Console.WriteLine("i = " + i + " arr[0] = " + arr[0]);

    
    arr[0] = 20;
    
    Console.WriteLine("Значения после переопределения:");
    Console.WriteLine("i = " + i + " arr[0] = " + arr[0]);
}

int i ;
int[] arr = {10, 20, 30};
Console.WriteLine("Начальное состояние:");
Console.WriteLine("i = " + i + " arr[0] = " + arr[0]);

Change(out i, ref arr);

Console.WriteLine("FINAL:");
Console.WriteLine("i = " + i + " arr[0] = " + arr[0]);