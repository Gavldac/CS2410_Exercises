using System;
namespace LabInheritance
{
	public class Cat : Pet
	{
		public Cat(string name) : base (name)
		{
		}

        public override string Communicate()
        {
            return "Meow";
        }
    }
}

