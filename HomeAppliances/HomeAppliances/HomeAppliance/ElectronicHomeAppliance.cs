using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAppliances.HomeAppliance
{
    internal class ElectronicHomeAppliance : HomeAppliances
    {
        public ElectronicHomeAppliance(float powerrating, bool switchstatus) : base(powerrating, switchstatus)
        {
            if (hierarchy.Contains("--Electronic") == false)
                hierarchy.Add("--Electronic");
        }
        public override void printwhoiam()
        {
            Console.WriteLine("I am an electronic home appliance");
        }
    }

    class TV : ElectronicHomeAppliance
    {
        public TV(float powerrating, bool switchstatus) : base(powerrating, switchstatus)
        {
            hierarchy.Add("----TV");
        }
        public override void printwhoiam()
        {
            Console.WriteLine("I am a TV");
        }
    }
}
