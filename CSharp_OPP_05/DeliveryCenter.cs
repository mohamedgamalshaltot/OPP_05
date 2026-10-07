using CSharp_OPP_05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OPP_05
{
    internal class DeliveryCenter
    {
        // الخصائص العامة
        public string CenterName { get; set; }
      
        public Driveer AssignedDriver { get; set; }

      
        private Shipment[] shipments = new Shipment[20];
       
        private int count = 0;

        
        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
        }

        
        internal Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                    return shipments[index];

                return null;
            }
            set
            {
                if (index >= 0 && index < count)
                    shipments[index] = value;
            }
        }
        internal Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (shipments[i] != null && shipments[i].trackingCode == trackingCode)
                        return shipments[i];
                }
                return null;
            }
        }

        // دالة إضافة شحنة AddShipment (مطلوب الاحتفاظ بها من Assignment 01)
        internal bool AddShipment(Shipment shipment)
        {
            if (shipment == null || count >= 20)
                return false;

            shipments[count] = shipment;
            count++;
            return true;
        }


        public bool RemoveShipment(string trackingCode)
        {
            if (string.IsNullOrEmpty(trackingCode))
                return false;

            for (int i = 0; i < count; i++)
            {
                if (shipments[i] != null && shipments[i].trackingCode == trackingCode)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        shipments[j] = shipments[j + 1];
                    }

                    shipments[count - 1] = null;
                    count--;

                    return true;
                }
            }

            return false;
        }
        // PrintAllShipments Method
         public void PrintAllShipments()
        {
    if (count == 0)
    {
        Console.WriteLine("No shipments stored in this delivery center.");
        return;
    }

    Console.WriteLine($"--- Shipments in {CenterName} ---");
    for (int i = 0; i<count; i++)
    {
        if (shipments[i] != null)
        {
                    shipments[i].PrintShipment();
                    Console.WriteLine("-------------------------------");
        }
    }

}
        public void PrintTrackingStatus()
        {
            foreach (var shipment in shipments)
            {
                if (shipment is ITrackable trackableShipment)
                {
                    Console.WriteLine(trackableShipment.GetTrackingStatus());
                }
            }
        }
    }
}
    

  