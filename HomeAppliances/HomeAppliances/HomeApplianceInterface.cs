using System.Collections.Generic;

namespace HomeAppliances
{
    interface HomeApplianceInterface
    {
        public void getlistofequipments();
        public void switchonoffequipments(List<int> switchlistofappliances, bool onoff);
        public void gettotalpowerconsumption();
        public void getappliance(float powerrating);
        public void gethierarchyofappliances();
    }
}
