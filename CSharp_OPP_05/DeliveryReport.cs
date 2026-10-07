
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OPP_05
{
    internal class DeliveryReport

    {
        public static void PrintInsurance(IInsurable shipment)
        {
            // Print the class type name and the calculated insurance
            string shipmentType = shipment.GetType().Name; // StandardShipment, ExpressShipment...

            // Formatting name for output
            if (shipmentType == "StandardShipment") shipmentType = "Standard Shipment";
            else if (shipmentType == "ExpressShipment") shipmentType = "Express Shipment";
            else if (shipmentType == "InternationalShipment") shipmentType = "International Shipment";

            Console.WriteLine($"{shipmentType} Insurance : {shipment.CalculateInsurance():0.00} EGP");
        }
     
    }
}
