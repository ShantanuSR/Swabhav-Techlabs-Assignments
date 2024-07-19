using System;
public class Overloading 
{
	public static void Main(String[] args)
	{
		int result1 = Sum(5,8);
		Console.WriteLine("Sum : " + result1);

		double result2 = Sum(5.7,8);
		Console.WriteLine("Sum : " + result2);

		int result3 = Sum(5,8,9);
		Console.WriteLine("Sum : " + result3);
	}

	public static int Sum(int a,int b)
	{
		return a+b;
	}

	public static double Sum(double a,double b)
	{
		return a+b;
	}

	public static int Sum(int a,int b,int c)
	{
		return a+b+c;
	}
	

}