// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.WriteLine(DateTimeOffset.Now.ToLocalTime().ToString());
    Thread.Sleep(1000);
}
