using System;

namespace Animals
{
	class Program
	{
		//Define the Base Class
		public abstract class Animal
		{
			private int _legs;
			private int _age;

			public int Legs
			{
				get { return _age; }
				set { _age = value; }
			}

			public int Age
			{ get; set; }
		}
		
		//Define the Derivate Classes
		//Dog
		public class Dog : Animal
		{
			private string _furcolor;
			public string FurColor
			{
				get { return _furcolor; }
				set { _furcolor = value; }
			}
			//Constructor
			public Dog()
			{
				Legs = 4;
				Console.WriteLine("This is dog!");
			}
			//Destructor
			~Dog()
			{
				Console.WriteLine("Dog is gone..");
			}
		}
		
		public class Cat : Animal
		{
			public Cat()
			{
				Console.WriteLine("Cat Created");
			}
			~Cat()
			{
				Console.WriteLine("Cat Destroyed :(");
			}
		}
	}
	
	static void main(string[] args)
	{
		string myFur;
		myDog = new Dog();
		Console.WriteLine("What color is the Dog's fur?");
		myFur = Console.ReadLine();
		myDog.FurColor() = myFur;
		Console.WriteLine("The Dog's fur color is: " + myDog.FurColor);
		Console.ReadLine();
	}
}