using System;

class Factorial
{
	public static void Main(String [] args)
	{
		int i, myNumber, fact=1;

		Console.WriteLine("Enter the value of the number: ");

		myNumber = Convert.ToInt32(Console.ReadLine());

		for(i=1; i<=myNumber; i++)
		{
			fact=fact*i;
		}
		Console.WriteLine("Factorial of the given number is: " +fact);
	}
}