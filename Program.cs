//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

internal class Program
{
	private static void Main(string[] args)
	{
		Console.Write($" Enter a five-digit number->  ");
		string? number = Console.ReadLine();

		void CheckingNumber(string number)
		{

			if (number[0] == number[4] || number[1] == number[3])
			{
				Console.WriteLine(@" It is a palindrome->  " + number);
			}
			else
				Console.WriteLine(@" It is not a palindrome->  " + number);

		}
		if (number!.Length == 5)
		{
			CheckingNumber(number);
		}
		else
			Console.WriteLine(@" Not the correct number ");
	}
}



		
		
	


