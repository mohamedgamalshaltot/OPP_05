using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OPP_05
{
  internal static class ShipmentExtensions
    {
        // 1. ميثود الـ GetSummary
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.trackingCode} | {shipment.GetType().Name} | {shipment.Weight} KG | {shipment.TrackingStatus}";
        }

        // 2. ميثود الـ IsDelivered
        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.TrackingStatus == "Delivered";
        }
    }
}
