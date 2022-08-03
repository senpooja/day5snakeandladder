Console.WriteLine("Welcome to snake ladder game");

{
    Random Dice = new Random();
    int dice = Dice.Next(1, 7);

    //no play condition
    if (dice == 5)
    {
        Console.WriteLine("player on ledder");

    }
    else if (dice == 4)
    {
        Console.WriteLine("payer on snake");

    }
    else
    {
        Console.WriteLine("no plays");
    }
}