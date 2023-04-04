Random rng  = new Random();

int myRandomNum;

int randomSum = 0;

for(int i = 0; i < 3; i++)
{
    myRandomNum = rng.Next(0, 11);
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is :{myRandomNum}");
}

Console.WriteLine($"Random Num Sum total: {randomSum}");

