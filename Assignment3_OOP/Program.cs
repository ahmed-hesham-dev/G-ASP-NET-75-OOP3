namespace Assignment3_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Theoretical Questions1
            // a) Difference between Method Overloading and Method Overriding:

            // Method Overloading:
            // - Same method name with different parameters.
            // - Happens at compile time.
            // - It is an example of compile-time polymorphism.


            // b) Difference between Static Binding and Dynamic Binding:

            // Static Binding:
            // - The method call is resolved at compile time.
            // - Also called Early Binding.
            // - Commonly associated with method overloading.

            // Dynamic Binding:
            // - The method call is resolved at runtime.
            // - Also called Late Binding.
            // - Commonly associated with method overriding.

            #endregion

            #region Theoretical Questions2
            // a) What is the purpose of the sealed keyword when applied to a class?
            // - The sealed keyword prevents a class from being inherited.
            // - A sealed class cannot be used as a base class.


            // b) What is the difference between a sealed class and a sealed method?
            // - A sealed class cannot be inherited by another class.
            // - A sealed method cannot be overridden by a derived class.
            // - A sealed method must be an overridden method.


            /*
            c) Can a sealed method be overridden? Why?

            // No, a sealed method cannot be overridden.
            // Because the sealed keyword prevents further overriding
            // of the method in derived classes.
            */
            #endregion
        }
    }
}
