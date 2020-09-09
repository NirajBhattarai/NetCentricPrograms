using System;

namespace constructor
{

   class Car
{
  public string model;

  // Create a class constructor with a parameter
  public Car(string modelName)
  {
    model = modelName;
  }
}

    
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang");
            Console.WriteLine(Ford.model);
        }
    }
}
