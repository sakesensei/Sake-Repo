using System;

namespace Animals
{
	class Program
	{
		//Define the Base Class
		class Animal
		{
			public int Legs { get; set; }
			public int Age { get; set; }
		}
		
		//Define the Derivate Classes
		//Dog
		class Dog : Animal
		{
			public Dog() //Constructor
			{
				public string FurColor { get; set;}
				
				Legs = 4;
				Console.WriteLine("This is dog!");
			}
			~Dog() //Destructor
			{
				Console.WriteLine("Dog is gone..");
			}
		}
		
		class Cat : Animal
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
		var string myFur;
		myDog = new Dog();
		Console.WriteLine("What color is the Dog's fur?");
		myFur = Console.ReadLine();
		myDog.FurColor() = myFur;
		Console.WriteLine("The Dog's fur color is: " + myDog.FurColor);
		Console.ReadLine();
	}
}
