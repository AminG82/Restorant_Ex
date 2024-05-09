
//Example;
//20 people enter a restorant and order some food
//every one of them give a number as resault so the owner
//can find out if his food is good or not;
//the number should be from 1 to 5;



void Inputs(params int[] scors)
{
    int one = 0;
    int two = 0;
    int three = 0;
    int four = 0;
    int five = 0;

    foreach (int c in scors)
    {
        switch (c)
        {
            case 1:
                one++;
                break;
            case 2:
                two++;
                break;
            case 3:
                three++;
                break;
            case 4:
                four++;
                break;
            case 5:
                five++;
                break;
            default:
                Console.WriteLine($"Invalid Score from person number {c}");
                break;
        }

    }
    Console.WriteLine($"Most scores are {CalculateInputs(one, two, three, four, five)}");

}
int CalculateInputs(int one, int two, int three, int four, int five)
{
    int max = one;
    if (two > max)
    {
        max = two;
    }
    if (three > max)
    {
        max = three;
    }
    if (four > max)
    {
        max = four;
    }
    if (five > max)
    {
        max = five;
    }
    return max;
}

Inputs(5, 3, 4, 5, 1, 2, 3, 5, 5, 5, 7, 3);




