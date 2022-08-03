Console.WriteLine("Welcome to snake ladder game");

int Count = 0;
int Start = 0;
while (Start < 100)
{
    Random Dice = new Random();
    int dice = Dice.Next(1, 7);
    int game = Dice.Next(0, 3);
    //no play condition
    if (game == 0)
    {
        Count++;
    }
    //Snake condition
    else if (game == 1)
    {
        Start -= dice;
        if (Start < 0)
        {
            Start = 0;
        }
        else if (Start > 101)
        {
            Start -= dice;
        }
        Count++;
    }
    //ladder condition
    else if (game == 2)
    {
        Start += dice;

        if (Start > 100)
        {
            Start -= dice;
        }
        Count += 2;
    }
    //saving all the counts in array
    int[] chance = { Count };

}
Console.WriteLine($"It takes {Count} times for Player 1 to reach {Start} i.e., END point in Snake Ladder Game");
int Count2 = 0;
int Start2 = 0;
while (Start2 < 100)
{
    Random Dice2 = new Random();
    int dice2 = Dice2.Next(1, 7);
    int game2 = Dice2.Next(0, 3);
    //no play condition
    if (game2 == 0)
    {
        Count2++;
    }
    //Snake condition
    else if (game2 == 1)
    {
        Start2 -= dice2;
        if (Start2 < 0)
        {
            Start2 = 0;
        }
        Count2++;
    }
    //ladder condition
    else if (game2 == 2)
    {
        Start2 += dice2;

        if (Start2 > 100)
        {
            Start2 -= dice2;
        }
        Count2 += 2;
    }
    //saving all the counts in array
    int[] chance = { Count2 };

}
Console.WriteLine($"It takes {Count2} times for Player 2 to reach {Start2} i.e., END point in Snake Ladder Game");

if (Count2 < Count)
{
    Console.WriteLine("Congratulations Player 2 has Won the Match....");
}
else if (Count < Count2)
{
    Console.WriteLine("Congratulations Player 1 has Won the Match...");
}
else
{
    Console.WriteLine("Match Drawn");
}