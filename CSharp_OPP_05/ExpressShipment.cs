using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OPP_05
{
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        public decimal ExtraFee { get; set; }

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode)
        {
            this.Description = description;
            this.Weight = weight;
            this.DeliveryFee = deliveryFee;
            this.destination = destination;
            this.ExtraFee = extraFee;
        }

        // 1. Override EstimatedCost
        public override decimal EstimatedCost
        {
            get => DeliveryFee + (Weight * 10m) + ExtraFee;
        }

        // 2. Override PrintShipment()
        public override void PrintShipment()
        {
            Console.WriteLine($"[Express Shipment]");
            Console.WriteLine($"Tracking Code : {trackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("------------------------------------------");
        }
        public string GetTrackingStatus()
        {
            return $"Express Shipment [{trackingCode}] is Out of Delivery.";
        }
        public decimal CalculateInsurance()
        {
            // Assuming insurance cost is 1.5% of the estimated cost
            return EstimatedCost * 0.08m;
        }
    }
}