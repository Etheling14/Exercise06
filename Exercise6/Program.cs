Console.BackgroundColor = ConsoleColor.Cyan;
Console.Clear();

int numberDesk;
decimal paymentValue;
int numberPillows;

do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"=============================");
    try
    {
        numberDesk = RequestInt($"Enter the number of desks or ctrl+c to the end..: ");
        numberPillows = RequestInt($"Enter the number of pillows or ctrl+c to the end: ");
        paymentValue = CalculateValue(numberDesk, numberPillows);
        ShowResults(paymentValue);
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
    }
} while (true);


static void ShowResults(decimal paymentValue)
{
    Console.WriteLine($"The value to pay is= {paymentValue:C2}");
    Console.WriteLine("Press enter to calculate another bill or Ctrl + C to finish");
    Console.ReadKey();
}


 static int RequestInt(string message)
{
    Console.Write(message);
    var inputString = Console.ReadLine();
    try
    {
        return Convert.ToInt32(inputString);
    }
    catch (Exception)
    {
        throw new Exception("You must enter a valid integer number.");
    }
}

static decimal CalculateValue( int numberDesk, int numberPillows)
{
    decimal valueDesk = numberDesk * 650000;
    if (numberDesk < 5)  return valueDesk * 0.9M;
    if (numberDesk < 10) return valueDesk * 0.8M;
    valueDesk = valueDesk * 0.6M;

    decimal valuePillows = numberPillows * 35000;
    if (numberPillows < 5) return valuePillows * 0.9M;
    if (numberPillows < 10) return valuePillows * 0.8M;
    valuePillows = valuePillows * 0.6M;

    return valueDesk + valuePillows;
}