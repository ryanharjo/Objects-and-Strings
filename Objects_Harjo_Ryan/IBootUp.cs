using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Harjo_Ryan
{
    // Internal interface accessible only within the same assembly
    internal interface IBootUp
    {
        // Property indicating whether the device is powered on (true) or off (false)
        public bool IsOn { get; set; }
        // Method to toggle the power state of the device
        public void PowerOnOff(); 
    }
}
