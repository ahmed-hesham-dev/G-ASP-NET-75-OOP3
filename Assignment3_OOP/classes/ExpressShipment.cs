using System;

namespace Assignment3_OOP
{
    internal class ExpressShipment : Shipment
    {


        private decimal extraFee;
        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) :
            base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }



        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }

            set
            {
                if (value >= 0)
                {

                    extraFee = value;

                }
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5) + ExtraFee;
            }

        }

        public override void PrintShipment()
        {
            Console.WriteLine("Shipment Information");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight}");
            Console.WriteLine($"Extra Fee     : {ExtraFee}");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
            Console.WriteLine($"Destination   : {Destination.GetFullAddress()}");
        }

    }
}
