Console.BackgroundColor = ConsoleColor.Magenta;
Console.Clear();

int numberDesk;
decimal paymentValue;

do
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"=============================");
    Console.ForegroundColor = ConsoleColor.Black;
    RequestData(out numberDesk);
    paymentValue = CalculateValue(numberDesk);
    ShowResults(paymentValue);
} while (true);


static void ShowResults(decimal paymentValue)
{
    Console.WriteLine($"The value to pay is= {paymentValue:C2}");
    Console.WriteLine("Press enter to calculate another salary or Ctrl + C to finish.");
    Console.ReadKey();
}


 static void RequestData(out int numberDesk)
{
    Console.WriteLine($"Enter the number of desks or ctrl+c to the end");
    numberDesk = Convert.ToInt32(Console.ReadLine());
}


static decimal CalculateValue( int numberDesk)
{
    decimal value = numberDesk * 650000;
    if (numberDesk < 5)  return value * 0.9M;
    if (numberDesk < 10) return value * 0.8M;
    return value * 0.6M;
}