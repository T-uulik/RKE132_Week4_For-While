Console.WriteLine("Enter a number");
int userNumber = Int32.Parse(Console.ReadLine());
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i + 1} * {userNumber} = {(i + 1) * userNumber}");
}