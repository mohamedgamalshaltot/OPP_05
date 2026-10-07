using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OPP_05
{
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {
        // Constructor Chaining
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode)
        {
            this.Description = description;
            this.Weight = weight;
            this.DeliveryFee = deliveryFee;
            this.destination = destination;
        }

        // 1. Override EstimatedCost
        public override decimal EstimatedCost
        {
            get => DeliveryFee + (Weight * 5m);
        }

        // 2. Override PrintShipment()
        public override void PrintShipment()
        {
            Console.WriteLine($"[Standard Shipment]");
            Console.WriteLine($"Tracking Code : {this.trackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("------------------------------------------");
        }
        public string GetTrackingStatus()
        {
            return $"Standard Shipment [{trackingCode}] is ready.";
        }
        public decimal CalculateInsurance()
        {
            // Assuming insurance cost is 1% of the estimated cost
            return EstimatedCost * 0.05m;
        }
    }
}