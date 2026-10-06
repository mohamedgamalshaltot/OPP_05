namespace CSharp_OPP_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            /*Q1  Object Copying*/
            //a) What happens when you assign one object variable to another object variable?
            // When you assign one object variable to another, you copy the reference (memory address), not the object itself. Both variables now point to the same object in memory, meaning changes made through one variable will affect the other.

            //b) Does assigning one object to another create a new object? Explain.
            // No, assigning one object to another does not create a new object. It simply copies the reference to the existing object. Both variables refer to the same instance in memory.\

            //c) What is the difference between copying an object and copying its reference?
            // Copying an object creates a new instance of the object with the same values, while copying its reference means both variables point to the same instance in memory. Changes made through one reference will affect the other.
      

            /*Q2  Shallow Copy vs Deep Copy*/
            //a) What is a Shallow Copy?
            // A shallow copy creates a new object, but it copies the references of the nested objects instead of creating new instances of them. This means that changes made to nested objects in the copied object will affect the original object.

            //b) What is a Deep Copy?
            // A deep copy creates a new object and recursively copies all the objects it references, creating entirely new instances of the nested objects. This means that changes made to nested objects in the copied object will not affect the original object.

            //c) What happens to reference-type members when a Shallow Copy is created?
            // When a shallow copy is created, reference-type members (like objects, arrays, etc.) are not duplicated; instead, their references are copied. This means that both the original and the copied object will point to the same reference-type members, so changes made to those members in one object will be reflected in the other.

            //d) What happens to reference-type members when a Deep Copy is created?
            // When a deep copy is created, reference-type members are also duplicated, meaning that new instances of those members are created. As a result, changes made to the reference-type members in the copied object will not affect the original object, as they are now separate instances.

            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            // Deep Copy would be safer than Shallow Copy in situations where you need to ensure that the original object remains unchanged when modifications are made to the copied object. For example, if you are working with a complex data structure (like a tree or graph) and you want to create a copy for manipulation without affecting the original structure, a deep copy would be necessary to avoid unintended side effects.    

            #endregion
        }
    }
}
