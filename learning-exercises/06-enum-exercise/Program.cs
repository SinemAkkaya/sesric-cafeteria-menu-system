using static System.Console;
WriteLine($"enter the first number for calculator");
int num1 = Convert.ToInt32(ReadLine());
WriteLine($"enter the second number for calculator");
int num2 = Convert.ToInt32(ReadLine());

WriteLine($"Sum:{Calculate(num1, num2, Operation.Sum)}");
WriteLine($"Divide:{Calculate(num1, num2, Operation.Divide)}");
WriteLine($"Multiply:{Calculate(num1, num2, Operation.Multiply)}");
WriteLine($"Substract:{Calculate(num1, num2, Operation.Substract)}");




ReadKey();
int Calculate(int num1,int num2, Operation op ) => op switch
{
 Operation.Sum => num1+num2,
 Operation.Substract => num1-num2,
 Operation.Multiply => num1*num2,
 Operation.Divide => num1 / num2,
    _ => 0 // switch expression is like if else in if else 
};

enum Operation{ 
Sum, Multiply, Divide, Substract
}