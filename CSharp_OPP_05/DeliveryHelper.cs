using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OPP_05
{ 
    internal static class DeliveryHelper
    {
       internal static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment !=null)
            {
                shipment.PrintShipment();
            }
        }
    }
}
