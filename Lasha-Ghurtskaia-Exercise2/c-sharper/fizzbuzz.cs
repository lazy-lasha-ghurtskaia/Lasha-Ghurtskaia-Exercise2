using System;
using System.Collections.Generic;

public class GFG {

	static bool isPrime(int num){
			List<int> primes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
	
			foreach (int i in primes){
				if (num == i)
					return true;
			}
			return false;
	}
    static public void Main()
    {
		int tried = 0;
		int num = 0;
		string input;
		int CountPrimes = 0, SumEven = 0, MaxOdd = 0, SumDivBy7 = 0;

		// sanitize user input
		Console.Write("Enter a number between 10 and 200: ");
		while (tried < 3){
			input = Console.ReadLine();
			if (!int.TryParse(input, out num))
			{
				Console.WriteLine("Enter an integer please");
				tried++;
			}
			else
			{
				if ((num < 10) || (num > 200)){
					Console.Write("Invalid range. Input again:");
					tried++;
					continue;
				}
				break;
			}
		}
		if (tried == 3){
			Console.WriteLine("");
			Console.WriteLine("Too many attempts exit.");
			Environment.Exit(1);
		}

		for (int i = 1; i <= num; i++){
			if(isPrime(i)){
				Console.Write("[" + i + "] ");
				CountPrimes++;
			}
			else if(((i % 3) == 0) && ((i % 5) == 0)){
				Console.Write("FizzBuzz ");
			}
			else if((i % 3) == 0){
				Console.Write("Fizz ");
			}
			else if((i % 5) == 0){
				Console.Write("Buzz ");
			}
			if((i % 7) == 0){
				SumDivBy7+=i;
			}
			if((i % 2) == 0){
				SumEven+=i;
				Console.Write(i + " ");
			}
			else{
				MaxOdd = (i > MaxOdd) ? i : MaxOdd;
				Console.Write(i + " ");
			}
		}
		Console.WriteLine();
		Console.WriteLine("Count primes: " + CountPrimes);
		Console.WriteLine("Sum Even: " + SumEven);
		Console.WriteLine("Max Odd: " + MaxOdd);
		Console.WriteLine("Sum Div by 7: " + SumDivBy7);
    }
}
