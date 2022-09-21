// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Let's Calc! Choose an operator + - * /");
string oper = Console.ReadLine();
Console.WriteLine("First");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Second");
int b = Convert.ToInt32(Console.ReadLine());
switch (oper)
{
    case "*":
        Console.WriteLine(a*b);
        break;
    case "/":
        Console.WriteLine(a/b);
        break;
    case "+":
        Console.WriteLine(a+b);
        break;
    case "-":
        Console.WriteLine(a-b);
        break;
}
