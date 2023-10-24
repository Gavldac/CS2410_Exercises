using System;
namespace LabInheritance
{
	public class Dog : Pet
	{
		public Dog(string name) : base (name)
		{

		}

        public override string Communicate()
        {
            return "Woof woof"; 
        }
    }
}

