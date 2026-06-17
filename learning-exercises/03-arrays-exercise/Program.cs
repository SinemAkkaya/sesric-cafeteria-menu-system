//now I will do an exercise i will write the products in a market in an array anddefine their prices then when the user gives me a product name they will see how much it costs 

string[] products = { "apple", "banana", "orange", "milk", "bread" };
double[] prices = { 1.99, 2.99, 3.999, 4.99, 5.99 };

Console.WriteLine("enter the name of the product pls:");
string productName = Console.ReadLine();

bool found = false; // first i said product couldnt found i define it with bool (because user didnt input anything yet)
for (int i = 0 ; i < products.Length; i++)
{
    if (products[i]==productName)
    {
       Console.WriteLine($"the price of {productName} is{prices[i]}");
       found = true; 
    }
}
 
 if(!found) // if user write something out of my array i will show a message
{
    Console.WriteLine("we dont have this product");
}