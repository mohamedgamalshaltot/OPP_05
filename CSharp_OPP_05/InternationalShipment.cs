using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OPP_05
{
    internal class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryfee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryfee, destination)
        {
        }
        public decimal CalculateInsurance()
        {
            // Assuming insurance cost is 2% of the estimated cost
            return EstimatedCost * 0.012m;
        }
        private string DestinationCountry = string.Empty;
        private decimal CustomsFee;
        public string destinationCountry
        {
            get => destinationCountry;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("DestinationsCountry cannot be null,empty,or whitespace.");
                }
                destinationCountry = value;
            }
        }
        public decimal customsFee
        {
            get => customsFee;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "CustomsFee must be greater than or equal to 0.");
                }
            }
        }
        public InternationalShipment(
        string trackingCode,
        string destinationCountry,
        decimal customsFee)
        : base(trackingCode) // بنبعت الـ trackingCode بس للـ base
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        public override decimal EstimatedCost

        {
            get => DeliveryFee + (Weight * 15m) + CustomsFee;
        }
        public override void PrintShipment()
        {
            Console.WriteLine("[International Shipment]");
            Console.WriteLine($"Tracking Code : {trackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Insurance     : {CalculateInsurance()} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("-----------------------------------");
        }
        public string GetTrackingStatus()
        {
            return $"International Shipment [{trackingCode}] has been delivered.";
        }


    }
}
