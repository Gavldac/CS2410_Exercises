using System;

namespace LabInheritance
{
   // Class Pet should NOT be modified
   public class Pet
   {
      public string Name { get; }

      public Pet(string name)
      {
         Name = name;
      }

      public virtual string Communicate()
      {
         return "communicate";
      }

      public override string ToString()
      {
         return string.Format("{0} named {1}", this.GetType().Name, Name);
      }
   }

}
