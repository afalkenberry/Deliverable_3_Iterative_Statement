// See https://aka.ms/new-console-template for more information
using System.Transactions;

Console.WriteLine("Enter an integer value between 0 and 100");


Console.WriteLine("Choose even or odd");



int x = int.Parse(Console.ReadLine());

string[] oddEven = new string[] { "odd", "even" };
string input = Console.ReadLine();
Console.Clear();

Console.WriteLine("You have selected the " + input + " series. The " + input + " numbers between 0 and " + x +" are:");
try
{
	for (int i = 0; i <= x; i++)
	{
		int even = i * 2;
		int odd = even + 1;

		if (input == oddEven[0])
		{
			if (odd > x)
			{
				break;
			}
			else
			{
				Console.WriteLine(odd.ToString() + " is an odd number");
			}
		}

		if (input == oddEven[1])
		{
			if (even > x)
			{
				break;
			}

			else
			{
				Console.WriteLine(even.ToString() + " is an even number");
			}
		}

		
	}
}

catch
{
	Console.WriteLine("Enter a valid integer");
}


