//i miss my math lectures so i will make a calculator for trigonometri
// i will use the methods math.sin, math.cos, math.tan but they take the angle in radians so i will convert the angle from degrees to radians by multiplying it with pi/180 

Console.WriteLine("enter the name of trigonometric function (options: sin, cos, tan, cot):");
string trigonometri = Console.ReadLine();
Console.WriteLine("enter the angle in degree :");
double angledegree=double.Parse(Console.ReadLine()); // i cant say console writeline again because this is not string

//now i took the degree and funtion name

double angleradian = angledegree * Math.PI / 180; //i translate the angle from degrees to radians

double sin(double result)
{
    return Math.Sin(result);
}
double cos(double result)
{
    return Math.Cos(result);
}
double tan(double result)
{
    return Math.Tan(result);
}
double cot(double result)
{
    return 1 / Math.Tan(result);  // math.cot does not exist but its ok
}
// if else or switch case will work but its not that complivcated so im gonna use switch case

switch (trigonometri)
{
    case "sin":
        Console.WriteLine($"the sin of {angledegree} is {sin(angleradian)}");
        break;
    case "cos":
        Console.WriteLine($"the cos of {angledegree} is {cos(angleradian)}");
        break;
    case "tan":
        Console.WriteLine($"the tan of {angledegree} is {tan(angleradian)}");
        break;
    case "cot":
        Console.WriteLine($"the cot of {angledegree} is {cot(angleradian)}");
        break;
    default:
        Console.WriteLine("invalid function name");
        break;
}

