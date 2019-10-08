using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topas4LibExample {
    class Program {

        static void Main (string[] args) {
            var serialNumber = "00666"; //change to actual serial number of your own device.
            var example = new Topas4SDKExample (serialNumber);
            example.Run ();

        }
    }
}
