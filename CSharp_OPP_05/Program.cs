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
            #region Part 01 — Theoretical Questions Q3 Q4 Q5
            /*Q3  Static Members*/
            //a) What is a static field, and how is it different from an instance field?
            // A static field is a variable that belongs to the class itself rather than any specific instance of the class. It is shared among all instances of the class, meaning that there is only one copy of the static field regardless of how many objects are created. In contrast, an instance field is unique to each object instance, and each object has its own copy of the instance field.

            //b) What is a static method? Can a static method directly access instance members?
            // A static method is a method that belongs to the class itself rather than any specific instance of the class. It can be called without creating an instance of the class. A static method cannot directly access instance members (fields or methods) because it does not have a reference to any specific object instance. To access instance members, a static method would need to create an instance of the class or receive an instance as a parameter.

            //c) What is a static constructor, and when is it executed?
            // A static constructor is a special constructor that is used to initialize static members of a class. It is executed automatically by the runtime before any static members are accessed or any instances of the class are created. The static constructor is called only once, and it cannot take parameters or have access modifiers.

            //d) What is a static class? Can you create an object from a static class?
            // A static class is a class that cannot be instantiated and can only contain static members (fields, methods, properties, etc.). It is used to group related static members together. You cannot create an object from a static class because it does not have any instance members or constructors.

            /*Q4  Extension Methods*/
            //a) What is an extension method?
            // An extension method is a special kind of static method that allows you to "add" new methods to existing types without modifying the original type or creating a new derived type. Extension methods are defined in static classes and use the "this" keyword in their first parameter to specify the type they extend.

            //b) What keyword must be used in the first parameter of an extension method?
            // The "this" keyword must be used in the first parameter of an extension method to specify the type they extend.

            //c) Where must an extension method be declared?
            // An extension method must be declared in a static class. The static class serves as a container for the extension methods, and it can contain multiple extension methods for different types.

            //d) Can an extension method access private members of the class it extends?
            // No, an extension method cannot access private members of the class it extends. Extension methods can only access public and protected members of the class they extend, as they are defined outside of the class and do not have access to its private members.

            /*Q5  Partial Classes and Partial Methods*/
            //a) What is a partial class?
            // A partial class is a class that can be split into multiple files, allowing developers to organize code more effectively. Each part of the partial class must use the "partial" keyword in its declaration, and when compiled, all parts are combined into a single class definition.

            //b) Why would a developer split one class into multiple files?
            // A developer might split one class into multiple files to improve code organization, maintainability, and readability. It allows different team members to work on separate parts of the class simultaneously without causing merge conflicts. Additionally, it can help separate auto-generated code from manually written code, making it easier to manage.

            //c) What is a partial method?
            // A partial method is a method that is declared in one part of a partial class and can be optionally implemented in another part of the same partial class. If the partial method is not implemented, the compiler removes its declaration and any calls to it, resulting in no performance overhead. Partial methods must have a void return type and cannot have access modifiers.

            //d) What happens if a declared partial method has no implementation?
            // If a declared partial method has no implementation, the compiler removes its declaration and any calls to it during compilation. This means that there will be no performance overhead, and the method will effectively not exist in the compiled code. The absence of an implementation allows developers to define hooks for optional functionality without forcing them to provide an implementation.
            #endregion
        }
    }
}
