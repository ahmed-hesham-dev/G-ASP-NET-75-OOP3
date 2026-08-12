using System;

namespace Assignment3_OOP
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments;

        public string CenterName { get; set; }

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            shipments = new Shipment[20];
        }

        // Integer Indexer
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];

                return default;
            }

            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }

        // String Indexer
        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (Shipment shipment in shipments)
                {
                    if (shipment != null &&
                        shipment.TrackingCode == trackingCode)
                    {
                        return shipment;
                    }
                }

                return default;
            }
        }

        // Add Shipment
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        // Remove Shipment
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }

        // Print All Shipments
        public void PrintAllShipments()
        {
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null)
                {
                    shipment.PrintShipment();
                }
            }
        }
    }
}