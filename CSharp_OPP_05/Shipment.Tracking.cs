using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OPP_05
{


    internal abstract partial class Shipment
    {
        // الـ tracking status والخاصة بالتتبع

        partial void OnTrackingStatusChanged(string newStatus);
        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            TrackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);
        }
    }
    }


