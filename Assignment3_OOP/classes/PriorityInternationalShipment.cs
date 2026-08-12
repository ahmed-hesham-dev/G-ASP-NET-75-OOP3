using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_OOP.classes
{
    public class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee) :
            base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
        { }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("GenerateCustomsReport");

        }
    }
}
