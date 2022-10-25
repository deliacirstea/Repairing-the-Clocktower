
Console.Title = " Repairing the Clocktower";
Console.WriteLine("Help us fixing the clock in the Consola town by choosing a number:");


string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if (number == 7)
    Console.WriteLine("Tick");
if (number != 7)
    Console.WriteLine("Tock");
