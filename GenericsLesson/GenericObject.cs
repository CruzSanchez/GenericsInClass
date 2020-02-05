using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLesson
{
    //Creating a new class that takes 2 generic types
    //T can only be a struct
    //U can only be a struct
    //We can change one of these params constraints to be where T must be a class and then pass the SomeCustomObject in as well.
    class GenericObject<T, U> where T : struct where U: struct
    {
        //Property that will take on the generic type that is passed in for T
        public T GenericProperty { get; set; }

        //Method that takes generic parameters.
        public void Swap(T input1, U input2)
        {
            Console.WriteLine("Swapping your objects!");
        }
    }
}
