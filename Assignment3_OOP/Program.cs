using Assignment3_OOP.classes;
using System;

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

            #region Main Practical (Q9)

            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            // a. Create a Driver
            Driver driver = new ("Ahmed Hehsam");

            // b. Create a DeliveryCenter
            DeliveryCenter center = new ("Main Center");

            // c. Assign the Driver to the DeliveryCenter
            center.AssignedDriver = driver;

            Console.WriteLine($"Driver : {center.AssignedDriver.Name}");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");

            // d. Create one StandardShipment
            Shipment standardShipment = new StandardShipment(
                "SH001", "Laptop", 3, 80, new DeliveryAddress("Cairo", "Egypt", 12345));

            // e. Create one ExpressShipment
             Shipment expressShipment = new ExpressShipment(
                "SH002", "Mobile Phone", 2, 60, new DeliveryAddress("Giza", "Egypt", 12346), 30);

            // f. Create one InternationalShipment
            Shipment internationalShipment = new InternationalShipment(
                "SH003", "Television", 8, 120, new DeliveryAddress("Berlin", "Germany", 10115),
                "Germany", 100);

            // g. Add all shipments to the DeliveryCenter
            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(internationalShipment);

            // h. Print all shipments using PrintAllShipments()
            center.PrintAllShipments();

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Printing Using DeliveryHelper...");

            // i. Call DeliveryHelper.PrintShipmentDetails() for each shipment
            DeliveryHelper.PrintShipmentDetails(standardShipment);
            Console.WriteLine();
            DeliveryHelper.PrintShipmentDetails(expressShipment);
            Console.WriteLine();
            DeliveryHelper.PrintShipmentDetails(internationalShipment);

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Updating Weight...");
            Console.WriteLine();
            Console.WriteLine($"Original Weight : {standardShipment.Weight} KG");
            Console.WriteLine();

            // j. Demonstrate both versions of UpdateWeight()
            standardShipment.UpdateWeight(5);
            Console.WriteLine($"Updated Weight : {standardShipment.Weight} KG");
            Console.WriteLine();

            standardShipment.UpdateWeight(5, 0.5);
            Console.WriteLine($"Updated Weight After Packing : {standardShipment.Weight} KG");

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.WriteLine("Printing Using Shipment[]...");
            Console.WriteLine();

            // k. Build a Shipment[] holding mixed types and print all of them in a loop
            Shipment[] mixedShipments = new Shipment[]
            {
                standardShipment,
                expressShipment,
                internationalShipment
            };

            foreach (Shipment shipment in mixedShipments)
            {
                Console.WriteLine($"{shipment.GetType().Name}...");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine();

            // l. Demonstrate the sealed class and sealed method

            // Sealed Class demonstration:
            // CompletedShipment is marked 'sealed' -> cannot be inherited by any other class.
            // The following line would cause a compile error if uncommented in another file:
            // public class SubCompleted : CompletedShipment { }  // ERROR: cannot derive from sealed type
            CompletedShipment completed = new CompletedShipment(
     "SH004", "Completed Package", 4, 70,
     new DeliveryAddress("Alexandria", "Egypt", 21500));
            completed.PrintShipment();

            Console.WriteLine();

            // Sealed Method demonstration:
            // PriorityInternationalShipment overrides GenerateCustomsReport() and seals it
            // -> no further derived class can override it again.
            // A class inheriting from PriorityInternationalShipment trying to override it again
            // would cause a compile error, e.g.:
            // public override void GenerateCustomsReport() { }  // ERROR: cannot override sealed member
            PriorityInternationalShipment priorityShipment = new PriorityInternationalShipment(
                "SH005", "Urgent Documents", 1, 150,
                new DeliveryAddress("Paris", "France", 75000), "France", 50);
            priorityShipment.GenerateCustomsReport();

            #endregion

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}