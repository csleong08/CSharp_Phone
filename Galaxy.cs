using System;

namespace Phone
{
    public class Galaxy : Phone, IRingable 
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            return "... Dooo do doo dooo ...";
        }
        
        public string Unlock() 
        {
            return "Galaxy s8 unlocked with fingerprint scanner";
        }
        public override void DisplayInfo() 
        {
            System.Console.WriteLine("#########################");
            System.Console.WriteLine("Galaxy " + _versionNumber);
            System.Console.WriteLine("Battery Percentage: " + _batteryPercentage);
            System.Console.WriteLine("Carrier: " + _carrier);
            System.Console.WriteLine("Ring Tone: " + _ringTone);
            System.Console.WriteLine("#########################");
            System.Console.WriteLine("");
        }
    }
}