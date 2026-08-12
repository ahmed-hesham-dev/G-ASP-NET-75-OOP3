using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_OOP.classes
{
    public sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination) :
            base(trackingCode, description, weight, deliveryFee, destination)
        { }
    }
}
