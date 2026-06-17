// i will practice making an exercise to ask someone to login in a system and i will put some conditions let's say i need to check if the user is +18 years old so i can tell that he can drive a car

// in c what is scanf is ConsoleReadLine()) in c# 

Console.WriteLine("Fill the blanks if you want to drive a car");
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();

Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18) 
{
    Console.WriteLine("Hello" + " " + "you can drive a car !! ");
}
else
{
    Console.WriteLine("Hello" + " " + "you are under 18 yers old you cant drive :(((  ");
}

//in c# if else and while loops etc and c programming are very similar


// i can just use this its better way to write 
consoleWriteLine("Enter your name:");
string name2 = ConsoleReadLine();
consoleWriteLine("Enter your age:");
int age2 = ConsoleReadLine();

Console.WriteLine($"Hello {name2} you are {age2} years old and you can {age >= 18 ? "drive a car" : " you cant drive a car"}")
