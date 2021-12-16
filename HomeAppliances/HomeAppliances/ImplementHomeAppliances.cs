using HomeAppliances.Decorator;
using HomeAppliances.HomeAppliance;
using System;
using System.Collections.Generic;

namespace HomeAppliances
{
    public class ImplementHomeAppliances : HomeApplianceInterface
    {
        internal List<HomeAppliances> myequips = new List<HomeAppliances>();
        public ImplementHomeAppliances()
        {
            createlistofequipments();
        }
        public void getlistofequipments()
        {
            foreach (HomeAppliances a in myequips)
            {
                Console.WriteLine("Switch ID : " + a._id + " will turn on " + a.GetType());
                Console.WriteLine("The switch status is " + a._switchstatus);
                a.printwhoiam(); //demonstrates polymorphism 
            }
        }
        void createlistofequipments()
        {
            //adding equipments
            TV halltv = new TV(50, true);
            myequips.Add(halltv);

            oven kitchenoven = new oven(3000);
            myequips.Add(kitchenoven);

            gyser bathroomgyser = new gyser(500);
            myequips.Add(bathroomgyser);

            light lightbulb = new light(80, true);
            myequips.Add(lightbulb);

            light tubelight = new light(50, true);
            LightDecorator lighttube = new SmartLightDecorator(tubelight);
            Console.WriteLine("Decorated Powerrating : " + lighttube.decoratedpowerrating());
            myequips.Add(lighttube);

            fan roomfan = new fan(60);
            myequips.Add(roomfan);
        }
        public void switchonoffequipments(List<int> switchlistofappliances, bool onoff)
        {
            foreach (int i in switchlistofappliances)
            {
                HomeAppliances appliancefound = myequips.Find(x => x._id == i); //lamda exp to find the equipment
                appliancefound._switchstatus = onoff;
            }  
        }
        public void gettotalpowerconsumption()
        {
            float total = 0;
            foreach (HomeAppliances h in myequips)
            {
                if (h._switchstatus == true)
                    total += (h._powerrating * 24);
            }
            Console.WriteLine("Total power consumption per day is : " + total / 1000 + "kWh");
        }
        public void getappliance(float powerrating)
        {
            HomeAppliances equipfound = new HomeAppliances(0);
            foreach(HomeAppliances h in myequips)
                equipfound = myequips.Find(x => x._powerrating == powerrating);
            if (equipfound != null)
                Console.WriteLine("The appliance found is : " + equipfound);
            else
                Console.WriteLine("No appliance found");
        }
        public void gethierarchyofappliances()
        {
            foreach (string s in HomeAppliances.hierarchy)
                Console.WriteLine(s);
        }
    }
}
