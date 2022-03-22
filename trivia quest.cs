using System;

namespace Quiz
{

	class Program
	{

		static void Main()
		{
			string name, input;
			int age;
			Console.WriteLine("---------------------------WELCOME TO TRIVIA QUEST----------------------------");
			Console.WriteLine("");
			Console.Write("What is your name: ");
			name = Console.ReadLine();
			Console.Write("What is your age: ");
			input = Console.ReadLine();
			Console.WriteLine("");

			var totalScore = 0;


			Console.WriteLine("These questions will test your general knowledge ");
			Console.WriteLine("");
			Console.Write("To answer the question type \"true\" or \"false\"\n");

			Console.WriteLine("");
			Console.Write("1. Every statement has a truth value.\n");

			var entry = Console.ReadLine();

			if (entry.ToLower() == "true")
			{
				totalScore += 1;
			}

			Console.Write("2. Two simple statements joined by a connective to form a compound statement are known as a disjunction \n");

			var entry2 = Console.ReadLine();

			if (entry2.ToLower() == "false")
			{
				totalScore += 1;
			}

			Console.Write("3.The word unless is sometimes used in place of or to form a disjunction\n");

			var entry3 = Console.ReadLine();

			if (entry3.ToLower() == "true")
			{
				totalScore += 1;
			}

			Console.Write("4. A double negation is the same thing as no negation. \n");

			var entry4 = Console.ReadLine();

			if (entry4.ToLower() == "true")
			{
				totalScore += 1;
			}
			Console.Write("5.In a conditional, the word whenever introduces the consequent. \n");

			var entry5 = Console.ReadLine();

			if (entry5.ToLower() == "false")
			{
				totalScore += 1;
			}
			Console.Write("6.In a three-variable truth table, there are six rows. \n");

			var entry6 = Console.ReadLine();

			if (entry6.ToLower() == "false")
			{
				totalScore += 1;
			}
			Console.Write("7.The argument form known as affirming the consequent is invalid. \n");

			var entry7 = Console.ReadLine();

			if (entry7.ToLower() == "true")
			{
				totalScore += 1;
			}
			Console.Write("8.If just one statement in a conjunction is false, the whole conjunction is still true. \n");

			var entry8 = Console.ReadLine();

			if (entry8.ToLower() == "false")
			{
				totalScore += 1;
			}
			Console.Write("9. If only one statement in a disjunction is true, the whole disjunction is false.\n");

			var entry9= Console.ReadLine();

			if (entry9.ToLower() == "false")
			{
				totalScore += 1;
			}
			Console.Write("10. The symbol used to indicate a conjunction is &.\n");

			var entry10 = Console.ReadLine();

			if (entry10.ToLower() == "true")
			{
				totalScore += 1;
			}






			Console.Write("Your score is: " + totalScore + "\n");


		}

	}

}