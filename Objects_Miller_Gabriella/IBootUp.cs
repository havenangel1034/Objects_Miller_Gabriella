using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Miller_Gabriella
{

    // Declaring an internal interface named IBootUp
    // Interfaces define a contract that implementing classes must follow
    internal interface IBootUp
    {

        // Property to indicate whether the device is powered on or off
        public bool IsOn {  get; set; }

        // Method signature for toggling the power state (implementation provided by classes that implement this interface)
        public void PowerOnOff();

    }
}
