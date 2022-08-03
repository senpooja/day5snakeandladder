Console.WriteLine("Welcome to snake ladder game");
int Count = 0;
int position = 0;
while (position < 100)
{
    Random Dice = new Random();
    int dice = Dice.Next(1, 7);
    int game = Dice.Next(0, 3);
    int game1 = Dice.Next(0, 3);
    //no play condition
    if (game == 0)
    {
        Count++;
    }
    //Snake condition
    else if (game == 1)
    {
        position -= dice;
        if (position < 0)
        {
            position = 0;
        }
        else if (position > 101)
        {
            position -= dice;
        }
        Count++;
    }
    //ladder condition
    else if (game == 2)
    {
        switch (dice)
        {
            case 1:
                position += 1;
                break;
            case 2:
                position += 2;
                break;
            case 3:
                position += 3;
                break;
            case 4:
                position += 4;
                break;
            case 5:
                position += 5;
                break;
            default:
                position += 6;
                break;
        }
        if (position > 100)
        {
            position -= dice;
        }
        Count++;
    }
    //saving all the counts in array
    int[] chance = { Count };

}
Console.WriteLine($"It takes {Count} times to reach {position} i.e., END point in Snake Ladder Game");






