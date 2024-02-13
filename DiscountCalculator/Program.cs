//total < 10 - 1%
//total  >= 10 && total < 20 - 5%
//total >=20 - 10%

Console.WriteLine("Provide total:");
int userinput = Int32.Parse(Console.ReadLine());
double discount = CalculateDiscount(userinput);

Console.WriteLine($"Your discount is {discount} percent!");

double newTotal = CalculatedNewTotal(userinput, discount);
Console.WriteLine($"Your updated total with {discount}% discount is {newTotal}.");
static double CalculateDiscount(int total)
{
    if (total < 10)
    {
        return 1;
    }
    else if (total >=10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculatedNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
}