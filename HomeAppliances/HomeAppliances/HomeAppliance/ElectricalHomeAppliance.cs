using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAppliances.HomeAppliance
{
    internal class ElectricalHomeAppliance : HomeAppliances
    {
        public ElectricalHomeAppliance(float powerrating, bool switchstatus) : base(powerrating, switchstatus)
        {
            if (hierarchy.Contains("--Electrical") == false)
                hierarchy.Add("--Electrical");
        }
        public override void printwhoiam()
        {
            Console.WriteLine("I am an electrical home appliance");
        }
    }
    class heating : ElectricalHomeAppliance
    {
        public heating(float powerrating, bool switchstatus) : base(powerrating, switchstatus)
        {
            if (hierarchy.Contains("----Heating") == false)
                hierarchy.Add("----Heating");
        }
        public override void printwhoiam()
        {
            Console.WriteLine("I am a heating electrical home appliance");
        }
    }
    class nonheating : ElectricalHomeAppliance
    {
        public nonheating(float powerrating, bool switchstatus) : base(powerrating, switchstatus)
        {
            if (hierarchy.Contains("----Non-heating") == false)
                hierarchy.Add("----Non-heating");
        }
        public override void printwhoiam()
        {
            Console.WriteLine("I am a non-heating electrical home appliance");
        }
    }
    class oven : heating
    {
        public oven(float powerrating, bool switchstatus = false) : base(powerrating, switchstatus)
        {
            hierarchy.Add("------oven");
        }
        public override void printwhoiam()
        {
            Console.WriteLine("I am an oven");
        }
    }

    class gyser : heating
    {
        public gyser(float powerrating, bool switchstatus = false) : base(powerrating, switchstatus)
        {
            hierarchy.Add("------gyser");
        }
        public override void printwhoiam()
        {
            Console.WriteLine("I am a gyser");
        }
    }
    class light : nonheating
    {
        public light(float powerrating, bool switchstatus = false) : base(powerrating, switchstatus)
        {
            hierarchy.Add("------light");
        }
        public override void printwhoiam()
        {
            Console.WriteLine("I am a light");
        }
    }

    class fan : nonheating
    {
        public fan(float powerrating, bool switchstatus = false) : base(powerrating, switchstatus)
        {
            hierarchy.Add("------fan");
        }
        public override void printwhoiam()
        {
            Console.WriteLine("I am a fan");
        }
    }
}
