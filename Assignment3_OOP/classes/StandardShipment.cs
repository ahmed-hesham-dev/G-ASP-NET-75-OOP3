using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_OOP
{
    public class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) :
            base(trackingCode, description, weight, deliveryFee, destination)
        { }

        public override void PrintShipment()
        {
            Console.WriteLine("Shipment Information");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight}");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
        }


    }
}
