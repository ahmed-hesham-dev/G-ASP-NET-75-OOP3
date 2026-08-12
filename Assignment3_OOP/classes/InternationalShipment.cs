using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3_OOP
{
    internal class InternationalShipment : Shipment
    {


        private String destinationCountry;
        private decimal customsFee;

        public InternationalShipment(string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee) :

            base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }


        public string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }
        }


        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }


        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5) + CustomsFee;
            }
        }
    }
}
