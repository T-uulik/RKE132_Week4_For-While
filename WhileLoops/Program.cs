
using System.ComponentModel.Design;

Random rng = new Random();
int cpuRandom;

bool loopActive = true;

while (loopActive)
{
    cpuRandom = rng.Next(1, 4);
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());
    //int userCheat = 99;
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratz, you won!");
        loopActive = false;
    }
    /*else if (userCheat == userNumber)
    {
        Console.WriteLine($"cpu has generated {cpuRandom}"); proovisin cheat code sisse kirjutada, kuid ei närinud läbi, et kuidas sama loopi hoida peale cheat code kasutamist.
        Console.WriteLine("Cheater >:("); 
    }*/
    else
    {
        Console.WriteLine("Oops. Try again.");
    }
   

}
Console.WriteLine("Bye Bye!");



