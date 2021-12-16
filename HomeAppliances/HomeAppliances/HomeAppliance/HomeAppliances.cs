using System;
using System.Collections.Generic;

namespace HomeAppliances
{
    internal class HomeAppliances //this internal class is encapsulating home appliances
    {
        static int count = 1;
        public float _powerrating { get; set; }
        public bool _switchstatus { get; set; }
        public int _id { get; set; }
        public static List<string> hierarchy = new List<string>();
        public HomeAppliances(float powerrating, bool switchstatus = false)
        {
            _powerrating = powerrating;
            _switchstatus = switchstatus;
            _id = count++;
            if(hierarchy.Contains("HomeAppliance") == false)
                hierarchy.Add("HomeAppliance");
        }
        public virtual void printwhoiam()
        {
            Console.WriteLine("I am a home appliance");
        }
    }
}
